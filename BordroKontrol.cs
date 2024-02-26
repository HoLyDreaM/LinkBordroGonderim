using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Bordro_Gonder
{
    public partial class BordroKontrol : Form
    {
        public BordroKontrol()
        {
            InitializeComponent();
        }

        public AnaForm anaFrm
        {
            get;
            set;
        }

        Thread Kanal;
        SqlConnection Conn, conHata;
        SqlCommand cmd;

        public string Cs, CsKontrol;
        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath + "\\Email.ini");

        string SirketUnvani, SirketSskNo, SirketTicaretSicilNo, SirketMerkezi, SirketWebAdresi, BaslangicTarihi, BitisTarihi;

        string[] TcNoBilgileri;
        string[] EpostaBilgileri;
        string[] GidecekAdSoyad;
        string[] DosyaAdresi;

        private void BordroKontrol_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBordrolar.EmailDurumu' table. You can move, or remove it, as needed.
            //this.emailDurumuTableAdapter.GonderilenEmailAdresleri(this.dsBordrolar.EmailDurumu);
            Conn = new SqlConnection(CsKontrol);
            btnBordroGonder.Enabled = false;
            dtBaslangic.DateTime = DateTime.Now;
            dtBitis.DateTime = DateTime.Now;
        }

        private void btnHataliBordrolar_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangicx;
            DateTime dtBitisx;

            dtBaslangicx = Convert.ToDateTime(dtBaslangic.Text.ToString());
            BaslangicTarihi = Convert.ToString(dtBaslangicx.ToString("yyyy-MM-dd"));

            dtBitisx = Convert.ToDateTime(dtBitis.Text.ToString());
            BitisTarihi = Convert.ToString(dtBitisx.ToString("yyyy-MM-dd"));

            this.emailDurumuTableAdapter.EmailGonderimDurumKontrolu(dsBordrolar.EmailDurumu, BaslangicTarihi, BitisTarihi, 0);

            if (dsBordrolar.EmailDurumu.Rows.Count > 0)
            {
                btnBordroGonder.Enabled = true;
            }
            else
            {
                btnBordroGonder.Enabled = false;
            }
        }

        private void btnHatasizBordrolar_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangicx;
            DateTime dtBitisx;

            dtBaslangicx = Convert.ToDateTime(dtBaslangic.Text.ToString());
            BaslangicTarihi = Convert.ToString(dtBaslangicx.ToString("yyyy-MM-dd"));

            dtBitisx = Convert.ToDateTime(dtBitis.Text.ToString());
            BitisTarihi = Convert.ToString(dtBitisx.ToString("yyyy-MM-dd"));

            this.emailDurumuTableAdapter.EmailGonderimDurumKontrolu(dsBordrolar.EmailDurumu, BaslangicTarihi, BitisTarihi, 1);
            btnBordroGonder.Enabled = false;
        }

        private void FirmaBilgileri()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sorgu = "SELECT TOP(1) PER004_Unvan1+' ' +PER004_Unvan2 AS Unvan,PER004_IsyerininSskNumarasi AS SskNo, " +
                        "PER004_TicaretSicilNo AS TicaretSicilNo,PER004_Ilce+'/'+PER004_Il AS IsletmeMerkezi, " +
                        "PER004_WebAdres AS WebAdresi " +
                        "FROM PER004 ";

            cmd = new SqlCommand(sorgu, Conn);

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (dr.Read())
            {
                SirketUnvani = dr["Unvan"].ToString();
                SirketSskNo = dr["SskNo"].ToString();
                SirketTicaretSicilNo = dr["TicaretSicilNo"].ToString();
                SirketMerkezi = dr["IsletmeMerkezi"].ToString();
                SirketWebAdresi = dr["WebAdresi"].ToString();
            }

            dr.Dispose();
            dr.Close();
        }

        private void EmailGonder()
        {
            btnBordroGonder.Enabled = false;
            btnHataliBordrolar.Enabled = false;
            btnHatasizBordrolar.Enabled = false;

            string GidecekEmailAdresi = iniOku.IniOku("Email", "Kullanici");
            string GidecekEmailSifresi = Coz(iniOku.IniOku("Email", "Pw"));
            string GidecekPort = iniOku.IniOku("Email", "Port");
            string GidecekHosting = iniOku.IniOku("Email", "Sunucu");
            string GidecekEmailKonusu = DateTime.Now.ToString();
            bool GidecekEmailSslDurumu = Convert.ToBoolean(iniOku.IniOku("Email", "Sll"));

            for (int i = 0; i < EpostaBilgileri.Length; i++)
            {
                string GönderilecekEmailAdresi = EpostaBilgileri[i].ToString();
                string GönderilecekTcNo = TcNoBilgileri[i].ToString();
                string GonderilecekAdSoyad = GidecekAdSoyad[i].ToString();
                string GidecekDosyaYolu = DosyaAdresi[i].ToString();

                System.Net.Mail.MailMessage msj = new System.Net.Mail.MailMessage();
                SmtpClient sc = new SmtpClient();

                try
                {
                    if (!string.IsNullOrEmpty(GönderilecekEmailAdresi))
                    {
                        sc.Credentials = new System.Net.NetworkCredential(GidecekEmailAdresi, GidecekEmailSifresi);
                        msj.To.Add(GönderilecekEmailAdresi);
                        msj.From = new System.Net.Mail.MailAddress(GidecekEmailAdresi, SirketUnvani, Encoding.UTF8);
                        msj.Subject = GidecekEmailKonusu + " Bordrosu";
                        msj.SubjectEncoding = Encoding.UTF8;
                        msj.BodyEncoding = Encoding.UTF8;
                        msj.IsBodyHtml = true;
                        msj.Attachments.Add(new Attachment(GidecekDosyaYolu));
                        msj.Body = "Sayın " + GonderilecekAdSoyad + " " + GidecekEmailKonusu + " Bordronuz Ekte Mevcuttur.";
                        sc.EnableSsl = GidecekEmailSslDurumu;
                        sc.Port = Convert.ToInt32(GidecekPort);
                        sc.Host = GidecekHosting;
                        sc.Send(msj);
                        msj.Dispose();

                        emailAdresKontrolu1.GonderilemeyenEmailAdresleri(GonderilecekAdSoyad, GönderilecekTcNo, GönderilecekEmailAdresi, "Email Gönderimi Başarılı.",DateTime.Now,GidecekDosyaYolu, true);
                    }
                    else
                    {
                        emailAdresKontrolu1.GonderilemeyenEmailAdresleri(GonderilecekAdSoyad, GönderilecekTcNo, GönderilecekEmailAdresi, "E-Mail Adresi Bulunamadı", DateTime.Now, GidecekDosyaYolu, false);
                    }
                }
                catch (Exception ex)
                {
                    string HataMesaji = ex.Message;

                    if (HataMesaji.Length > 3000)
                    {
                        HataMesaji = HataMesaji.ToString().Substring(0, 3000);
                    }

                    emailAdresKontrolu1.GonderilemeyenEmailAdresleri(GonderilecekAdSoyad, GönderilecekTcNo, GönderilecekEmailAdresi, HataMesaji, DateTime.Now, GidecekDosyaYolu, false);
                }
                finally
                {
                    msj.Dispose();
                }
            }

            this.emailDurumuTableAdapter.GonderilenEmailAdresleri(dsBordrolar.EmailDurumu);

            foreach (DataRow dr in dsBordrolar.EmailDurumu.Rows)
            {
                string TcNoKontrol = dr["TcNo"].ToString();
                string DurumKontrol = dr["Durum"].ToString();
                string DosyaKontrol = dr["DosyaYolu"].ToString();

                if (DurumKontrol == "Gönderildi")
                {
                    File.Delete(DosyaKontrol);
                }
            }

            MessageBox.Show("Hatalı Bordrolar Başarılı Şekilde Personellere Gönderilmiştir.");

            btnBordroGonder.Enabled = true;
            btnHataliBordrolar.Enabled = true;
            btnHatasizBordrolar.Enabled = true;
        }

        public static string Coz(string cozVeri)
        {
            byte[] cozByteDizi = System.Convert.FromBase64String(cozVeri);
            string orjinalVeri = System.Text.ASCIIEncoding.ASCII.GetString(cozByteDizi);
            return orjinalVeri;
        }

        private void btnBordroGonder_Click(object sender, EventArgs e)
        {
            btnBordroGonder.Enabled = false;
            btnHataliBordrolar.Enabled = false;
            btnHatasizBordrolar.Enabled = false;

            int EpstDiziSayisi = 0;
            int TcNoDiziSayisi = 0;
            int AdSoyadSayisi = 0;
            int DosyaYoluSayisi = 0;
            TcNoBilgileri = new string[dsBordrolar.EmailDurumu.Rows.Count];
            EpostaBilgileri = new string[dsBordrolar.EmailDurumu.Rows.Count];
            GidecekAdSoyad = new string[dsBordrolar.EmailDurumu.Rows.Count];
            DosyaAdresi = new string[dsBordrolar.EmailDurumu.Rows.Count];

            foreach (DataRow dr in dsBordrolar.EmailDurumu.Rows)
            {
                string DurumKontrol = dr["Durum"].ToString();

                if (DurumKontrol == "Gönderilemedi")
                {
                    TcNoBilgileri[TcNoDiziSayisi] = dr["TcNo"].ToString();
                    EpostaBilgileri[EpstDiziSayisi] = dr["EmailAdres"].ToString();
                    GidecekAdSoyad[AdSoyadSayisi] = dr["AdSoyad"].ToString();
                    DosyaAdresi[DosyaYoluSayisi] = dr["DosyaYolu"].ToString();

                    TcNoDiziSayisi++;
                    EpstDiziSayisi++;
                    AdSoyadSayisi++;
                    DosyaYoluSayisi++;
                }
            }

            MessageBox.Show("Tekrar Bordro Gönderimi İçin Personel E-Mail Adresleri Başarılı Şekilde Ayarlanmıştır.\nŞimdi Gönderim İşlemine Geçiyor.Lütfen Programı Kapatmayınız.");

            Kanal = new Thread(new ThreadStart(EmailGonder));
            Kanal.Priority = ThreadPriority.Highest;
            Kanal.Start();

            btnHataliBordrolar.Enabled = true;
            btnHatasizBordrolar.Enabled = true;

            dsBordrolar.EmailDurumu.Clear();
        }
    }
}
