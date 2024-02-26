using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bordro_Gonder
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath + "\\LoginSettings.ini");
        string yol, yol2;
        private string version;
        SqlConnection con = new SqlConnection();
        SqlConnection conHata = new SqlConnection();
        AnaForm anafrm;
        public Boolean kontrol = true;

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            conHata.Close();
            con.Close();

            Properties.Settings.Default["DbConn"] = "Data Source=" + txtServer.Text + ";Initial Catalog=YNS" + txtSirket.Text + ";User ID=YNS" + txtSirket.Text + ";Password=PSW" + txtSirket.Text + "";
            Properties.Settings.Default["DbHata"] = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtBordroVeritabani.Text + ";User ID=" + txtBordroKullaniciAdi.Text + ";Password=" + txtBordroSifre.Text + "";

            yol = Properties.Settings.Default.DbConn;
            yol2 = Properties.Settings.Default.DbHata;
            con.ConnectionString = yol;
            conHata.ConnectionString = yol2;
            try
            {
                con.Open();
                conHata.Open();
                conHata.Close();
                con.Close();
                anafrm = new AnaForm();

                if (kontrol) Program.ac.MainForm = anafrm;
                iniOku.IniYaz("Ayar", "Server", txtServer.Text);
                iniOku.IniYaz("Ayar", "Sirket", txtSirket.Text);
                iniOku.IniYaz("Ayar", "KullaniciAdi", txtKullaniciAdi.Text);
                iniOku.IniYaz("Ayar", "Sifre", Sifrele(txtSifre.Text));
                iniOku.IniYaz("Ayar", "BordroDb", txtBordroVeritabani.Text);
                iniOku.IniYaz("Ayar", "BordroKullaniciAdi", txtBordroKullaniciAdi.Text);
                iniOku.IniYaz("Ayar", "BordroSifre", Sifrele(txtBordroSifre.Text));
                iniOku.IniYaz("Ayar", "oto", oto.Checked.ToString());
                con.Close();
                conHata.Close();

                if (kontrol)
                {
                    anafrm.sirketAdi = txtSirket.Text;
                    anafrm.Show();
                }
                else
                {
                    Application.Restart();
                }
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Sağlanamadı");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                txtServer.Text = iniOku.IniOku("Ayar", "Server");
                txtSirket.Text = iniOku.IniOku("Ayar", "Sirket");
                txtKullaniciAdi.Text = iniOku.IniOku("Ayar", "KullaniciAdi");
                txtSifre.Text = Coz(iniOku.IniOku("Ayar", "Sifre"));
                txtBordroVeritabani.Text = iniOku.IniOku("Ayar", "BordroDb");
                txtBordroKullaniciAdi.Text = iniOku.IniOku("Ayar", "BordroKullaniciAdi");
                txtBordroSifre.Text = Coz(iniOku.IniOku("Ayar", "BordroSifre"));

                oto.Checked = Convert.ToBoolean(iniOku.IniOku("Ayar", "oto"));
                version = iniOku.IniOku("Ayar", "version");

                if (oto.Checked && kontrol)
                    btnBaglan_Click(sender, e);
            }
            catch { }
        }

        private static string Coz(string cozVeri)
        {
            byte[] cozByteDizi = System.Convert.FromBase64String(cozVeri);
            string orjinalVeri = System.Text.ASCIIEncoding.ASCII.GetString(cozByteDizi);
            return orjinalVeri;
        }

        private static string Sifrele(string veri)
        {
            byte[] veriByteDizisi = System.Text.ASCIIEncoding.ASCII.GetBytes(veri);
            string sifrelenmisVeri = System.Convert.ToBase64String(veriByteDizisi);
            return sifrelenmisVeri;
        }
    }
}
