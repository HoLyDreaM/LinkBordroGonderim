using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace Bordro_Gonder
{
    public partial class BordroHazirlama : Form
    {
        readonly BackgroundWorker _worker = new BackgroundWorker();

        public BordroHazirlama()
        {
            InitializeComponent();
        }

        public AnaForm anaFrm
        {
            get;
            set;
        }

        Thread Kanal;
        SqlConnection Conn;
        SqlCommand cmd;
        Task BordroAyarla1, BordroAyarla2;

        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath + "\\Email.ini");
        iniOku.iniOku ParametreOku = new iniOku.iniOku(Application.StartupPath + "\\Parametre.ini");

        public string Cs, CsKontrol;
        string AyTarihi, DosyaAdi, SirketUnvani, SirketSskNo, SirketTicaretSicilNo, SirketMersisNo,
            SirketMerkezi, SirketWebAdresi, TersBakiye, KazanclarToplami, personelUcretBilgisi, Bildirim, BankaHesapKodu,
            UcretBildirimi, Logo, BordroTipi;
        bool EmailSec;

        string[] TcNoBilgileri;
        string[] EpostaBilgileri;
        string[] GidecekAdSoyad;
        string[] DosyaAdresi;
        string[] EmailAdresDurumu;
        string[] BolumKoduParcala;

        #region Değişken Tanımları

        string BordroAyi, BordroYili, IslemYili, IslemTarihi, BordroAyYil, BlSicilNo, AdSoyad, CocukAdedi,
               IseGirisTarihi, PersonelUcreti, TcNo, SgkNo, SgkGun, NormalCalismaGun, NormalCalismaSaat, NormalCalismaTutar,
               HaftaTatiliGun, HaftaTatiliSaat, HaftaTatiliTutar, GenelTatilGun, GenelTatilSaat, GenelTatilTutar,
               UcretliIzinGun, UcretliIzinSaat, UcretliIzinTutar, YillikIzinGun, YillikIzinSaat, YillikIzinTutar,
               RaporGun, RaporSaat, RaporTutar, UcretsizIzinGun, UcretsizIzinSaat, UcretsizIzinTutar, ToplamKazancGun,
               ToplamKazancSaat, ToplamKazancTutar, TatilMesaisiGun, TatilMesaisiSaat, TatilMesaisiTutar, FazlaMesaiGun,
               FazlaMesaiSaat, FazlaMesaiTutar, GeceVardiyasiGun, GeceVardiyasiSaat, GeceVardiyasiTutar, UcretliIzinGunSaat,
               UcretliIzinGunSt, UcretliIzinGunTut, EgitimGun, EgitimSaat, EgitimTutar, RaporSaatGun, RaporStSaat, RaporStTutar,
               EkKazancToplamGun, EkKazancToplamSaat, EkKazancToplamTutar, YemekYardimiTutar, FazlaCalismaPrimTutar, IkramiyeTutar,
               YillikIzinYardimiTutari, YakacakYardimTutari, BayramTatilYardimTutari, CocukYardimTutari, TahsilYardimi, KasaYardimi,
               IhbarTazminati, KidemTazminati, AskerlikYardimi, IzinYardimTutari, PostaBasiTazminatTutari, SagSigIsvParayi,
               BenzinYardimi, OdulHediye, HarcirahTutari, DigerYardimTutari, SosyalYardimToplami, SendikaAidati, Avans1, Icra,
               DisiplinCezasi, Avans2, OzelKesintilerToplami, SgkPrimIsciPayi, IssizlikPrimiIsciPayi, GelirVergisiYasalKesinti,
               DamgaVergisiYasalKesinti, YasalKesintilerToplamTutar, sgkMatrahi, sgkPrimiIsveren, IssizlikPrimiIsveren, SgkIsverenTesvigi,
               SgkOdenecekIsveren, DamgaVergisiMatrahi, GelirVergisiMatrahi, GelirVergisiIndirimi, EkIndirim, YillikGelirVergisiMatrahi,
               YillikGelirVergisi, KesintilerToplami, NetOdenen, AsgariGecimIndirimTutari, ToplamOdenen, GeceMesaisiSaat, GeceMesaisiTutar,
               BorcTaksit, DigerKesinti4;

        #endregion

        private void BordroHazirlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBordrolar.BordlariGetir' table. You can move, or remove it, as needed.
            //this.bordlariGetirTableAdapter.Bordrolar(this.dsBordrolar.BordlariGetir);

            Conn = new SqlConnection(Cs);

            int SimdikiTarih = Convert.ToInt32(DateTime.Now.Year);

            int OncekiSeneler = SimdikiTarih - 10;
            int SonrakiSeneler = SimdikiTarih + 10;

            for (int i = OncekiSeneler; i <= SonrakiSeneler; i++)
            {
                cmbBordroYil.Properties.Items.Add(i);
            }

            cmbBordroYil.SelectedItem = SimdikiTarih;

            txtBanka.Text = ParametreOku.IniOku("Parametre", "Banka");

            SirketKodlariniBul();
            cmbSirketKodlari.SelectedIndex = 0;

            prBordrolar.Visible = false;
            btnBordroDurdur.Enabled = false;
        }

        private void btnBordroOlustur_Click(object sender, EventArgs e)
        {
            Kanal = new Thread(new ThreadStart(BordrolarimiziOlusturuyoruz));
            Kanal.Priority = ThreadPriority.Highest;
            Kanal.Start();

            //BordrolarimiziOlusturuyoruz();
        }

        private string BordroOlustur(string FirmaAdi,string FirmaSigortaNo,string FirmaTicaretNo,string FirmaMerkezi,string WebAdresi,
            string BordroYili,string IslemYili,string BlSicilNo,string AdSoyad,string CocukAdedi,
            string IseGirisTarihi,string PersonelUcreti,string personelUcretBilgisi,string TcNo,string SgkNo,string SgkGun,string NormalCalismaGun,string NormalCalismaSaat,string NormalCalismaTutar,
            string HaftaTatiliGun,string HaftaTatiliSaat,string HaftaTatiliTutar,string GenelTatilGun,string GenelTatilSaat,string GenelTatilTutar,
            string UcretliIzinGun,string UcretliIzinSaat,string UcretliIzinTutar,string YillIzinGun,string YillikIzinSaat,string YillikIzinTutar,
            string RaporGun,string RaporSaat,string RaporTutar,string UcretsizIzinGun,string UcretsizIzinSaat,string UcretsizIzinTutar,string ToplamKazancGun,
            string ToplamKazancSaat,string ToplamKazancTutar,string TatilMesaisiGun,string TatilMesaisiSaat,string TatilMesaisiTutar,string FazlaMesaiGun,
            string FazlaMesaiSaat,string FazlaMesaiTutar,string GeceVardiyasiGun,string GeceVardiyasiSaat,string GeceVardiyasiTutar,string UcretliIzinGunSaat,
            string UcretliIzinGunSt,string UcretliIzinGunTut,string EgitimGun,string EgitimSaat,string EgitimTutar,string RaporSaatGun,string RaporStSaat,string RaporStTutar,
            string EkKazancToplamGun,string EkKazancToplamSaat,string EkKazancToplamTutar,string YemekYardimiTutar,string FazlaCalismaPrimTutar,string IkramiyeTutar,
            string YillikIzinYardimiTutari,string YakacakYardimTutari,string BayramTatilYardimTutari,string CocukYardimTutari,string TahsilYardimi,string KasaYardimi,
            string IhbarTazminati,string KidemTazminati,string AskerlikYardimi,string IzinYardimTutari,string PostaBasiTazminatTutari,string SagSigIsvParayi,
            string BenzinYardimi,string OdulHediye,string HarcirahTutari,string DigerYardimTutari,string SosyalYardimToplami,string SendikaAidati,string Avans1,string Icra,
            string DisiplinCezasi,string Avans2,string OzelKesintilerToplami,string SgkPrimIsciPayi,string IssizlikPrimiIsciPayi,string GelirVergisiYasalKesinti,
            string DamgaVergisiYasalKesinti,string YasalKesintilerToplamTutar,string sgkMatrahi,string sgkPrimiIsveren,string IssizlikPrimiIsveren,string SgkIsverenTesvigi,
            string SgkOdenecekIsveren,string DamgaVergisiMatrahi,string GelirVergisiMatrahi,string GelirVergisiIndirimi,string EkIndirim,string YillikGelirVergisiMatrahi,
            string YillikGelirVergisi,string KesintilerToplami,string NetOdenen,string AsgariGecimIndirimTutari,string ToplamOdenen,string KazanclarToplami,string GeceMesaisi,
            string GeceMesaisiNet, string GeceMesaisiTutar, string MersisNo, string BildirimParametre,string LogoParametre,string BorcTaksitTutari,string DigerKesinti4)
        {
            string tablo = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">  " + Environment.NewLine +
            "<html xmlns=\"http://www.w3.org/1999/xhtml\"> " + Environment.NewLine +
            "<head> " + Environment.NewLine +
            "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" /> " + Environment.NewLine +
            "</head> " + Environment.NewLine +
            Environment.NewLine +
            "<body> " + Environment.NewLine +
            "<table cellspacing=\"0\" cellpadding=\"0\" width=\"100%\">  " + Environment.NewLine +
" <tr>" + Environment.NewLine +
  " <td colspan=\"3\" rowspan=\"4\" valign=\"middle\" align=\"center\" width=\"100\" height=\"41\" ><center><img src=\" " + LogoParametre + "\" width=\"100\" height=\"41\" /></center></td>" + Environment.NewLine +
  " <td colspan=\"4\" align=\"center\" >" + SirketUnvani + "</td>" + Environment.NewLine +
  " <td colspan=\"2\" align=\"center\" >" + SirketSskNo + "</td>" + Environment.NewLine +
  " </tr> " + Environment.NewLine +
              Environment.NewLine +
              Environment.NewLine +
 " <tr> " + Environment.NewLine +
" <td colspan=\"4\" rowspan=\"3\" align=\"center\" width=\"100\" ><b>ÜCRET BORDROSU</b><br />" + Environment.NewLine +
                  " <b>" + BordroAyYil + " </b><br /> " + Environment.NewLine +
                " " + IslemTarihi + "</td>" + Environment.NewLine +
" <td height=\"25\" valign=\"middle\" align=\"center\" >BL./SİCİL</td>" + Environment.NewLine +
" <td>" + BlSicilNo + "</td>" + Environment.NewLine +
" </tr>" + Environment.NewLine +
" <tr>" + Environment.NewLine +
" <td height=\"25\" align=\"center\" >AD SOYAD</td>" + Environment.NewLine +
" <td>" + AdSoyad + "</td>" + Environment.NewLine +
" </tr>" + Environment.NewLine +
" <tr>" + Environment.NewLine +
    " <td height=\"25\" >İŞE GİRİŞ TARİHİ</td>" + Environment.NewLine +
" <td>" + IseGirisTarihi + "</td>" + Environment.NewLine +
" </tr>" + Environment.NewLine +
" <tr>" + Environment.NewLine +
" <td valign=\"middle\" >Brüt " + personelUcretBilgisi + " Ücreti</td>" + Environment.NewLine +
" <td colspan=\"2\" >" + PersonelUcreti + " TL</td>" + Environment.NewLine +
" <td align=\"center\" >Para Birimi</td>" + Environment.NewLine +
" <td colspan=\"2\" align=\"center\" >Çocuk Sayısı</td>" + Environment.NewLine +
" <td align=\"center\" >SGK Gün</td>" + Environment.NewLine +
" <td align=\"center\" >T.C.KİMLİK NO</td>" + Environment.NewLine +
" <td>" + TcNo + "</td>" + Environment.NewLine +
" </tr>" + Environment.NewLine +
" <tr>" + Environment.NewLine +
    "<td colspan=\"3\" ><b>Mersis No : </b>" + SirketMersisNo + "</td> " + Environment.NewLine +
    "<td align=\"center\" ><b>TL</b></td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" ><b>" + CocukAdedi + "</b></td> " + Environment.NewLine +
    "<td align=\"center\" ><b>" + SgkGun + "</b></td> " + Environment.NewLine +
    "<td >SGK NO</td> " + Environment.NewLine +
    "<td >" + SgkNo + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td ><b>Ticaret Sicil No</b></td> " + Environment.NewLine +
    "<td colspan=\"2\" valign=\"middle\" >" + SirketTicaretSicilNo + "</td> " + Environment.NewLine +
    "<td valign=\"middle\" ><b>İşletme Merkezi</b></td> " + Environment.NewLine +
    "<td colspan=\"3\" >" + SirketMerkezi + "</td> " + Environment.NewLine +
    "<td ><b>Web Adresi</b></td> " + Environment.NewLine +
    "<td >" + SirketWebAdresi + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td ><b>KAZANÇLAR</b></td> " + Environment.NewLine +
    "<td width=\"84\" align=\"center\" ><b>GÜN</b></td> " + Environment.NewLine +
    "<td width=\"88\" align=\"center\" ><b>SAAT</b></td> " + Environment.NewLine +
    "<td align=\"center\" ><b>TUTAR</b></td> " + Environment.NewLine +
    "<td colspan=\"4\" align=\"left\" ><b>ÖZEL KESİNTİLER</b></td> " + Environment.NewLine +
    "<td align=\"right\" ><b>TUTAR</b></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >Normal Çalışma</td> " + Environment.NewLine +
    "<td align=\"center\" >" + NormalCalismaGun + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + NormalCalismaSaat + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + NormalCalismaTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Sendika Aidatı</td> " + Environment.NewLine +
    "<td align=\"right\" >" + SendikaAidati + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >Hafta Tatili</td> " + Environment.NewLine +
    "<td align=\"center\" >" + HaftaTatiliGun + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + HaftaTatiliSaat + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + HaftaTatiliTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Avans 1</td> " + Environment.NewLine +
    "<td align=\"right\" >" + Avans2 + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >Genel Tatil</td> " + Environment.NewLine +
    "<td align=\"center\" >" + GenelTatilGun + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + GenelTatilSaat + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + GenelTatilTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >icra</td> " + Environment.NewLine +
    "<td align=\"right\" >" + Icra + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >Ücretli İzin</td> " + Environment.NewLine +
    "<td align=\"center\" >" + UcretliIzinGun + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + UcretliIzinSaat + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + UcretliIzinTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Disiplin Cezası</td> " + Environment.NewLine +
    "<td align=\"right\" >" + DisiplinCezasi + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >Yıllık İzin</td> " + Environment.NewLine +
    "<td align=\"center\" >" + YillikIzinGun + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + YillikIzinSaat + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + YillikIzinTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Avans 2</td> " + Environment.NewLine +//
    "<td align=\"right\" >" + Avans1 + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >Hasta</td> " + Environment.NewLine +
    "<td align=\"center\" >" + RaporGun + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + RaporSaat + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + RaporTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Borç</td> " + Environment.NewLine +
    "<td align=\"right\" >" + BorcTaksitTutari + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >Devamsızlık</td> " + Environment.NewLine +
    "<td align=\"center\" >" + UcretsizIzinGun + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + UcretsizIzinSaat + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + UcretsizIzinTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Dayanışma Aidatı</td> " + Environment.NewLine +
    "<td align=\"right\" >" + DigerKesinti4 + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >&nbsp;</td> " + Environment.NewLine +
    "<td >&nbsp;</td> " + Environment.NewLine +
    "<td >&nbsp;</td> " + Environment.NewLine +
    "<td >&nbsp;</td> " + Environment.NewLine +
    "<td colspan=\"4\" >&nbsp;</td> " + Environment.NewLine +
    "<td align=\"right\" >&nbsp;</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td align=\"left\" ><b>TOPLAM</b></td> " + Environment.NewLine +
    "<td align=\"center\" ><b>" + ToplamKazancGun + "</b></td> " + Environment.NewLine +
    "<td align=\"center\" ><b>" + ToplamKazancSaat + "</b></td> " + Environment.NewLine +
    "<td align=\"center\" ><b>" + ToplamKazancTutar + " TL</b></td> " + Environment.NewLine +
    "<td colspan=\"4\" ><b>TOPLAM</b></td> " + Environment.NewLine +
    "<td align=\"right\" ><b>" + OzelKesintilerToplami + "</b></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td ><b>EK KAZANÇLAR</b></td> " + Environment.NewLine +
    "<td align=\"center\" ><b>GÜN</b></td> " + Environment.NewLine +
    "<td align=\"center\" valign=\"middle\" ><b>SAAT</b></td> " + Environment.NewLine +
    "<td align=\"center\" valign=\"middle\" ><b>TUTAR</b></td> " + Environment.NewLine +
    "<td colspan=\"4\" > <b>YASAL KESİNTİLER</b></td> " + Environment.NewLine +
    "<td align=\"right\" ><b>TUTAR</b></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >Tatil Mesai</td> " + Environment.NewLine +
    "<td align=\"center\" >" + TatilMesaisiGun + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + TatilMesaisiSaat + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + TatilMesaisiTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >SGK Primi (İşçi Payı)</td> " + Environment.NewLine +
    "<td align=\"right\" >" + SgkPrimIsciPayi + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >Fazla Mesai</td> " + Environment.NewLine +
    "<td align=\"center\" >" + FazlaMesaiGun + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + FazlaMesaiSaat + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + FazlaMesaiTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >İşsizlik Primi (İşçi Payı)</td> " + Environment.NewLine +
    "<td align=\"right\" >" + IssizlikPrimiIsciPayi + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >Gece Vardiyası</td> " + Environment.NewLine +
    "<td align=\"center\" >" + GeceVardiyasiGun + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + GeceVardiyasiSaat + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + GeceVardiyasiTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Gelir Vergisi</td> " + Environment.NewLine +
    "<td align=\"right\" >" + GelirVergisiYasalKesinti + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
  "<td >Diğer Kazanç 1</td> " + Environment.NewLine +
  "<td align=\"center\" >" + UcretliIzinGunSaat + "</td> " + Environment.NewLine +
  "<td align=\"center\" >" + UcretliIzinGunSt + "</td> " + Environment.NewLine +
  "<td align=\"center\" >" + UcretliIzinGunTut + "</td> " + Environment.NewLine +
  "<td colspan=\"4\" >Damga Vergisi</td> " + Environment.NewLine +
  "<td align=\"right\" >" + DamgaVergisiYasalKesinti + "</td> " + Environment.NewLine +
"</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >Diğer Kazanç  2</td> " + Environment.NewLine +
    "<td align=\"center\" >" + EgitimGun + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + EgitimSaat + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + EgitimTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" ></td> " + Environment.NewLine +
    "<td align=\"right\" ></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td >Diğer Kazanç  3</td> " + Environment.NewLine +
    "<td align=\"center\" >" + RaporSaatGun + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + RaporStSaat + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + RaporStTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >&nbsp;</td> " + Environment.NewLine +
    "<td align=\"right\" >&nbsp;</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
    "<tr> " + Environment.NewLine +
    "<td >Gece Mesaisi</td> " + Environment.NewLine +
    "<td align=\"center\" >0</td> " + Environment.NewLine +
    "<td align=\"center\" >" + GeceMesaisiNet + "</td> " + Environment.NewLine +
    "<td align=\"center\" >" + GeceMesaisiTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" ></td> " + Environment.NewLine +
    "<td align=\"right\" ></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td ><b>TOPLAM</b></td> " + Environment.NewLine +
    "<td align=\"center\" ><b>" + EkKazancToplamGun + "</b></td> " + Environment.NewLine +
    "<td align=\"center\" ><b>" + EkKazancToplamSaat + "</b></td> " + Environment.NewLine +
    "<td align=\"center\" ><b>" + EkKazancToplamTutar + "</b></td> " + Environment.NewLine +
    "<td colspan=\"4\" ><b>TOPLAM</b></td> " + Environment.NewLine +
    "<td align=\"right\" ><b>" + YasalKesintilerToplamTutar + "</b></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" ><b>SOSYAL YARDIMLAR</b></td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" ><b>TUTAR</b></td> " + Environment.NewLine +
    "<td colspan=\"4\" ><b>YASAL KESİNTİ MATRAHLARI</b></td> " + Environment.NewLine +
    "<td align=\"right\" ><b>TUTAR</b></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Yemek Yardımı</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + YemekYardimiTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >SGK Matrahı</td> " + Environment.NewLine +
    "<td align=\"right\" >" + sgkMatrahi + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Prim</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + FazlaCalismaPrimTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Damga Vergisi Matrahı</td> " + Environment.NewLine +//
    "<td align=\"right\" >" + DamgaVergisiMatrahi + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >İkramiye</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + IkramiyeTutar + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Gelir Vergisi Matrahı</td> " + Environment.NewLine +//
    "<td align=\"right\" >" + GelirVergisiMatrahi + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Yıllık İzin</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + YillikIzinYardimiTutari + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Gelir Vergisi İndirimi</td> " + Environment.NewLine +
    "<td align=\"right\" >" + GelirVergisiIndirimi + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Yakacak Yardımı</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + YakacakYardimTutari + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Ek İndirim</td> " + Environment.NewLine +//
    "<td align=\"right\" >" + EkIndirim + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Bayram Yardımı</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + BayramTatilYardimTutari + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Yıllık Gelir Vergisi Matrahı</td> " + Environment.NewLine +
    "<td align=\"right\" >" + YillikGelirVergisiMatrahi + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Çocuk Yardımı</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + CocukYardimTutari + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >Yıllık Gelir Vergisi</td> " + Environment.NewLine +
    "<td align=\"right\" >" + YillikGelirVergisi + "</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Tahsil Yardımı</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + TahsilYardimi + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" ></td> " + Environment.NewLine +
    "<td align=\"right\" ></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >2015-2017 Dönemi istisnai Ödemesi</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + KasaYardimi + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" ></td> " + Environment.NewLine +
    "<td align=\"right\" ></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >İhbar Tazminatı</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + IhbarTazminati + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" ></td> " + Environment.NewLine +
    "<td align=\"right\" ></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Kıdem Tazminatı</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + KidemTazminati + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" ></td> " + Environment.NewLine +
    "<td align=\"right\" ></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Askerlik Yardımı</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + AskerlikYardimi + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >&nbsp;</td> " + Environment.NewLine +
    "<td >&nbsp;</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >İzin Yardımı</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + IzinYardimTutari + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >&nbsp;</td> " + Environment.NewLine +
    "<td >&nbsp;</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Postabaşı Tazminatı</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + PostaBasiTazminatTutari + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >&nbsp;</td> " + Environment.NewLine +
    "<td >&nbsp;</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Sağ.Sig.İşv.Payı</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + SagSigIsvParayi + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >&nbsp;</td> " + Environment.NewLine +
    "<td >&nbsp;</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Benzin Yardımı</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + BenzinYardimi + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >&nbsp;</td> " + Environment.NewLine +
    "<td >&nbsp;</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Ödül - Hediye</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + OdulHediye + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >&nbsp;</td> " + Environment.NewLine +
    "<td >&nbsp;</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Harcırah</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + HarcirahTutari + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >&nbsp;</td> " + Environment.NewLine +

    "<td >&nbsp;</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" >Diğer Yardım</td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" >" + DigerYardimTutari + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" >&nbsp;</td> " + Environment.NewLine +
    "<td >&nbsp;</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" ><b>TOPLAM</b></td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" ><b>" + SosyalYardimToplami + "</b></td> " + Environment.NewLine +
    "<td colspan=\"4\" >&nbsp;</td> " + Environment.NewLine +
    "<td >&nbsp;</td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"2\" ><b>KAZANÇLAR TOPLAMI</b></td> " + Environment.NewLine +
    "<td colspan=\"2\" align=\"center\" ><b>" + KazanclarToplami + "</b></td> " + Environment.NewLine +
    "<td colspan=\"4\" ><b>KESİNTİLER TOPLAMI</b></td> " + Environment.NewLine +
    "<td align=\"right\" ><b>" + KesintilerToplami + "</b></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"4\" rowspan=\"3\" >" + BildirimParametre + "</td> " + Environment.NewLine +
    "<td colspan=\"4\" ><b>NET ÖDENEN</b></td> " + Environment.NewLine +
    "<td align=\"right\" ><b>" + NetOdenen + "</b></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"4\" ><b>ASGARİ GEÇİM İNDİRİM TUTARI</b></td> " + Environment.NewLine +
    "<td align=\"right\" ><b>" + AsgariGecimIndirimTutari + "</b></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
  "<tr> " + Environment.NewLine +
    "<td colspan=\"4\" ><b>TOPLAM ÖDENEN</b></td> " + Environment.NewLine +
    "<td align=\"right\" ><b>" + ToplamOdenen + "</b></td> " + Environment.NewLine +
  "</tr> " + Environment.NewLine +
"</table> " + Environment.NewLine +
"</body> " +
 Environment.NewLine +
"</html>";
            string tablomuz = tablo;
            return (string)tablomuz;
        }

        private void btnBordroGetir_Click(object sender, EventArgs e)
        {
            btnBordroOlustur.Enabled = false;
            btnEmailAyarla.Enabled = false;
            btnBordroGetir.Enabled = false;
            btnBordrolariGonder.Enabled = false;
            btnHepsiniSec.Enabled = false;
            btnHepsiniKaldir.Enabled = false;

            string BordroAyimiz = AylarinTarihi(cmbBordroAy.Text.ToString());
            string BordroYilimiz = cmbBordroYil.Text;
            string BordroNo = txtBordroNo.Text;
            string SirketKodumuz = cmbSirketKodlari.Text.ToString();
            BordroTipi = cmbBordroTipi.Text.ToString();

            if (BordroTipi == "Normal")
            {
                BordroTipi = "1";
            }
            else
            {
                BordroTipi = "2";
            }

            grdBordro.DataSource = null;

            if (!string.IsNullOrEmpty(txtBordroNo.Text))
            {
                this.bordlariGetirTableAdapter.BordroTarihleri1(dsBordrolar.BordlariGetir, Convert.ToInt32(BordroAyimiz),
                    SirketKodumuz, Convert.ToInt32(BordroYilimiz), Convert.ToInt32(BordroNo), Convert.ToInt32(BordroTipi));
            }
            else
            {
                this.bordlariGetirTableAdapter.BordroTarihleri2(dsBordrolar.BordlariGetir, Convert.ToInt32(BordroAyimiz),
                    SirketKodumuz, Convert.ToInt32(BordroYilimiz), Convert.ToInt32(BordroTipi));
            }

            string BordroSayimiz = Convert.ToString(dsBordrolar.BordlariGetir.Rows.Count);
            
            grdBordro.DataSource = dsBordrolar.BordlariGetir;

            MessageBox.Show("Toplam " + BordroSayimiz + " Adet Bordro Bulundu");

            btnBordroOlustur.Enabled = true;
            btnEmailAyarla.Enabled = true;
            btnBordroGetir.Enabled = true;
            btnBordrolariGonder.Enabled = true;
            btnHepsiniSec.Enabled = true;
            btnHepsiniKaldir.Enabled = true;

            foreach (DataRow dr in dsBordrolar.BordlariGetir.Rows)
            {
                string GeceMesaisiKontrol = dr["GeceMesaisiNet"].ToString();
                string GeceMesaisiTutarKontrol = dr["GeceMesaisiTutar"].ToString();

                if (string.IsNullOrEmpty(GeceMesaisiKontrol))
                {
                    dr["GeceMesaisiNet"] = "0";
                }
                if (string.IsNullOrEmpty(GeceMesaisiTutarKontrol))
                {
                    dr["GeceMesaisiTutar"] = "0";
                }
            }

            for (int i = 0; i < dsBordrolar.BordlariGetir.Rows.Count; i++)
            {
                gridView1.SetRowCellValue(i, "Sec", "True");
            }
        }

        private string AylarinTarihi(string Ay)
        {
            switch (Ay)
            {
                case "Ocak": AyTarihi = "1"; break;
                case "Şubat": AyTarihi = "2"; break;
                case "Mart": AyTarihi = "3"; break;
                case "Nisan": AyTarihi = "4"; break;
                case "Mayıs": AyTarihi = "5"; break;
                case "Haziran": AyTarihi = "6"; break;
                case "Temmuz": AyTarihi = "7"; break;
                case "Ağustos": AyTarihi = "8"; break;
                case "Eylül": AyTarihi = "9"; break;
                case "Ekim": AyTarihi = "10"; break;
                case "Kasım": AyTarihi = "11"; break;
                case "Aralık": AyTarihi = "12"; break;
            }
            string Yeniislem = AyTarihi;
            return Yeniislem;
        }

        private string YaziAylarimiz(string Ay)
        {
            switch (Ay)
            {
                case "1": AyTarihi = "Ocak"; break;
                case "2": AyTarihi = "Şubat"; break;
                case "3": AyTarihi = "Mart"; break;
                case "4": AyTarihi = "Nisan"; break;
                case "5": AyTarihi = "Mayıs"; break;
                case "6": AyTarihi = "Haziran"; break;
                case "7": AyTarihi = "Temmuz"; break;
                case "8": AyTarihi = "Ağustos"; break;
                case "9": AyTarihi = "Eylül"; break;
                case "10": AyTarihi = "Ekim"; break;
                case "11": AyTarihi = "Kasım"; break;
                case "12": AyTarihi = "Aralık"; break;
            }
            string Yeniislem = AyTarihi;
            return Yeniislem;
        }

        private void FirmaBilgileri(string IsyeriKodu)
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sorgu = "SELECT PER004_IsyeriKodu AS IsyeriKodu,PER004_Unvan1+' ' +PER004_Unvan2 AS Unvan,PER004_IsyerininSskNumarasi AS SskNo, " +
                        "PER004_TicaretSicilNo AS TicaretSicilNo,PER004_Ilce+'/'+PER004_Il AS IsletmeMerkezi, " +
                        "PER004_WebAdres AS WebAdresi,PER004_MersisNo AS MersisNo " +
                        "FROM PER004 WHERE  PER004_IsyeriKodu=" + IsyeriKodu;

            cmd = new SqlCommand(sorgu, Conn);

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (dr.Read())
            {
                SirketUnvani = dr["Unvan"].ToString();
                SirketSskNo = dr["SskNo"].ToString();

                string a = SirketSskNo.Substring(0, 1);
                string b = SirketSskNo.Substring(1, 4);
                string c = SirketSskNo.Substring(5, 2);
                string d = SirketSskNo.Substring(7, 7);
                string e = SirketSskNo.Substring(14, 3);
                string f = SirketSskNo.Substring(17, 2);
                string g = SirketSskNo.Substring(19, 2);
                string h = SirketSskNo.Substring(21, 1);

                SirketSskNo = a + "-" + b + "-" + c + g + d + "-" + e + "-" + f + "-" + h;

                SirketTicaretSicilNo = dr["TicaretSicilNo"].ToString();
                SirketMerkezi = dr["IsletmeMerkezi"].ToString();
                SirketWebAdresi = dr["WebAdresi"].ToString();
                SirketMersisNo = dr["MersisNo"].ToString();
            }

            dr.Dispose();
            dr.Close();
        }

        private string PersonelUcretDurumu(string PersonelAdi)
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sorgu = "SELECT (CASE PER002_UcretNevi " +
                         "WHEN 1 THEN 'SAAT' " +
                         "WHEN 2 THEN 'GÜNLÜK' " +
                         "WHEN 3 THEN 'AYLIK' END) AS Ucret FROM PER002 " +
                         "WHERE PER002_Adi+' ' +PER002_Soyadi='" + PersonelAdi + "'";

            cmd = new SqlCommand(sorgu, Conn);

            return (string)cmd.ExecuteScalar();
        }

        private void btnBordrolariGonder_Click(object sender, EventArgs e)
        {
            Kanal = new Thread(new ThreadStart(EmailGonder));
            Kanal.Priority = ThreadPriority.Highest;
            Kanal.Start();
        }

        public static string Coz(string cozVeri)
        {
            byte[] cozByteDizi = System.Convert.FromBase64String(cozVeri);
            string orjinalVeri = System.Text.ASCIIEncoding.ASCII.GetString(cozByteDizi);
            return orjinalVeri;
        }

        private void btnEmailAyarla_Click(object sender, EventArgs e)
        {
            btnBordroOlustur.Enabled = false;
            btnEmailAyarla.Enabled = false;
            btnBordroGetir.Enabled = false;
            btnBordrolariGonder.Enabled = false;
            btnHepsiniSec.Enabled = false;
            btnHepsiniKaldir.Enabled = false;

            int EpstDiziSayisi = 0;
            int TcNoDiziSayisi = 0;
            int AdSoyadSayisi = 0;
            int EMailDurumSayisi = 0;
            TcNoBilgileri = new string[dsBordrolar.BordlariGetir.Rows.Count];
            EpostaBilgileri = new string[dsBordrolar.BordlariGetir.Rows.Count];
            GidecekAdSoyad = new string[dsBordrolar.BordlariGetir.Rows.Count];
            EmailAdresDurumu = new string[dsBordrolar.BordlariGetir.Rows.Count];

            for (int i = 0; i < dsBordrolar.BordlariGetir.Rows.Count; i++)
            {
                DataRow row = dsBordrolar.BordlariGetir.Rows[i];
                EmailSec = Convert.ToBoolean(row["Sec"].ToString());

                if (EmailSec == true)
                {
                    TcNoBilgileri[TcNoDiziSayisi] = row["TcNo"].ToString();
                    EpostaBilgileri[EpstDiziSayisi] = row["Email"].ToString();
                    GidecekAdSoyad[AdSoyadSayisi] = row["AdSoyad"].ToString();
                    EmailAdresDurumu[EMailDurumSayisi] = Convert.ToString(row["Sec"].ToString());

                    TcNoDiziSayisi++;
                    EpstDiziSayisi++;
                    AdSoyadSayisi++;
                    EMailDurumSayisi++;
                }
                else
                {
                    TcNoBilgileri[TcNoDiziSayisi] = row["TcNo"].ToString();
                    EpostaBilgileri[EpstDiziSayisi] = row["Email"].ToString();
                    GidecekAdSoyad[AdSoyadSayisi] = row["AdSoyad"].ToString();
                    EmailAdresDurumu[EMailDurumSayisi] = "False";

                    TcNoDiziSayisi++;
                    EpstDiziSayisi++;
                    AdSoyadSayisi++;
                    EMailDurumSayisi++;
                }

            }

            MessageBox.Show("Bordro Gönderimi İçin Personel E-Mail Adresleri Başarılı Şekilde Ayarlanmıştır.");

            btnBordroOlustur.Enabled = true;
            btnEmailAyarla.Enabled = true;
            btnBordroGetir.Enabled = true;
            btnBordrolariGonder.Enabled = true;
            btnHepsiniSec.Enabled = true;
            btnHepsiniKaldir.Enabled = true;
        }

        private void EmailGonder()
        {
            CheckForIllegalCrossThreadCalls = false;

            btnBordroGetir.Enabled = false;
            btnBordrolariGonder.Enabled = false;
            btnBordroOlustur.Enabled = false;
            btnEmailAyarla.Enabled = false;
            btnHepsiniSec.Enabled = false;
            btnHepsiniKaldir.Enabled = false;

            FirmaBilgileri(cmbSirketKodlari.Text);

            string GidecekEmailAdresi = iniOku.IniOku("Email", "Kullanici");
            string GidecekEmailSifresi = Coz(iniOku.IniOku("Email", "Pw"));
            string GidecekPort = iniOku.IniOku("Email", "Port");
            string GidecekHosting = iniOku.IniOku("Email", "Sunucu");
            string GidecekEmailKonusu = cmbBordroAy.Text + " " + cmbBordroYil.Text;
            bool GidecekEmailSslDurumu = Convert.ToBoolean(iniOku.IniOku("Email", "Sll"));

            prBordrolar.Visible = true;
            prBordrolar.Properties.Minimum = 1;
            prBordrolar.Properties.Maximum = 0;
            prBordrolar.Properties.Maximum = dsBordrolar.BordlariGetir.Rows.Count;
            prBordrolar.Properties.Step = 1;
            int prograscontrol = 1;

            for (int i = 0; i < EpostaBilgileri.Length; i++)
            {
                string GönderilecekEmailAdresi = EpostaBilgileri[i].ToString();
                string GönderilecekTcNo = TcNoBilgileri[i].ToString();
                string GonderilecekAdSoyad = GidecekAdSoyad[i].ToString();
                string GidecekDosyaYolu = DosyaAdresi[i].ToString();
                string GidecekEmailAdresDurumu = EmailAdresDurumu[i].ToString();

                System.Net.Mail.MailMessage msj = new System.Net.Mail.MailMessage();
                SmtpClient sc = new SmtpClient();

                try
                {
                    if (GidecekEmailAdresDurumu == "True")
                    {
                        if (!string.IsNullOrEmpty(GönderilecekEmailAdresi))
                        {
                            //Thread.Sleep(60000);
                            Thread.Sleep(300);

                            ContentType contentType = new ContentType();
                            contentType.CharSet = Encoding.UTF8.WebName;

                            Attachment inline = new Attachment(GidecekDosyaYolu, MediaTypeNames.Application.Pdf);
                            inline.ContentDisposition.Inline = true;
                            inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
                            inline.ContentType.MediaType = MediaTypeNames.Application.Pdf;
                            inline.ContentType.Name = Path.GetFileName(GidecekDosyaYolu);

                            MemoryStream memoryStream=new MemoryStream();

                            byte[] contentAsBytes = Encoding.UTF8.GetBytes(GidecekDosyaYolu);
                            memoryStream.Write(contentAsBytes, 0, contentAsBytes.Length);

    // Set the position to the beginning of the stream.
                            memoryStream.Seek(0, SeekOrigin.Begin);

    // Create attachment
                            ContentType contentType1 = new ContentType();
                            contentType1.MediaType = MediaTypeNames.Application.Octet;
                            contentType1.Name = GidecekDosyaYolu;
                            Attachment attachment = new Attachment(memoryStream, contentType);

                            //Thread.Sleep(300);
                            sc.Credentials = new System.Net.NetworkCredential(GidecekEmailAdresi, GidecekEmailSifresi);
                            msj.To.Add(GönderilecekEmailAdresi);
                            msj.From = new System.Net.Mail.MailAddress(GidecekEmailAdresi, SirketUnvani, Encoding.UTF8);
                            msj.Subject = GidecekEmailKonusu + " Bordrosu";
                            msj.SubjectEncoding = Encoding.UTF8;
                            msj.BodyEncoding = Encoding.UTF8;
                            msj.IsBodyHtml = true;
                            msj.Attachments.Add(inline);
                            msj.Body = "Sayın " + GonderilecekAdSoyad + " " + GidecekEmailKonusu + " Bordronuz Ekte Mevcuttur.";
                            sc.EnableSsl = GidecekEmailSslDurumu;
                            sc.Port = Convert.ToInt32(GidecekPort);
                            sc.Host = GidecekHosting;
                            sc.Send(msj);
                            msj.Dispose();

                            emailAdresKontrolu1.GonderilemeyenEmailAdresleri(GonderilecekAdSoyad, GönderilecekTcNo, GönderilecekEmailAdresi, "Email Gönderimi Başarılı.", DateTime.Now, GidecekDosyaYolu, true);
                        }
                        else
                        {
                            emailAdresKontrolu1.GonderilemeyenEmailAdresleri(GonderilecekAdSoyad, GönderilecekTcNo, GönderilecekEmailAdresi, "E-Mail Adresi Bulunamadı", DateTime.Now, GidecekDosyaYolu, false);
                        }
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

                    prograscontrol++;
                    prBordrolar.PerformStep();

                    //gridView1.SetRowCellValue(i, "Sec", "False");
                    dsBordrolar.BordlariGetir.Rows[i]["Sec"] = "False";
                }
            }

            prBordrolar.Properties.Minimum = 1;
            prBordrolar.Visible = false;

            this.emailDurumuTableAdapter1.GonderilenEmailAdresleri(dsBordrolar.EmailDurumu);

            MessageBox.Show("Bordrolar Başarılı Şekilde Personellere Gönderilmiştir.");

            btnBordroGetir.Enabled = true;
            btnBordrolariGonder.Enabled = true;
            btnBordroOlustur.Enabled = true;
            btnEmailAyarla.Enabled = true;
            btnHepsiniSec.Enabled = true;
            btnHepsiniKaldir.Enabled = true;
        }

        private void BordrolarimiziOlusturuyoruz()
        {
            CheckForIllegalCrossThreadCalls = false;

            btnBordroOlustur.Enabled = false;
            btnEmailAyarla.Enabled = false;
            btnBordroGetir.Enabled = false;
            btnBordrolariGonder.Enabled = false;
            btnHepsiniSec.Enabled = false;
            btnHepsiniKaldir.Enabled = false;
            btnBordroDurdur.Enabled = true;

            FirmaBilgileri(cmbSirketKodlari.Text);
            string ArsivBordroTipi = cmbBordroTipi.Text.ToString();

            int DosyaYoluSayisi = 0;
            DosyaAdresi = new string[dsBordrolar.BordlariGetir.Rows.Count];

            prBordrolar.Visible = true;
            prBordrolar.Properties.Minimum = 1;
            prBordrolar.Properties.Maximum = 0;
            prBordrolar.Properties.Maximum = dsBordrolar.BordlariGetir.Rows.Count;
            prBordrolar.Properties.Step = 1;
            int prograscontrol = 1;

            foreach (DataRow dr in dsBordrolar.BordlariGetir.Rows)
            {
                Thread.Sleep(300);

                BordroAyYil = cmbBordroAy.Text + "-" + cmbBordroYil.Text;
                IslemTarihi = Convert.ToString(DateTime.Now.ToString());

                BlSicilNo = dr["BlSicil"].ToString();
                AdSoyad = dr["AdSoyad"].ToString();
                personelUcretBilgisi = PersonelUcretDurumu(AdSoyad);

                BolumKoduParcala = BlSicilNo.Split('/');
                DosyaAdi = BolumKoduParcala[1];

                CocukAdedi = dr["CocukAdedi"].ToString();
                SgkGun = dr["SgkGun"].ToString();
                IseGirisTarihi = dr["GirisTarihi"].ToString();
                PersonelUcreti = Convert.ToString(Math.Round(Convert.ToDecimal(dr["Ucret"].ToString()), 2));
                TcNo = dr["TcNo"].ToString();

                SgkNo = dr["SGKNo"].ToString();
                NormalCalismaGun = dr["NormalCalisma"].ToString();
                NormalCalismaSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["NormalCalismaSaat"].ToString()), 2));
                NormalCalismaTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["NormalCalismaTutar"].ToString()), 2));
                HaftaTatiliGun = dr["HaftaTatili"].ToString();
                HaftaTatiliSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["HaftaTatiliSaat"].ToString()), 2));
                HaftaTatiliTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["HaftaTatiliTutar"].ToString()), 2));
                GenelTatilGun = dr["GenelTatil"].ToString();
                GenelTatilSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["GenelTatilSaat"].ToString()), 2));
                GenelTatilTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["GenelTatilTutar"].ToString()), 2));
                UcretliIzinGun = dr["UcretliIzin"].ToString();
                UcretliIzinSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["UcretliIzinSaat"].ToString()), 2));
                UcretliIzinTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["UcretliIzinTutar"].ToString()), 2));
                YillikIzinGun = dr["YillikIzinGun"].ToString();
                YillikIzinSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["YillikIzinSaat"].ToString()), 2));
                YillikIzinTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["YillikIzinTutari"].ToString()), 2));
                RaporGun = dr["RaporsGun"].ToString();
                RaporSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["RaporsSaat"].ToString()), 2));
                RaporTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["RaporsTutar"].ToString()), 2));
                UcretsizIzinGun = dr["UcretsizIzin"].ToString();
                UcretsizIzinSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["UcretsizIzinSaat"].ToString()), 2));
                UcretsizIzinTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["UcretsizIzinTutar"].ToString()), 2));

                ToplamKazancGun = Convert.ToString(Convert.ToDecimal(NormalCalismaGun) + Convert.ToDecimal(HaftaTatiliGun) +
                    Convert.ToDecimal(GenelTatilGun) + Convert.ToDecimal(UcretliIzinGun) + Convert.ToDecimal(YillikIzinGun) +
                    Convert.ToDecimal(RaporGun) + Convert.ToDecimal(UcretsizIzinGun));

                ToplamKazancSaat = Convert.ToString(Convert.ToDecimal(NormalCalismaSaat) + Convert.ToDecimal(HaftaTatiliSaat) +
                    Convert.ToDecimal(GenelTatilSaat) + Convert.ToDecimal(UcretliIzinSaat) + Convert.ToDecimal(YillikIzinSaat) +
                    Convert.ToDecimal(RaporSaat) + Convert.ToDecimal(UcretsizIzinSaat));

                ToplamKazancSaat = Convert.ToString(Math.Round(Convert.ToDecimal(ToplamKazancSaat), 2));

                ToplamKazancTutar = Convert.ToString(Convert.ToDecimal(NormalCalismaTutar) + Convert.ToDecimal(HaftaTatiliTutar) +
                    Convert.ToDecimal(GenelTatilTutar) + Convert.ToDecimal(UcretliIzinTutar) + Convert.ToDecimal(YillikIzinTutar) +
                    Convert.ToDecimal(RaporTutar) + Convert.ToDecimal(UcretsizIzinTutar));

                ToplamKazancTutar = Convert.ToString(Math.Round(Convert.ToDecimal(ToplamKazancTutar), 2));

                TatilMesaisiGun = dr["TatilMesaisi"].ToString();
                TatilMesaisiSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["TatilMesaisiSaat"].ToString()), 2));
                TatilMesaisiTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["TatilMesaisiTutar"].ToString()), 2));
                FazlaMesaiGun = dr["FazlaMesai"].ToString();
                FazlaMesaiSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["FazlaMesaiSaat"].ToString()), 2));
                FazlaMesaiTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["FazlaMesaiTutar"].ToString()), 2));
                GeceVardiyasiGun = dr["GeceVardiyasi"].ToString();
                GeceVardiyasiSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["GeceVardiyasiSaat"].ToString()), 2));
                GeceVardiyasiTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["GeceVardiyasiTutar"].ToString()), 2));

                GeceMesaisiSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["GeceMesaisi"].ToString()), 2));
                GeceMesaisiTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["GeceMesaisiTutar"].ToString()), 2));

                UcretliIzinGunSaat = dr["UcretliIzinGunSaat"].ToString();
                UcretliIzinGunSt = Convert.ToString(Math.Round(Convert.ToDecimal(dr["UcretliIzinSaat1"].ToString()), 2));
                UcretliIzinGunTut = Convert.ToString(Math.Round(Convert.ToDecimal(dr["UcretliIzinGunTutar"].ToString()), 2));

                EgitimGun = dr["EgitimGun"].ToString();
                EgitimSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["EgitimSaat"].ToString()), 2));
                EgitimTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["EgitimTutar"].ToString()), 2));
                RaporSaatGun = dr["RaporGunSaat"].ToString();
                RaporStSaat = Convert.ToString(Math.Round(Convert.ToDecimal(dr["RaporSaat"].ToString()), 2));
                RaporStTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["RaporGunTutar"].ToString()), 2));

                EkKazancToplamGun = Convert.ToString(Convert.ToDecimal(TatilMesaisiGun) + Convert.ToDecimal(FazlaMesaiGun) +
                    Convert.ToDecimal(GeceVardiyasiGun) + Convert.ToDecimal(EgitimGun) +
                    Convert.ToDecimal(RaporSaatGun) + Convert.ToDecimal(UcretliIzinGunSaat));

                EkKazancToplamSaat = Convert.ToString(Convert.ToDecimal(TatilMesaisiSaat) + Convert.ToDecimal(FazlaMesaiSaat) +
                    Convert.ToDecimal(GeceVardiyasiSaat) + Convert.ToDecimal(EgitimSaat) +
                    Convert.ToDecimal(RaporStSaat) + Convert.ToDecimal(GeceMesaisiSaat) + Convert.ToDecimal(UcretliIzinGunSt));

                EkKazancToplamSaat = Convert.ToString(Math.Round(Convert.ToDecimal(EkKazancToplamSaat), 2));

                EkKazancToplamTutar = Convert.ToString(Convert.ToDecimal(TatilMesaisiTutar) + Convert.ToDecimal(FazlaMesaiTutar) +
                    Convert.ToDecimal(GeceVardiyasiTutar) + Convert.ToDecimal(EgitimTutar) +
                    Convert.ToDecimal(RaporStTutar) + Convert.ToDecimal(GeceMesaisiTutar) + Convert.ToDecimal(UcretliIzinGunTut));

                EkKazancToplamTutar = Convert.ToString(Math.Round(Convert.ToDecimal(EkKazancToplamTutar), 2));

                YemekYardimiTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["YemekYardimi"].ToString()), 2));
                FazlaCalismaPrimTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["PerformansPirimi"].ToString()), 2));
                IkramiyeTutar = Convert.ToString(Math.Round(Convert.ToDecimal(dr["Ikramiye"].ToString()), 2));
                YillikIzinYardimiTutari = Convert.ToString(Math.Round(Convert.ToDecimal(dr["YillikIzinYardimi"].ToString()), 2));
                YakacakYardimTutari = Convert.ToString(Math.Round(Convert.ToDecimal(dr["YakacakYardimi"].ToString()), 2));
                BayramTatilYardimTutari = Convert.ToString(Math.Round(Convert.ToDecimal(dr["BayramYardimi"].ToString()), 2));
                CocukYardimTutari = Convert.ToString(Math.Round(Convert.ToDecimal(dr["CocukYardimi"].ToString()), 2));
                TahsilYardimi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["TahsilYardimi"].ToString()), 2));
                KasaYardimi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["KasaTazminati"].ToString()), 2));
                IhbarTazminati = Convert.ToString(Math.Round(Convert.ToDecimal(dr["IhbarTazminati"].ToString()), 2));
                KidemTazminati = Convert.ToString(Math.Round(Convert.ToDecimal(dr["KidemTazminati"].ToString()), 2));
                AskerlikYardimi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["AskerlikYardimi"].ToString()), 2));
                IzinYardimTutari = Convert.ToString(Math.Round(Convert.ToDecimal(dr["IzinYardimi"].ToString()), 2));
                PostaBasiTazminatTutari = Convert.ToString(Math.Round(Convert.ToDecimal(dr["PostaBasiTazminati"].ToString()), 2));
                SagSigIsvParayi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["SagSigIsvPayi"].ToString()), 2));
                BenzinYardimi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["BenzinYardimi"].ToString()), 2));
                OdulHediye = Convert.ToString(Math.Round(Convert.ToDecimal(dr["OdulHediye"].ToString()), 2));
                HarcirahTutari = Convert.ToString(Math.Round(Convert.ToDecimal(dr["Harcirah"].ToString()), 2));
                DigerYardimTutari = Convert.ToString(Math.Round(Convert.ToDecimal(dr["DigerYardimlar"].ToString()), 2));

                SosyalYardimToplami = Convert.ToString(Convert.ToDecimal(YemekYardimiTutar) + Convert.ToDecimal(FazlaCalismaPrimTutar) +
                    Convert.ToDecimal(IkramiyeTutar) + Convert.ToDecimal(YillikIzinYardimiTutari) + Convert.ToDecimal(YakacakYardimTutari) +
                    Convert.ToDecimal(BayramTatilYardimTutari) + Convert.ToDecimal(CocukYardimTutari) + Convert.ToDecimal(TahsilYardimi) +
                    Convert.ToDecimal(KasaYardimi) + Convert.ToDecimal(IhbarTazminati) + Convert.ToDecimal(KidemTazminati) +
                    Convert.ToDecimal(AskerlikYardimi) + Convert.ToDecimal(IzinYardimTutari) + Convert.ToDecimal(PostaBasiTazminatTutari) +
                    Convert.ToDecimal(SagSigIsvParayi) + Convert.ToDecimal(BenzinYardimi) + Convert.ToDecimal(OdulHediye) +
                    Convert.ToDecimal(HarcirahTutari) + Convert.ToDecimal(DigerYardimTutari));

                SosyalYardimToplami = Convert.ToString(Math.Round(Convert.ToDecimal(SosyalYardimToplami), 2));

                SgkPrimIsciPayi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["SgkPrimiIsciPayi"].ToString()), 2));
                IssizlikPrimiIsciPayi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["IssizlikPrimiIsciPayi"].ToString()), 2));
                GelirVergisiYasalKesinti = Convert.ToString(Math.Round(Convert.ToDecimal(dr["GelirVergisi"].ToString()), 2));
                DamgaVergisiYasalKesinti = Convert.ToString(Math.Round(Convert.ToDecimal(dr["DamgaVergisi"].ToString()), 2));

                YasalKesintilerToplamTutar = Convert.ToString(Convert.ToDecimal(SgkPrimIsciPayi) + Convert.ToDecimal(IssizlikPrimiIsciPayi) +
                    Convert.ToDecimal(GelirVergisiYasalKesinti) + Convert.ToDecimal(DamgaVergisiYasalKesinti));

                YasalKesintilerToplamTutar = Convert.ToString(Math.Round(Convert.ToDecimal(YasalKesintilerToplamTutar), 2));

                sgkMatrahi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["SgkMatrahi"].ToString()), 2));
                DamgaVergisiMatrahi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["DamgaVergisiMatrahi"].ToString()), 2));
                GelirVergisiMatrahi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["GelirVergisiMatrahi"].ToString()), 2));
                GelirVergisiIndirimi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["GelirVergisiIndirimi"].ToString()), 2));
                EkIndirim = Convert.ToString(Math.Round(Convert.ToDecimal(dr["EkIndirim"].ToString()), 2));
                YillikGelirVergisiMatrahi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["YillikGelirVergisiMatrahi"].ToString()), 2));
                YillikGelirVergisi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["YillikGelirVergisi"].ToString()), 2));

                DigerKesinti4 = String.Format("{0:N}", Convert.ToString(Math.Round(Convert.ToDecimal(dr["PER003_DigerKesinti4"].ToString()), 2)));
                SendikaAidati = Convert.ToString(Math.Round(Convert.ToDecimal(dr["SendikaAidati"].ToString()), 2));
                Icra = Convert.ToString(Math.Round(Convert.ToDecimal(dr["Icra"].ToString()), 2));
                DisiplinCezasi = Convert.ToString(Math.Round(Convert.ToDecimal(dr["Ceza"].ToString()), 2));
                Avans1 = Convert.ToString(Math.Round(Convert.ToDecimal(dr["Avans"].ToString()), 2));
                Avans2 = Convert.ToString(Math.Round(Convert.ToDecimal(dr["Avans2"].ToString()), 2));

                int AyintCevir = Convert.ToInt32(AylarinTarihi(cmbBordroAy.Text.ToString()));

                int BordroNo = 0;

                if (string.IsNullOrEmpty(txtBordroNo.Text.ToString()))
                {
                    BordroNo = 1;
                }
                else
                {
                    BordroNo = Convert.ToInt32(txtBordroNo.Text);
                }

                BorcTaksit = Convert.ToString(Math.Round(Convert.ToDecimal(
                    this.emailAdresKontrolu1.BorcTaksiti(AyintCevir, Convert.ToInt32(cmbBordroYil.Text),
                    BolumKoduParcala[1].ToString(), BolumKoduParcala[0].ToString(), BordroNo)), 2));


                TersBakiye = dr["TersBakiye"].ToString();

                if (Convert.ToDecimal(TersBakiye) < 0)
                {
                    Avans1 = Convert.ToString(Convert.ToDecimal(Avans1) + Convert.ToDecimal(TersBakiye));
                }
                else if (Convert.ToDecimal(TersBakiye) >= 0)
                {
                    Avans1 = Convert.ToString(Convert.ToDecimal(Avans1) - Convert.ToDecimal(TersBakiye));
                }

                Avans2 = Convert.ToString(Convert.ToDecimal(Avans2) - (Convert.ToDecimal(SendikaAidati) + Convert.ToDecimal(Icra) + Convert.ToDecimal(DisiplinCezasi) + Convert.ToDecimal(Avans1)));

                Avans2 = Convert.ToString(Math.Round(Convert.ToDecimal(Avans2), 2));

                Avans2 = Convert.ToString(Convert.ToDecimal(Avans2) - Convert.ToDecimal(BorcTaksit));

                OzelKesintilerToplami = Convert.ToString(Convert.ToDecimal(SendikaAidati) + Convert.ToDecimal(Icra) +
                            Convert.ToDecimal(DisiplinCezasi) + Convert.ToDecimal(Avans1) + Convert.ToDecimal(Avans2) +
                            Convert.ToDecimal(BorcTaksit) + Convert.ToDecimal(DigerKesinti4));
                 //+
                 //           Convert.ToDecimal(BorcTaksit)

                OzelKesintilerToplami = Convert.ToString(Math.Round(Convert.ToDecimal(OzelKesintilerToplami), 2));

                KesintilerToplami = Convert.ToString(Math.Round(Convert.ToDecimal(YasalKesintilerToplamTutar), 2) + Math.Round(Convert.ToDecimal(OzelKesintilerToplami), 2));
                NetOdenen = Convert.ToString(Math.Round(Convert.ToDecimal(dr["NetOdenen"].ToString()), 2));
                AsgariGecimIndirimTutari = Convert.ToString(Math.Round(Convert.ToDecimal(dr["AsgariGecimIndirimi"].ToString()), 2));
                ToplamOdenen = Convert.ToString(Math.Round(Convert.ToDecimal(dr["ToplamOdenen"].ToString()), 2));
                KazanclarToplami = Convert.ToString(Math.Round(Convert.ToDecimal(dr["NormalKazanc"].ToString()), 2));

                BankaHesapKodu = this.emailAdresKontrolu1.BankaHesapBilgisi(DosyaAdi);
                UcretBildirimi = Convert.ToString(Convert.ToDecimal(NetOdenen) + Convert.ToDecimal(AsgariGecimIndirimTutari));
                UcretBildirimi = Convert.ToString(sayiyiYaziyaCevir(Convert.ToDecimal(UcretBildirimi)));

                Logo = ParametreOku.IniOku("Parametre", "Logo");

                //Bildirim = "Ücret bordrosunun bir suretini teslim aldım. " + cmbBordroYil.Text + " " + cmbBordroAy.Text + " ayına ait yukarıda " +
                //    "yazılı ücretimin tamamı olan " + Convert.ToString(Convert.ToDecimal(NetOdenen) + Convert.ToDecimal(AsgariGecimIndirimTutari)) + " TL'i " +
                //    txtBanka.Text + " Şubesindeki " + BankaHesapKodu + " nolu banka hesabımdan eksiksiz bir şekilde,zamanında tahsil ettim. İlgili aya ilişkin " +
                //    "başkaca hiçbir hak ve alacağım kalmadığından işverenimi geri dönülmez bir şekilde külliyen ibra ederim.";

                Bildirim = cmbBordroYil.Text + " Yılının " + cmbBordroAy.Text + " ayı itibari ile adınıza taahhuk eden " + Convert.ToString(Convert.ToDecimal(NetOdenen) + Convert.ToDecimal(AsgariGecimIndirimTutari)) + " TL " +
                UcretBildirimi + " " + txtBanka.Text + " Şubesindeki " + BankaHesapKodu + " nolu Hesabınıza yatırılacaktır.";

                string BordroArsivAyi = cmbBordroAy.Text;

                string fileName = Application.StartupPath + "\\Bordrolar\\";
                string Klasor = fileName + "\\" + cmbBordroYil.Text.ToString();
                string AltKlasor = Klasor + "\\" + BordroArsivAyi + "\\" + txtBordroNo.Text + "\\" + ArsivBordroTipi;

                if (!Directory.Exists(Klasor))
                {
                    Directory.CreateDirectory(Klasor);
                }

                if (!Directory.Exists(AltKlasor))
                {
                    Directory.CreateDirectory(AltKlasor);
                }

                string PdffileName = AltKlasor + "\\" + DosyaAdi + "_" + AdSoyad + ".pdf";

                DosyaAdresi[DosyaYoluSayisi] = PdffileName;
                DosyaYoluSayisi++;

                string textToAdd = BordroOlustur(SirketUnvani, SirketSskNo, SirketTicaretSicilNo, SirketMerkezi, SirketWebAdresi, BordroAyYil, IslemTarihi,
                    BlSicilNo, AdSoyad, CocukAdedi, IseGirisTarihi, PersonelUcreti, personelUcretBilgisi, TcNo, SgkNo, SgkGun, NormalCalismaGun, NormalCalismaSaat, NormalCalismaTutar,
                    HaftaTatiliGun, HaftaTatiliSaat, HaftaTatiliTutar, GenelTatilGun, GenelTatilSaat, GenelTatilTutar, UcretliIzinGun, UcretliIzinSaat,
                    UcretliIzinTutar, YillikIzinGun, YillikIzinSaat, YillikIzinTutar, RaporGun, RaporSaat, RaporTutar, UcretsizIzinGun, UcretsizIzinSaat, UcretsizIzinTutar,
                    ToplamKazancGun, ToplamKazancSaat, ToplamKazancTutar, TatilMesaisiGun, TatilMesaisiSaat, TatilMesaisiTutar, FazlaMesaiGun, FazlaMesaiSaat, FazlaMesaiTutar,
                    GeceVardiyasiGun, GeceVardiyasiSaat, GeceVardiyasiTutar, UcretliIzinGunSaat, UcretliIzinGunSt, UcretliIzinGunTut,
                    EgitimGun, EgitimSaat, EgitimTutar, RaporSaatGun, RaporStSaat, RaporStTutar, EkKazancToplamGun, EkKazancToplamSaat, EkKazancToplamTutar,
                    YemekYardimiTutar, FazlaCalismaPrimTutar, IkramiyeTutar, YillikIzinYardimiTutari, YakacakYardimTutari, BayramTatilYardimTutari,
                    CocukYardimTutari, TahsilYardimi, KasaYardimi, IhbarTazminati, KidemTazminati, AskerlikYardimi, IzinYardimTutari,
                    PostaBasiTazminatTutari, SagSigIsvParayi, BenzinYardimi, OdulHediye, HarcirahTutari, DigerYardimTutari, SosyalYardimToplami,
                    SendikaAidati, Avans1, Icra, DisiplinCezasi, Avans2, OzelKesintilerToplami, SgkPrimIsciPayi, IssizlikPrimiIsciPayi, GelirVergisiYasalKesinti,
                    DamgaVergisiYasalKesinti, YasalKesintilerToplamTutar, sgkMatrahi, sgkPrimiIsveren, IssizlikPrimiIsveren, SgkIsverenTesvigi,
                    SgkOdenecekIsveren, DamgaVergisiMatrahi, GelirVergisiMatrahi, GelirVergisiIndirimi, EkIndirim, YillikGelirVergisiMatrahi,
                    YillikGelirVergisi, KesintilerToplami, NetOdenen, AsgariGecimIndirimTutari, ToplamOdenen, KazanclarToplami, "0", GeceMesaisiSaat,
                    GeceMesaisiTutar, SirketMersisNo, Bildirim, Logo, BorcTaksit, DigerKesinti4);

                //if (File.Exists(htmlFileName))
                //{
                //    File.Delete(htmlFileName);
                //}

                //using (FileStream fs = new FileStream(htmlFileName, FileMode.CreateNew))
                //{
                //    using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 512))
                //    {
                //        writer.Write(textToAdd);
                //    }
                //}

                #region Pdf Oluşturuyoruz

                string pdfYolumuz = PdffileName;

                StringReader stringReader = new StringReader(textToAdd);
                string htmlKodumuz = stringReader.ReadToEnd();

                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(pdfYolumuz, FileMode.Create));
                StringReader sR = new StringReader(htmlKodumuz);

                iTextSharp.text.html.simpleparser.StyleSheet styles = new iTextSharp.text.html.simpleparser.StyleSheet();

                styles.LoadTagStyle(HtmlTags.BODY, "face", "Calibri");
                styles.LoadTagStyle(HtmlTags.BODY, "size", "8pt");

                styles.LoadTagStyle(HtmlTags.TABLE, HtmlTags.CELLPADDING, "0");
                styles.LoadTagStyle(HtmlTags.TR, "border", "0.2");

                styles.LoadTagStyle(HtmlTags.IMG, "width", "160");
                styles.LoadTagStyle(HtmlTags.IMG, HtmlTags.ALIGN, HtmlTags.ALIGN_CENTER);

                styles.LoadTagStyle(HtmlTags.TD, HtmlTags.FONTSIZE, "8pt");
                styles.LoadTagStyle(HtmlTags.TD, HtmlTags.VERTICALALIGN, "middle");
                styles.LoadTagStyle(HtmlTags.TD, HtmlTags.FONTFAMILY, "Calibri");

                HTMLWorker HW = new HTMLWorker(document);
                HW.SetStyleSheet(styles);
                document.Open();
                HW.Parse(sR);
                document.Close();

                #endregion

                prograscontrol++;
                prBordrolar.PerformStep();
            }

            prBordrolar.Properties.Minimum = 1;
            prBordrolar.Visible = false;

            int ToplamBordroSayimiz = Convert.ToInt32(dsBordrolar.BordlariGetir.Rows.Count);
            MessageBox.Show(Convert.ToString(ToplamBordroSayimiz) + " Adet Personel Bordrosu Başarılı Şekilde Gönderime Hazırlanmıştır");

            btnBordroOlustur.Enabled = true;
            btnEmailAyarla.Enabled = true;
            btnBordroGetir.Enabled = true;
            btnBordrolariGonder.Enabled = true;
            btnHepsiniSec.Enabled = true;
            btnHepsiniKaldir.Enabled = true;
            btnBordroDurdur.Enabled = false;
        }

        private void SirketKodlariniBul()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string Sorgu = @"SELECT PER004_IsyeriKodu AS IsyeriKodu,PER004_Unvan1+' ' +PER004_Unvan2 AS Unvan,PER004_IsyerininSskNumarasi AS SskNo, 
                        PER004_TicaretSicilNo AS TicaretSicilNo,PER004_Ilce+'/'+PER004_Il AS IsletmeMerkezi,
                        PER004_WebAdres AS WebAdresi,PER004_MersisNo AS MersisNo
                        FROM PER004";

            cmd = new SqlCommand(Sorgu, Conn);
            SqlDataReader drSirketKodlari = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            int a = 0;

            while (drSirketKodlari.Read())
            {
                cmbSirketKodlari.Items.Add(drSirketKodlari["IsyeriKodu"].ToString());
            }

            drSirketKodlari.Dispose();
            drSirketKodlari.Close();

        }

        private void btnHepsiniSec_Click(object sender, EventArgs e)
        {
            if (dsBordrolar.BordlariGetir.Rows.Count > 0)
            {
                for (int i = 0; i < dsBordrolar.BordlariGetir.Rows.Count; i++)
                {
                    dsBordrolar.BordlariGetir.Rows[i]["Sec"] = "True";
                    //gridView1.SetRowCellValue(i, "Sec", "True");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Önce Bordroları Getirin.");
            }   
        }

        private void btnHepsiniKaldir_Click(object sender, EventArgs e)
        {
            if (dsBordrolar.BordlariGetir.Rows.Count > 0)
            {
                for (int i = 0; i < dsBordrolar.BordlariGetir.Rows.Count; i++)
                {
                    //gridView1.SetRowCellValue(i, "Sec", "False");
                    dsBordrolar.BordlariGetir.Rows[i]["Sec"] = "False";
                }
            }
            else
            {
                MessageBox.Show("Lütfen Önce Bordroları Getirin.");
            } 
        }

        private string sayiyiYaziyaCevir(decimal rakam)
        {
            string sTutar = rakam.ToString("F2").Replace('.', ',');
            string lira = sTutar.Substring(0, sTutar.IndexOf(','));
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";

            string[] birler = { "", "BİR", "İKİ", "ÜÇ", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
            string[] onlar = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
            string[] binler = { "KATRİLYON", "TRİLYON", "MİLYAR", "MİLYON", "BİN", "" };

            int grupSayisi = 6;

            lira = lira.PadLeft(grupSayisi * 3, '0');

            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3)
            {
                grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "YÜZ"; //yüzler                

                if (grupDegeri == "BİRYÜZ")
                    grupDegeri = "YÜZ";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                

                if (grupDegeri != "")
                    grupDegeri += binler[i / 3];

                if (grupDegeri == "BİRBİN")
                    grupDegeri = "BİN";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " TL ";

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " KR.";
            else
                yazi += "SIFIR KR.";

            return yazi;
        }

        private void BordroHazirlama_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Kanal != null)
            {
                Kanal.Abort();
            }
        }

        private void btnBordroDurdur_Click(object sender, EventArgs e)
        {
            if (Kanal != null)
            {
                Kanal.Abort();
                btnBordroOlustur.Enabled = true;
                btnEmailAyarla.Enabled = true;
                btnBordroGetir.Enabled = true;
                btnBordrolariGonder.Enabled = true;
                btnHepsiniSec.Enabled = true;
                btnHepsiniKaldir.Enabled = true;
                btnBordroDurdur.Enabled = false;
            }
        }

    }
}
