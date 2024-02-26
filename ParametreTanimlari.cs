using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bordro_Gonder
{
    public partial class ParametreTanimlari : Form
    {
        public ParametreTanimlari()
        {
            InitializeComponent();
        }

        AnaForm anafrm;
        public Boolean kontrol = true;
        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath + "\\Parametre.ini");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            iniOku.IniYaz("Parametre", "Banka", txtBankaBilgileri.Text);
            iniOku.IniYaz("Parametre", "Logo", txtLogoAdresi.Text);

            MessageBox.Show("Parametre Bilgileri Kaydedildi");
        }

        private void ParametreTanimlari_Load(object sender, EventArgs e)
        {
            txtBankaBilgileri.Text = iniOku.IniOku("Parametre", "Banka");
            txtLogoAdresi.Text = iniOku.IniOku("Parametre", "Logo");
        }
    }
}
