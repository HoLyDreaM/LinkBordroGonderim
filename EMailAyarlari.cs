using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Bordro_Gonder
{
    public partial class EMailAyarlari : Form
    {
        public EMailAyarlari()
        {
            InitializeComponent();
        }

        AnaForm anafrm;
        public Boolean kontrol = true;
        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath + "\\Email.ini");

        private void EMailAyarlari_Load(object sender, EventArgs e)
        {
            txtSunucu.Text = iniOku.IniOku("Email", "Sunucu");
            txtPort.Text = iniOku.IniOku("Email", "Port");
            txtKullanici.Text = iniOku.IniOku("Email", "Kullanici");
            txtSifre.Text = Coz(iniOku.IniOku("Email", "Pw"));
            sll.Checked = Convert.ToBoolean(iniOku.IniOku("Email", "sll"));
        }

        public static string Coz(string cozVeri)
        {
            byte[] cozByteDizi = System.Convert.FromBase64String(cozVeri);
            string orjinalVeri = System.Text.ASCIIEncoding.ASCII.GetString(cozByteDizi);
            return orjinalVeri;
        }

        public static string Sifrele(string veri)
        {
            byte[] veriByteDizisi = System.Text.ASCIIEncoding.ASCII.GetBytes(veri);
            string sifrelenmisVeri = System.Convert.ToBase64String(veriByteDizisi);
            return sifrelenmisVeri;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            iniOku.IniYaz("Email", "Sunucu", txtSunucu.Text);
            iniOku.IniYaz("Email", "Port", txtPort.Text);
            iniOku.IniYaz("Email", "Kullanici", txtKullanici.Text);
            iniOku.IniYaz("Email", "Sll", sll.Checked.ToString());
            iniOku.IniYaz("Email", "Pw", Sifrele(txtSifre.Text));

            MessageBox.Show("Bilgiler Kaydedildi");
        }

        private void btnSina_Click(object sender, EventArgs e)
        {
            SmtpClient mailGonderici = new SmtpClient(txtSunucu.Text);
            mailGonderici.Credentials = new NetworkCredential(txtKullanici.Text, txtSifre.Text);
            mailGonderici.Port = Convert.ToInt32(txtPort.Text);
            mailGonderici.EnableSsl = sll.Checked;

            MailMessage Mail = new MailMessage(txtKullanici.Text, txtKullanici.Text, "Sınama Maili", "Sınama Maili");
            Mail.Subject = "Sınama Maili";


            try
            {
                mailGonderici.Send(Mail);
                MessageBox.Show("Sınama Başarılı");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } 
        }
    }
}
