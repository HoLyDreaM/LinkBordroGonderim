using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bordro_Gonder
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        public AnaForm anaFrm
        {
            get;
            set;
        }

        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath + "\\LoginSettings.ini");
        iniOku.iniOku ParametreOku = new iniOku.iniOku(Application.StartupPath + "\\Parametre.ini");

        iniOku.iniOku uzakIni;
        string Cs = Properties.Settings.Default.DbConn;
        string CsKontrol = Properties.Settings.Default.DbHata;
        SqlConnection con = new SqlConnection();
        public string sirketAdi;

        //Form Ayarları

        public LoginForm FrmGiris;
        public EMailAyarlari FrmEmail;
        public BordroHazirlama BrdHazirla;
        public BordroKontrol BrdKontrol;
        public ParametreTanimlari PrmTanimlari;

        //Versiyon Ayarları

        private void AnaForm_Load(object sender, EventArgs e)
        {
            #region Şirket Adı-Tarih Ve Adres Bilgi Tarafı

            lblSirket.Text = sirketAdi;
            lblKayanYazi.Text = "Editör Bilgi İşlem Elektronik San. ve Tic. Ltd. Şti.     Tel&&Faks : [224] 251 84 55      Web : www.editorgroup.net      E-mail : editor@editorgroup.net      Programmer : Mehmet ÖZDEMİR" +
                          "                                                                                                                                                        ";
            #endregion

            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            CheckForIllegalCrossThreadCalls = false;

            bgForm frmacilis = new bgForm();
            frmacilis.MdiParent = this;
            frmacilis.Show();
        }

        private void timerTarih_Tick(object sender, EventArgs e)
        {
            this.lblKayanYazi.Text = lblKayanYazi.Text.Substring(1) + lblKayanYazi.Text[0].ToString();
            lblTarih.Text = DateTime.Now.ToString();
        }

        private void btnLoginAyari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmGiris == null || FrmGiris.IsDisposed)
            {
                FrmGiris = new LoginForm();
                FrmGiris.kontrol = false;
                FrmGiris.Show();
            }
            else
            {
                FrmGiris.Activate();
            }
        }

        private void btnEmailAyarlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmEmail == null || FrmEmail.IsDisposed)
            {
                FrmEmail = new EMailAyarlari();
                FrmEmail.kontrol = false;
                FrmEmail.Show();
            }
            else
            {
                FrmEmail.Activate();
            }
        }

        private void btnBordroHazirlama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BrdHazirla == null || BrdHazirla.IsDisposed)
            {
                BrdHazirla = new BordroHazirlama();
                BrdHazirla.Owner = this;
                BrdHazirla.MdiParent = this;
                BrdHazirla.anaFrm = this;
                BrdHazirla.Cs = Cs.ToString();
                BrdHazirla.Show();
            }
            else
            {
                BrdHazirla.Activate();
            }
        }

        private void btnBordroKontrolu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BrdKontrol == null || BrdKontrol.IsDisposed)
            {
                BrdKontrol = new BordroKontrol();
                BrdKontrol.Owner = this;
                BrdKontrol.MdiParent = this;
                BrdKontrol.anaFrm = this;
                BrdKontrol.Cs = Cs.ToString();
                BrdKontrol.Show();
            }
            else
            {
                BrdKontrol.Activate();
            }
        }

        private void Koseicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Maximized;
            Koseicon.Visible = false;
        }

        private void AnaForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                Koseicon.Visible = true;

                Thread.Sleep(3000);
                Koseicon.ShowBalloonTip(1000, "Major", "Major Bordro E-Mail Gönderimi", ToolTipIcon.Info);
            }
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnParametreBilgileri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PrmTanimlari == null || PrmTanimlari.IsDisposed)
            {
                PrmTanimlari = new ParametreTanimlari();
                PrmTanimlari.kontrol = false;
                PrmTanimlari.Show();
            }
            else
            {
                PrmTanimlari.Activate();
            }
        }
    }
}
