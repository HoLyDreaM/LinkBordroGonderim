namespace Bordro_Gonder
{
    partial class BordroHazirlama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBordroDurdur = new DevExpress.XtraEditors.SimpleButton();
            this.prBordrolar = new DevExpress.XtraEditors.ProgressBarControl();
            this.txtBanka = new System.Windows.Forms.TextBox();
            this.lblBanka = new System.Windows.Forms.Label();
            this.btnHepsiniKaldir = new DevExpress.XtraEditors.SimpleButton();
            this.btnHepsiniSec = new DevExpress.XtraEditors.SimpleButton();
            this.cmbSirketKodlari = new System.Windows.Forms.ComboBox();
            this.lblSirketKodlari = new System.Windows.Forms.Label();
            this.btnEmailAyarla = new DevExpress.XtraEditors.SimpleButton();
            this.btnBordroGetir = new DevExpress.XtraEditors.SimpleButton();
            this.txtBordroNo = new System.Windows.Forms.TextBox();
            this.cmbBordroAy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbBordroTipi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbBordroYil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblBordroNo = new System.Windows.Forms.Label();
            this.lblBordroTip = new System.Windows.Forms.Label();
            this.lblBordroAy = new System.Windows.Forms.Label();
            this.lblBordroYil = new System.Windows.Forms.Label();
            this.btnBordrolariGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnBordroOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdBordro = new DevExpress.XtraGrid.GridControl();
            this.bordlariGetirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBordrolar = new Bordro_Gonder.dsBordrolar();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBlSicil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUcret = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGirisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTcNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSGKNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCocukAdedi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSgkGun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNormalCalisma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHaftaTatili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelTatil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUcretliIzin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYillikIzinGun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYillikIzinSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYillikIzinTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaporsGun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaporsSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaporsTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUcretsizIzin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUcretsizIzinSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUcretsizIzinTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNormalCalismaSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNormalCalismaTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHaftaTatiliSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHaftaTatiliTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelTatilSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelTatilTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUcretliIzinSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUcretliIzinTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTatilMesaisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTatilMesaisiSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTatilMesaisiTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFazlaMesai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFazlaMesaiSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFazlaMesaiTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeceVardiyasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeceVardiyasiSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeceVardiyasiTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUcretliIzinGunSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUcretliIzinSaat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUcretliIzinGunTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEgitimGun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEgitimSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEgitimTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaporGunSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaporSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaporGunTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYemekYardimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerformansPirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIkramiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYillikIzinYardimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYakacakYardimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBayramYardimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCocukYardimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTahsilYardimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaTazminati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIhbarTazminati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKidemTazminati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAskerlikYardimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIzinYardimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostaBasiTazminati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSagSigIsvPayi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBenzinYardimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdulHediye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHarcirah = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDigerYardimlar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSgkPrimiIsciPayi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssizlikPrimiIsciPayi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGelirVergisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDamgaVergisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSgkMatrahi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSgkPrimiIsverenHissesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsizlikPrimiIsverenHisessi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSgkTesvikTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSgkOdenecekIsverenHisessi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDamgaVergisiMatrahi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGelirVergisiMatrahi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGelirVergisiIndirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEkIndirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYillikGelirVergisiMatrahi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYillikGelirVergisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendikaAidati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIcra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCeza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTersBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvans2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAsgariGecimIndirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNormalKazanc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeceMesaisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeceMesaisiNet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeceMesaisiTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIscıMemur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.emailAdresKontrolu1 = new Bordro_Gonder.dsBordrolarTableAdapters.EmailAdresKontrolu();
            this.emailDurumuTableAdapter1 = new Bordro_Gonder.dsBordrolarTableAdapters.EmailDurumuTableAdapter();
            this.bordlariGetirTableAdapter = new Bordro_Gonder.dsBordrolarTableAdapters.BordlariGetirTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prBordrolar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBordroAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBordroTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBordroYil.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBordro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bordlariGetirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBordrolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBordroDurdur);
            this.panel1.Controls.Add(this.prBordrolar);
            this.panel1.Controls.Add(this.txtBanka);
            this.panel1.Controls.Add(this.lblBanka);
            this.panel1.Controls.Add(this.btnHepsiniKaldir);
            this.panel1.Controls.Add(this.btnHepsiniSec);
            this.panel1.Controls.Add(this.cmbSirketKodlari);
            this.panel1.Controls.Add(this.lblSirketKodlari);
            this.panel1.Controls.Add(this.btnEmailAyarla);
            this.panel1.Controls.Add(this.btnBordroGetir);
            this.panel1.Controls.Add(this.txtBordroNo);
            this.panel1.Controls.Add(this.cmbBordroAy);
            this.panel1.Controls.Add(this.cmbBordroTipi);
            this.panel1.Controls.Add(this.cmbBordroYil);
            this.panel1.Controls.Add(this.lblBordroNo);
            this.panel1.Controls.Add(this.lblBordroTip);
            this.panel1.Controls.Add(this.lblBordroAy);
            this.panel1.Controls.Add(this.lblBordroYil);
            this.panel1.Controls.Add(this.btnBordrolariGonder);
            this.panel1.Controls.Add(this.btnBordroOlustur);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 178);
            this.panel1.TabIndex = 1;
            // 
            // btnBordroDurdur
            // 
            this.btnBordroDurdur.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBordroDurdur.Appearance.Options.UseFont = true;
            this.btnBordroDurdur.Location = new System.Drawing.Point(652, 97);
            this.btnBordroDurdur.Name = "btnBordroDurdur";
            this.btnBordroDurdur.Size = new System.Drawing.Size(169, 24);
            this.btnBordroDurdur.TabIndex = 69;
            this.btnBordroDurdur.Text = "&Bordro Hazırlamayı Durdur";
            this.btnBordroDurdur.Click += new System.EventHandler(this.btnBordroDurdur_Click);
            // 
            // prBordrolar
            // 
            this.prBordrolar.Location = new System.Drawing.Point(388, 131);
            this.prBordrolar.Name = "prBordrolar";
            this.prBordrolar.Properties.Appearance.BackColor = System.Drawing.Color.Green;
            this.prBordrolar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.prBordrolar.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.prBordrolar.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Green;
            this.prBordrolar.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.prBordrolar.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.prBordrolar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Green;
            this.prBordrolar.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.prBordrolar.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.prBordrolar.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Green;
            this.prBordrolar.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.prBordrolar.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.prBordrolar.Properties.ShowTitle = true;
            this.prBordrolar.Properties.StartColor = System.Drawing.Color.Green;
            this.prBordrolar.Size = new System.Drawing.Size(349, 36);
            this.prBordrolar.TabIndex = 2;
            // 
            // txtBanka
            // 
            this.txtBanka.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBanka.Location = new System.Drawing.Point(571, 57);
            this.txtBanka.Name = "txtBanka";
            this.txtBanka.Size = new System.Drawing.Size(298, 23);
            this.txtBanka.TabIndex = 68;
            // 
            // lblBanka
            // 
            this.lblBanka.BackColor = System.Drawing.Color.Silver;
            this.lblBanka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBanka.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBanka.Location = new System.Drawing.Point(495, 57);
            this.lblBanka.Name = "lblBanka";
            this.lblBanka.Size = new System.Drawing.Size(76, 23);
            this.lblBanka.TabIndex = 67;
            this.lblBanka.Text = "Banka";
            this.lblBanka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHepsiniKaldir
            // 
            this.btnHepsiniKaldir.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniKaldir.Appearance.Options.UseFont = true;
            this.btnHepsiniKaldir.Location = new System.Drawing.Point(157, 136);
            this.btnHepsiniKaldir.Name = "btnHepsiniKaldir";
            this.btnHepsiniKaldir.Size = new System.Drawing.Size(156, 23);
            this.btnHepsiniKaldir.TabIndex = 65;
            this.btnHepsiniKaldir.Text = "&Tüm E-Mail Seçimi Kaldır";
            this.btnHepsiniKaldir.Click += new System.EventHandler(this.btnHepsiniKaldir_Click);
            // 
            // btnHepsiniSec
            // 
            this.btnHepsiniSec.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSec.Appearance.Options.UseFont = true;
            this.btnHepsiniSec.Location = new System.Drawing.Point(12, 136);
            this.btnHepsiniSec.Name = "btnHepsiniSec";
            this.btnHepsiniSec.Size = new System.Drawing.Size(129, 23);
            this.btnHepsiniSec.TabIndex = 66;
            this.btnHepsiniSec.Text = "&Tüm E-Mailleri Seç";
            this.btnHepsiniSec.Click += new System.EventHandler(this.btnHepsiniSec_Click);
            // 
            // cmbSirketKodlari
            // 
            this.cmbSirketKodlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSirketKodlari.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSirketKodlari.FormattingEnabled = true;
            this.cmbSirketKodlari.Location = new System.Drawing.Point(107, 24);
            this.cmbSirketKodlari.Name = "cmbSirketKodlari";
            this.cmbSirketKodlari.Size = new System.Drawing.Size(153, 24);
            this.cmbSirketKodlari.TabIndex = 64;
            // 
            // lblSirketKodlari
            // 
            this.lblSirketKodlari.BackColor = System.Drawing.Color.Silver;
            this.lblSirketKodlari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSirketKodlari.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSirketKodlari.Location = new System.Drawing.Point(12, 24);
            this.lblSirketKodlari.Name = "lblSirketKodlari";
            this.lblSirketKodlari.Size = new System.Drawing.Size(95, 24);
            this.lblSirketKodlari.TabIndex = 63;
            this.lblSirketKodlari.Text = "Şirket Kodları";
            this.lblSirketKodlari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEmailAyarla
            // 
            this.btnEmailAyarla.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEmailAyarla.Appearance.Options.UseFont = true;
            this.btnEmailAyarla.Location = new System.Drawing.Point(314, 97);
            this.btnEmailAyarla.Name = "btnEmailAyarla";
            this.btnEmailAyarla.Size = new System.Drawing.Size(141, 24);
            this.btnEmailAyarla.TabIndex = 5;
            this.btnEmailAyarla.Text = "&E-Mail Adresini Ayarla";
            this.btnEmailAyarla.Click += new System.EventHandler(this.btnEmailAyarla_Click);
            // 
            // btnBordroGetir
            // 
            this.btnBordroGetir.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBordroGetir.Appearance.Options.UseFont = true;
            this.btnBordroGetir.Location = new System.Drawing.Point(12, 97);
            this.btnBordroGetir.Name = "btnBordroGetir";
            this.btnBordroGetir.Size = new System.Drawing.Size(131, 24);
            this.btnBordroGetir.TabIndex = 3;
            this.btnBordroGetir.Text = "&Bordro Getir";
            this.btnBordroGetir.Click += new System.EventHandler(this.btnBordroGetir_Click);
            // 
            // txtBordroNo
            // 
            this.txtBordroNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBordroNo.Location = new System.Drawing.Point(354, 59);
            this.txtBordroNo.Name = "txtBordroNo";
            this.txtBordroNo.Size = new System.Drawing.Size(135, 21);
            this.txtBordroNo.TabIndex = 2;
            // 
            // cmbBordroAy
            // 
            this.cmbBordroAy.EditValue = "Ocak";
            this.cmbBordroAy.Location = new System.Drawing.Point(107, 57);
            this.cmbBordroAy.Name = "cmbBordroAy";
            this.cmbBordroAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBordroAy.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbBordroAy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbBordroAy.Size = new System.Drawing.Size(153, 20);
            this.cmbBordroAy.TabIndex = 1;
            // 
            // cmbBordroTipi
            // 
            this.cmbBordroTipi.EditValue = "Normal";
            this.cmbBordroTipi.Location = new System.Drawing.Point(571, 26);
            this.cmbBordroTipi.Name = "cmbBordroTipi";
            this.cmbBordroTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBordroTipi.Properties.Items.AddRange(new object[] {
            "Fark",
            "Normal"});
            this.cmbBordroTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbBordroTipi.Size = new System.Drawing.Size(135, 20);
            this.cmbBordroTipi.TabIndex = 0;
            // 
            // cmbBordroYil
            // 
            this.cmbBordroYil.Location = new System.Drawing.Point(354, 27);
            this.cmbBordroYil.Name = "cmbBordroYil";
            this.cmbBordroYil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBordroYil.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbBordroYil.Size = new System.Drawing.Size(135, 20);
            this.cmbBordroYil.TabIndex = 0;
            // 
            // lblBordroNo
            // 
            this.lblBordroNo.BackColor = System.Drawing.Color.Silver;
            this.lblBordroNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBordroNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBordroNo.Location = new System.Drawing.Point(278, 59);
            this.lblBordroNo.Name = "lblBordroNo";
            this.lblBordroNo.Size = new System.Drawing.Size(76, 21);
            this.lblBordroNo.TabIndex = 59;
            this.lblBordroNo.Text = "Bordro No";
            this.lblBordroNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBordroTip
            // 
            this.lblBordroTip.BackColor = System.Drawing.Color.Silver;
            this.lblBordroTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBordroTip.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBordroTip.Location = new System.Drawing.Point(495, 25);
            this.lblBordroTip.Name = "lblBordroTip";
            this.lblBordroTip.Size = new System.Drawing.Size(76, 21);
            this.lblBordroTip.TabIndex = 59;
            this.lblBordroTip.Text = "Bordro Tipi";
            this.lblBordroTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBordroAy
            // 
            this.lblBordroAy.BackColor = System.Drawing.Color.Silver;
            this.lblBordroAy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBordroAy.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBordroAy.Location = new System.Drawing.Point(11, 56);
            this.lblBordroAy.Name = "lblBordroAy";
            this.lblBordroAy.Size = new System.Drawing.Size(96, 21);
            this.lblBordroAy.TabIndex = 59;
            this.lblBordroAy.Text = "Bordro Ay";
            this.lblBordroAy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBordroYil
            // 
            this.lblBordroYil.BackColor = System.Drawing.Color.Silver;
            this.lblBordroYil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBordroYil.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBordroYil.Location = new System.Drawing.Point(278, 26);
            this.lblBordroYil.Name = "lblBordroYil";
            this.lblBordroYil.Size = new System.Drawing.Size(76, 21);
            this.lblBordroYil.TabIndex = 59;
            this.lblBordroYil.Text = "Bordro Yıl";
            this.lblBordroYil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBordrolariGonder
            // 
            this.btnBordrolariGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBordrolariGonder.Appearance.Options.UseFont = true;
            this.btnBordrolariGonder.Location = new System.Drawing.Point(478, 97);
            this.btnBordrolariGonder.Name = "btnBordrolariGonder";
            this.btnBordrolariGonder.Size = new System.Drawing.Size(155, 24);
            this.btnBordrolariGonder.TabIndex = 6;
            this.btnBordrolariGonder.Text = "&Bordrolari Gonder";
            this.btnBordrolariGonder.Click += new System.EventHandler(this.btnBordrolariGonder_Click);
            // 
            // btnBordroOlustur
            // 
            this.btnBordroOlustur.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBordroOlustur.Appearance.Options.UseFont = true;
            this.btnBordroOlustur.Location = new System.Drawing.Point(157, 97);
            this.btnBordroOlustur.Name = "btnBordroOlustur";
            this.btnBordroOlustur.Size = new System.Drawing.Size(129, 24);
            this.btnBordroOlustur.TabIndex = 4;
            this.btnBordroOlustur.Text = "&Bordro Oluştur";
            this.btnBordroOlustur.Click += new System.EventHandler(this.btnBordroOlustur_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdBordro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 293);
            this.panel2.TabIndex = 0;
            // 
            // grdBordro
            // 
            this.grdBordro.DataSource = this.bordlariGetirBindingSource;
            this.grdBordro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBordro.Location = new System.Drawing.Point(0, 0);
            this.grdBordro.MainView = this.gridView1;
            this.grdBordro.Name = "grdBordro";
            this.grdBordro.Size = new System.Drawing.Size(904, 293);
            this.grdBordro.TabIndex = 0;
            this.grdBordro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bordlariGetirBindingSource
            // 
            this.bordlariGetirBindingSource.DataMember = "BordlariGetir";
            this.bordlariGetirBindingSource.DataSource = this.dsBordrolar;
            // 
            // dsBordrolar
            // 
            this.dsBordrolar.DataSetName = "dsBordrolar";
            this.dsBordrolar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBlSicil,
            this.colAdSoyad,
            this.colUcret,
            this.colGirisTarihi,
            this.colTcNo,
            this.colEmail,
            this.colSGKNo,
            this.colCocukAdedi,
            this.colSgkGun,
            this.colNormalCalisma,
            this.colHaftaTatili,
            this.colGenelTatil,
            this.colUcretliIzin,
            this.colYillikIzinGun,
            this.colYillikIzinSaat,
            this.colYillikIzinTutari,
            this.colRaporsGun,
            this.colRaporsSaat,
            this.colRaporsTutar,
            this.colUcretsizIzin,
            this.colUcretsizIzinSaat,
            this.colUcretsizIzinTutar,
            this.colNormalCalismaSaat,
            this.colNormalCalismaTutar,
            this.colHaftaTatiliSaat,
            this.colHaftaTatiliTutar,
            this.colGenelTatilSaat,
            this.colGenelTatilTutar,
            this.colUcretliIzinSaat,
            this.colUcretliIzinTutar,
            this.colTatilMesaisi,
            this.colTatilMesaisiSaat,
            this.colTatilMesaisiTutar,
            this.colFazlaMesai,
            this.colFazlaMesaiSaat,
            this.colFazlaMesaiTutar,
            this.colGeceVardiyasi,
            this.colGeceVardiyasiSaat,
            this.colGeceVardiyasiTutar,
            this.colUcretliIzinGunSaat,
            this.colUcretliIzinSaat1,
            this.colUcretliIzinGunTutar,
            this.colEgitimGun,
            this.colEgitimSaat,
            this.colEgitimTutar,
            this.colRaporGunSaat,
            this.colRaporSaat,
            this.colRaporGunTutar,
            this.colYemekYardimi,
            this.colPerformansPirimi,
            this.colIkramiye,
            this.colYillikIzinYardimi,
            this.colYakacakYardimi,
            this.colBayramYardimi,
            this.colCocukYardimi,
            this.colTahsilYardimi,
            this.colKasaTazminati,
            this.colIhbarTazminati,
            this.colKidemTazminati,
            this.colAskerlikYardimi,
            this.colIzinYardimi,
            this.colPostaBasiTazminati,
            this.colSagSigIsvPayi,
            this.colBenzinYardimi,
            this.colOdulHediye,
            this.colHarcirah,
            this.colDigerYardimlar,
            this.colSgkPrimiIsciPayi,
            this.colIssizlikPrimiIsciPayi,
            this.colGelirVergisi,
            this.colDamgaVergisi,
            this.colSgkMatrahi,
            this.colSgkPrimiIsverenHissesi,
            this.colIsizlikPrimiIsverenHisessi,
            this.colSgkTesvikTutar,
            this.colSgkOdenecekIsverenHisessi,
            this.colDamgaVergisiMatrahi,
            this.colGelirVergisiMatrahi,
            this.colGelirVergisiIndirimi,
            this.colEkIndirim,
            this.colYillikGelirVergisiMatrahi,
            this.colYillikGelirVergisi,
            this.colSendikaAidati,
            this.colIcra,
            this.colCeza,
            this.colAvans,
            this.colTersBakiye,
            this.colAvans2,
            this.colAsgariGecimIndirimi,
            this.colNormalKazanc,
            this.colNetOdenen,
            this.colToplamOdenen,
            this.colGeceMesaisi,
            this.colGeceMesaisiNet,
            this.colGeceMesaisiTutar,
            this.colSec,
            this.colIscıMemur});
            this.gridView1.GridControl = this.grdBordro;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colBlSicil
            // 
            this.colBlSicil.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colBlSicil.AppearanceHeader.Options.UseFont = true;
            this.colBlSicil.AppearanceHeader.Options.UseTextOptions = true;
            this.colBlSicil.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBlSicil.FieldName = "BlSicil";
            this.colBlSicil.Name = "colBlSicil";
            this.colBlSicil.OptionsColumn.ReadOnly = true;
            this.colBlSicil.Visible = true;
            this.colBlSicil.VisibleIndex = 2;
            // 
            // colAdSoyad
            // 
            this.colAdSoyad.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colAdSoyad.AppearanceHeader.Options.UseFont = true;
            this.colAdSoyad.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdSoyad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdSoyad.FieldName = "AdSoyad";
            this.colAdSoyad.Name = "colAdSoyad";
            this.colAdSoyad.OptionsColumn.ReadOnly = true;
            this.colAdSoyad.Visible = true;
            this.colAdSoyad.VisibleIndex = 3;
            // 
            // colUcret
            // 
            this.colUcret.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUcret.AppearanceHeader.Options.UseFont = true;
            this.colUcret.AppearanceHeader.Options.UseTextOptions = true;
            this.colUcret.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUcret.FieldName = "Ucret";
            this.colUcret.Name = "colUcret";
            // 
            // colGirisTarihi
            // 
            this.colGirisTarihi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGirisTarihi.AppearanceHeader.Options.UseFont = true;
            this.colGirisTarihi.AppearanceHeader.Options.UseTextOptions = true;
            this.colGirisTarihi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGirisTarihi.FieldName = "GirisTarihi";
            this.colGirisTarihi.Name = "colGirisTarihi";
            this.colGirisTarihi.OptionsColumn.ReadOnly = true;
            // 
            // colTcNo
            // 
            this.colTcNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTcNo.AppearanceHeader.Options.UseFont = true;
            this.colTcNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colTcNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTcNo.FieldName = "TcNo";
            this.colTcNo.Name = "colTcNo";
            this.colTcNo.Visible = true;
            this.colTcNo.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colEmail.AppearanceHeader.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            // 
            // colSGKNo
            // 
            this.colSGKNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSGKNo.AppearanceHeader.Options.UseFont = true;
            this.colSGKNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSGKNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSGKNo.FieldName = "SGKNo";
            this.colSGKNo.Name = "colSGKNo";
            this.colSGKNo.Visible = true;
            this.colSGKNo.VisibleIndex = 5;
            // 
            // colCocukAdedi
            // 
            this.colCocukAdedi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colCocukAdedi.AppearanceHeader.Options.UseFont = true;
            this.colCocukAdedi.AppearanceHeader.Options.UseTextOptions = true;
            this.colCocukAdedi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCocukAdedi.FieldName = "CocukAdedi";
            this.colCocukAdedi.Name = "colCocukAdedi";
            // 
            // colSgkGun
            // 
            this.colSgkGun.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSgkGun.AppearanceHeader.Options.UseFont = true;
            this.colSgkGun.AppearanceHeader.Options.UseTextOptions = true;
            this.colSgkGun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSgkGun.FieldName = "SgkGun";
            this.colSgkGun.Name = "colSgkGun";
            // 
            // colNormalCalisma
            // 
            this.colNormalCalisma.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colNormalCalisma.AppearanceHeader.Options.UseFont = true;
            this.colNormalCalisma.AppearanceHeader.Options.UseTextOptions = true;
            this.colNormalCalisma.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNormalCalisma.FieldName = "NormalCalisma";
            this.colNormalCalisma.Name = "colNormalCalisma";
            // 
            // colHaftaTatili
            // 
            this.colHaftaTatili.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colHaftaTatili.AppearanceHeader.Options.UseFont = true;
            this.colHaftaTatili.AppearanceHeader.Options.UseTextOptions = true;
            this.colHaftaTatili.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHaftaTatili.FieldName = "HaftaTatili";
            this.colHaftaTatili.Name = "colHaftaTatili";
            // 
            // colGenelTatil
            // 
            this.colGenelTatil.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGenelTatil.AppearanceHeader.Options.UseFont = true;
            this.colGenelTatil.AppearanceHeader.Options.UseTextOptions = true;
            this.colGenelTatil.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGenelTatil.FieldName = "GenelTatil";
            this.colGenelTatil.Name = "colGenelTatil";
            // 
            // colUcretliIzin
            // 
            this.colUcretliIzin.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUcretliIzin.AppearanceHeader.Options.UseFont = true;
            this.colUcretliIzin.AppearanceHeader.Options.UseTextOptions = true;
            this.colUcretliIzin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUcretliIzin.FieldName = "UcretliIzin";
            this.colUcretliIzin.Name = "colUcretliIzin";
            // 
            // colYillikIzinGun
            // 
            this.colYillikIzinGun.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colYillikIzinGun.AppearanceHeader.Options.UseFont = true;
            this.colYillikIzinGun.AppearanceHeader.Options.UseTextOptions = true;
            this.colYillikIzinGun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYillikIzinGun.FieldName = "YillikIzinGun";
            this.colYillikIzinGun.Name = "colYillikIzinGun";
            this.colYillikIzinGun.OptionsColumn.ReadOnly = true;
            // 
            // colYillikIzinSaat
            // 
            this.colYillikIzinSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colYillikIzinSaat.AppearanceHeader.Options.UseFont = true;
            this.colYillikIzinSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colYillikIzinSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYillikIzinSaat.FieldName = "YillikIzinSaat";
            this.colYillikIzinSaat.Name = "colYillikIzinSaat";
            // 
            // colYillikIzinTutari
            // 
            this.colYillikIzinTutari.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colYillikIzinTutari.AppearanceHeader.Options.UseFont = true;
            this.colYillikIzinTutari.AppearanceHeader.Options.UseTextOptions = true;
            this.colYillikIzinTutari.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYillikIzinTutari.FieldName = "YillikIzinTutari";
            this.colYillikIzinTutari.Name = "colYillikIzinTutari";
            // 
            // colRaporsGun
            // 
            this.colRaporsGun.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colRaporsGun.AppearanceHeader.Options.UseFont = true;
            this.colRaporsGun.AppearanceHeader.Options.UseTextOptions = true;
            this.colRaporsGun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRaporsGun.FieldName = "RaporsGun";
            this.colRaporsGun.Name = "colRaporsGun";
            this.colRaporsGun.OptionsColumn.ReadOnly = true;
            // 
            // colRaporsSaat
            // 
            this.colRaporsSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colRaporsSaat.AppearanceHeader.Options.UseFont = true;
            this.colRaporsSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colRaporsSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRaporsSaat.FieldName = "RaporsSaat";
            this.colRaporsSaat.Name = "colRaporsSaat";
            // 
            // colRaporsTutar
            // 
            this.colRaporsTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colRaporsTutar.AppearanceHeader.Options.UseFont = true;
            this.colRaporsTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colRaporsTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRaporsTutar.FieldName = "RaporsTutar";
            this.colRaporsTutar.Name = "colRaporsTutar";
            // 
            // colUcretsizIzin
            // 
            this.colUcretsizIzin.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUcretsizIzin.AppearanceHeader.Options.UseFont = true;
            this.colUcretsizIzin.AppearanceHeader.Options.UseTextOptions = true;
            this.colUcretsizIzin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUcretsizIzin.FieldName = "UcretsizIzin";
            this.colUcretsizIzin.Name = "colUcretsizIzin";
            this.colUcretsizIzin.OptionsColumn.ReadOnly = true;
            // 
            // colUcretsizIzinSaat
            // 
            this.colUcretsizIzinSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUcretsizIzinSaat.AppearanceHeader.Options.UseFont = true;
            this.colUcretsizIzinSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colUcretsizIzinSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUcretsizIzinSaat.FieldName = "UcretsizIzinSaat";
            this.colUcretsizIzinSaat.Name = "colUcretsizIzinSaat";
            // 
            // colUcretsizIzinTutar
            // 
            this.colUcretsizIzinTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUcretsizIzinTutar.AppearanceHeader.Options.UseFont = true;
            this.colUcretsizIzinTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colUcretsizIzinTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUcretsizIzinTutar.FieldName = "UcretsizIzinTutar";
            this.colUcretsizIzinTutar.Name = "colUcretsizIzinTutar";
            // 
            // colNormalCalismaSaat
            // 
            this.colNormalCalismaSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colNormalCalismaSaat.AppearanceHeader.Options.UseFont = true;
            this.colNormalCalismaSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colNormalCalismaSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNormalCalismaSaat.FieldName = "NormalCalismaSaat";
            this.colNormalCalismaSaat.Name = "colNormalCalismaSaat";
            // 
            // colNormalCalismaTutar
            // 
            this.colNormalCalismaTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colNormalCalismaTutar.AppearanceHeader.Options.UseFont = true;
            this.colNormalCalismaTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colNormalCalismaTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNormalCalismaTutar.FieldName = "NormalCalismaTutar";
            this.colNormalCalismaTutar.Name = "colNormalCalismaTutar";
            // 
            // colHaftaTatiliSaat
            // 
            this.colHaftaTatiliSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colHaftaTatiliSaat.AppearanceHeader.Options.UseFont = true;
            this.colHaftaTatiliSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colHaftaTatiliSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHaftaTatiliSaat.FieldName = "HaftaTatiliSaat";
            this.colHaftaTatiliSaat.Name = "colHaftaTatiliSaat";
            // 
            // colHaftaTatiliTutar
            // 
            this.colHaftaTatiliTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colHaftaTatiliTutar.AppearanceHeader.Options.UseFont = true;
            this.colHaftaTatiliTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colHaftaTatiliTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHaftaTatiliTutar.FieldName = "HaftaTatiliTutar";
            this.colHaftaTatiliTutar.Name = "colHaftaTatiliTutar";
            // 
            // colGenelTatilSaat
            // 
            this.colGenelTatilSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGenelTatilSaat.AppearanceHeader.Options.UseFont = true;
            this.colGenelTatilSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colGenelTatilSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGenelTatilSaat.FieldName = "GenelTatilSaat";
            this.colGenelTatilSaat.Name = "colGenelTatilSaat";
            // 
            // colGenelTatilTutar
            // 
            this.colGenelTatilTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGenelTatilTutar.AppearanceHeader.Options.UseFont = true;
            this.colGenelTatilTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colGenelTatilTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGenelTatilTutar.FieldName = "GenelTatilTutar";
            this.colGenelTatilTutar.Name = "colGenelTatilTutar";
            // 
            // colUcretliIzinSaat
            // 
            this.colUcretliIzinSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUcretliIzinSaat.AppearanceHeader.Options.UseFont = true;
            this.colUcretliIzinSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colUcretliIzinSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUcretliIzinSaat.FieldName = "UcretliIzinSaat";
            this.colUcretliIzinSaat.Name = "colUcretliIzinSaat";
            // 
            // colUcretliIzinTutar
            // 
            this.colUcretliIzinTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUcretliIzinTutar.AppearanceHeader.Options.UseFont = true;
            this.colUcretliIzinTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colUcretliIzinTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUcretliIzinTutar.FieldName = "UcretliIzinTutar";
            this.colUcretliIzinTutar.Name = "colUcretliIzinTutar";
            // 
            // colTatilMesaisi
            // 
            this.colTatilMesaisi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTatilMesaisi.AppearanceHeader.Options.UseFont = true;
            this.colTatilMesaisi.AppearanceHeader.Options.UseTextOptions = true;
            this.colTatilMesaisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTatilMesaisi.FieldName = "TatilMesaisi";
            this.colTatilMesaisi.Name = "colTatilMesaisi";
            // 
            // colTatilMesaisiSaat
            // 
            this.colTatilMesaisiSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTatilMesaisiSaat.AppearanceHeader.Options.UseFont = true;
            this.colTatilMesaisiSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colTatilMesaisiSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTatilMesaisiSaat.FieldName = "TatilMesaisiSaat";
            this.colTatilMesaisiSaat.Name = "colTatilMesaisiSaat";
            // 
            // colTatilMesaisiTutar
            // 
            this.colTatilMesaisiTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTatilMesaisiTutar.AppearanceHeader.Options.UseFont = true;
            this.colTatilMesaisiTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colTatilMesaisiTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTatilMesaisiTutar.FieldName = "TatilMesaisiTutar";
            this.colTatilMesaisiTutar.Name = "colTatilMesaisiTutar";
            // 
            // colFazlaMesai
            // 
            this.colFazlaMesai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colFazlaMesai.AppearanceHeader.Options.UseFont = true;
            this.colFazlaMesai.AppearanceHeader.Options.UseTextOptions = true;
            this.colFazlaMesai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFazlaMesai.FieldName = "FazlaMesai";
            this.colFazlaMesai.Name = "colFazlaMesai";
            this.colFazlaMesai.OptionsColumn.ReadOnly = true;
            // 
            // colFazlaMesaiSaat
            // 
            this.colFazlaMesaiSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colFazlaMesaiSaat.AppearanceHeader.Options.UseFont = true;
            this.colFazlaMesaiSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colFazlaMesaiSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFazlaMesaiSaat.FieldName = "FazlaMesaiSaat";
            this.colFazlaMesaiSaat.Name = "colFazlaMesaiSaat";
            this.colFazlaMesaiSaat.OptionsColumn.ReadOnly = true;
            // 
            // colFazlaMesaiTutar
            // 
            this.colFazlaMesaiTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colFazlaMesaiTutar.AppearanceHeader.Options.UseFont = true;
            this.colFazlaMesaiTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colFazlaMesaiTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFazlaMesaiTutar.FieldName = "FazlaMesaiTutar";
            this.colFazlaMesaiTutar.Name = "colFazlaMesaiTutar";
            this.colFazlaMesaiTutar.OptionsColumn.ReadOnly = true;
            // 
            // colGeceVardiyasi
            // 
            this.colGeceVardiyasi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGeceVardiyasi.AppearanceHeader.Options.UseFont = true;
            this.colGeceVardiyasi.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeceVardiyasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeceVardiyasi.FieldName = "GeceVardiyasi";
            this.colGeceVardiyasi.Name = "colGeceVardiyasi";
            this.colGeceVardiyasi.OptionsColumn.ReadOnly = true;
            // 
            // colGeceVardiyasiSaat
            // 
            this.colGeceVardiyasiSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGeceVardiyasiSaat.AppearanceHeader.Options.UseFont = true;
            this.colGeceVardiyasiSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeceVardiyasiSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeceVardiyasiSaat.FieldName = "GeceVardiyasiSaat";
            this.colGeceVardiyasiSaat.Name = "colGeceVardiyasiSaat";
            // 
            // colGeceVardiyasiTutar
            // 
            this.colGeceVardiyasiTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGeceVardiyasiTutar.AppearanceHeader.Options.UseFont = true;
            this.colGeceVardiyasiTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeceVardiyasiTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeceVardiyasiTutar.FieldName = "GeceVardiyasiTutar";
            this.colGeceVardiyasiTutar.Name = "colGeceVardiyasiTutar";
            // 
            // colUcretliIzinGunSaat
            // 
            this.colUcretliIzinGunSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUcretliIzinGunSaat.AppearanceHeader.Options.UseFont = true;
            this.colUcretliIzinGunSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colUcretliIzinGunSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUcretliIzinGunSaat.FieldName = "UcretliIzinGunSaat";
            this.colUcretliIzinGunSaat.Name = "colUcretliIzinGunSaat";
            // 
            // colUcretliIzinSaat1
            // 
            this.colUcretliIzinSaat1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUcretliIzinSaat1.AppearanceHeader.Options.UseFont = true;
            this.colUcretliIzinSaat1.AppearanceHeader.Options.UseTextOptions = true;
            this.colUcretliIzinSaat1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUcretliIzinSaat1.FieldName = "UcretliIzinSaat1";
            this.colUcretliIzinSaat1.Name = "colUcretliIzinSaat1";
            // 
            // colUcretliIzinGunTutar
            // 
            this.colUcretliIzinGunTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUcretliIzinGunTutar.AppearanceHeader.Options.UseFont = true;
            this.colUcretliIzinGunTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colUcretliIzinGunTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUcretliIzinGunTutar.FieldName = "UcretliIzinGunTutar";
            this.colUcretliIzinGunTutar.Name = "colUcretliIzinGunTutar";
            // 
            // colEgitimGun
            // 
            this.colEgitimGun.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colEgitimGun.AppearanceHeader.Options.UseFont = true;
            this.colEgitimGun.AppearanceHeader.Options.UseTextOptions = true;
            this.colEgitimGun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEgitimGun.FieldName = "EgitimGun";
            this.colEgitimGun.Name = "colEgitimGun";
            // 
            // colEgitimSaat
            // 
            this.colEgitimSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colEgitimSaat.AppearanceHeader.Options.UseFont = true;
            this.colEgitimSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colEgitimSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEgitimSaat.FieldName = "EgitimSaat";
            this.colEgitimSaat.Name = "colEgitimSaat";
            // 
            // colEgitimTutar
            // 
            this.colEgitimTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colEgitimTutar.AppearanceHeader.Options.UseFont = true;
            this.colEgitimTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colEgitimTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEgitimTutar.FieldName = "EgitimTutar";
            this.colEgitimTutar.Name = "colEgitimTutar";
            // 
            // colRaporGunSaat
            // 
            this.colRaporGunSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colRaporGunSaat.AppearanceHeader.Options.UseFont = true;
            this.colRaporGunSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colRaporGunSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRaporGunSaat.FieldName = "RaporGunSaat";
            this.colRaporGunSaat.Name = "colRaporGunSaat";
            // 
            // colRaporSaat
            // 
            this.colRaporSaat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colRaporSaat.AppearanceHeader.Options.UseFont = true;
            this.colRaporSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colRaporSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRaporSaat.FieldName = "RaporSaat";
            this.colRaporSaat.Name = "colRaporSaat";
            // 
            // colRaporGunTutar
            // 
            this.colRaporGunTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colRaporGunTutar.AppearanceHeader.Options.UseFont = true;
            this.colRaporGunTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colRaporGunTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRaporGunTutar.FieldName = "RaporGunTutar";
            this.colRaporGunTutar.Name = "colRaporGunTutar";
            // 
            // colYemekYardimi
            // 
            this.colYemekYardimi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colYemekYardimi.AppearanceHeader.Options.UseFont = true;
            this.colYemekYardimi.AppearanceHeader.Options.UseTextOptions = true;
            this.colYemekYardimi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYemekYardimi.FieldName = "YemekYardimi";
            this.colYemekYardimi.Name = "colYemekYardimi";
            // 
            // colPerformansPirimi
            // 
            this.colPerformansPirimi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colPerformansPirimi.AppearanceHeader.Options.UseFont = true;
            this.colPerformansPirimi.AppearanceHeader.Options.UseTextOptions = true;
            this.colPerformansPirimi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPerformansPirimi.FieldName = "PerformansPirimi";
            this.colPerformansPirimi.Name = "colPerformansPirimi";
            // 
            // colIkramiye
            // 
            this.colIkramiye.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colIkramiye.AppearanceHeader.Options.UseFont = true;
            this.colIkramiye.AppearanceHeader.Options.UseTextOptions = true;
            this.colIkramiye.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIkramiye.FieldName = "Ikramiye";
            this.colIkramiye.Name = "colIkramiye";
            // 
            // colYillikIzinYardimi
            // 
            this.colYillikIzinYardimi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colYillikIzinYardimi.AppearanceHeader.Options.UseFont = true;
            this.colYillikIzinYardimi.AppearanceHeader.Options.UseTextOptions = true;
            this.colYillikIzinYardimi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYillikIzinYardimi.FieldName = "YillikIzinYardimi";
            this.colYillikIzinYardimi.Name = "colYillikIzinYardimi";
            // 
            // colYakacakYardimi
            // 
            this.colYakacakYardimi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colYakacakYardimi.AppearanceHeader.Options.UseFont = true;
            this.colYakacakYardimi.AppearanceHeader.Options.UseTextOptions = true;
            this.colYakacakYardimi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYakacakYardimi.FieldName = "YakacakYardimi";
            this.colYakacakYardimi.Name = "colYakacakYardimi";
            // 
            // colBayramYardimi
            // 
            this.colBayramYardimi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colBayramYardimi.AppearanceHeader.Options.UseFont = true;
            this.colBayramYardimi.AppearanceHeader.Options.UseTextOptions = true;
            this.colBayramYardimi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBayramYardimi.FieldName = "BayramYardimi";
            this.colBayramYardimi.Name = "colBayramYardimi";
            // 
            // colCocukYardimi
            // 
            this.colCocukYardimi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colCocukYardimi.AppearanceHeader.Options.UseFont = true;
            this.colCocukYardimi.AppearanceHeader.Options.UseTextOptions = true;
            this.colCocukYardimi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCocukYardimi.FieldName = "CocukYardimi";
            this.colCocukYardimi.Name = "colCocukYardimi";
            // 
            // colTahsilYardimi
            // 
            this.colTahsilYardimi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTahsilYardimi.AppearanceHeader.Options.UseFont = true;
            this.colTahsilYardimi.AppearanceHeader.Options.UseTextOptions = true;
            this.colTahsilYardimi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTahsilYardimi.FieldName = "TahsilYardimi";
            this.colTahsilYardimi.Name = "colTahsilYardimi";
            // 
            // colKasaTazminati
            // 
            this.colKasaTazminati.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colKasaTazminati.AppearanceHeader.Options.UseFont = true;
            this.colKasaTazminati.AppearanceHeader.Options.UseTextOptions = true;
            this.colKasaTazminati.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKasaTazminati.FieldName = "KasaTazminati";
            this.colKasaTazminati.Name = "colKasaTazminati";
            // 
            // colIhbarTazminati
            // 
            this.colIhbarTazminati.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colIhbarTazminati.AppearanceHeader.Options.UseFont = true;
            this.colIhbarTazminati.AppearanceHeader.Options.UseTextOptions = true;
            this.colIhbarTazminati.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIhbarTazminati.FieldName = "IhbarTazminati";
            this.colIhbarTazminati.Name = "colIhbarTazminati";
            // 
            // colKidemTazminati
            // 
            this.colKidemTazminati.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colKidemTazminati.AppearanceHeader.Options.UseFont = true;
            this.colKidemTazminati.AppearanceHeader.Options.UseTextOptions = true;
            this.colKidemTazminati.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKidemTazminati.FieldName = "KidemTazminati";
            this.colKidemTazminati.Name = "colKidemTazminati";
            // 
            // colAskerlikYardimi
            // 
            this.colAskerlikYardimi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colAskerlikYardimi.AppearanceHeader.Options.UseFont = true;
            this.colAskerlikYardimi.AppearanceHeader.Options.UseTextOptions = true;
            this.colAskerlikYardimi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAskerlikYardimi.FieldName = "AskerlikYardimi";
            this.colAskerlikYardimi.Name = "colAskerlikYardimi";
            // 
            // colIzinYardimi
            // 
            this.colIzinYardimi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colIzinYardimi.AppearanceHeader.Options.UseFont = true;
            this.colIzinYardimi.AppearanceHeader.Options.UseTextOptions = true;
            this.colIzinYardimi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIzinYardimi.FieldName = "IzinYardimi";
            this.colIzinYardimi.Name = "colIzinYardimi";
            // 
            // colPostaBasiTazminati
            // 
            this.colPostaBasiTazminati.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colPostaBasiTazminati.AppearanceHeader.Options.UseFont = true;
            this.colPostaBasiTazminati.AppearanceHeader.Options.UseTextOptions = true;
            this.colPostaBasiTazminati.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPostaBasiTazminati.FieldName = "PostaBasiTazminati";
            this.colPostaBasiTazminati.Name = "colPostaBasiTazminati";
            // 
            // colSagSigIsvPayi
            // 
            this.colSagSigIsvPayi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSagSigIsvPayi.AppearanceHeader.Options.UseFont = true;
            this.colSagSigIsvPayi.AppearanceHeader.Options.UseTextOptions = true;
            this.colSagSigIsvPayi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSagSigIsvPayi.FieldName = "SagSigIsvPayi";
            this.colSagSigIsvPayi.Name = "colSagSigIsvPayi";
            // 
            // colBenzinYardimi
            // 
            this.colBenzinYardimi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colBenzinYardimi.AppearanceHeader.Options.UseFont = true;
            this.colBenzinYardimi.AppearanceHeader.Options.UseTextOptions = true;
            this.colBenzinYardimi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBenzinYardimi.FieldName = "BenzinYardimi";
            this.colBenzinYardimi.Name = "colBenzinYardimi";
            // 
            // colOdulHediye
            // 
            this.colOdulHediye.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colOdulHediye.AppearanceHeader.Options.UseFont = true;
            this.colOdulHediye.AppearanceHeader.Options.UseTextOptions = true;
            this.colOdulHediye.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOdulHediye.FieldName = "OdulHediye";
            this.colOdulHediye.Name = "colOdulHediye";
            // 
            // colHarcirah
            // 
            this.colHarcirah.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colHarcirah.AppearanceHeader.Options.UseFont = true;
            this.colHarcirah.AppearanceHeader.Options.UseTextOptions = true;
            this.colHarcirah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHarcirah.FieldName = "Harcirah";
            this.colHarcirah.Name = "colHarcirah";
            // 
            // colDigerYardimlar
            // 
            this.colDigerYardimlar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colDigerYardimlar.AppearanceHeader.Options.UseFont = true;
            this.colDigerYardimlar.AppearanceHeader.Options.UseTextOptions = true;
            this.colDigerYardimlar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDigerYardimlar.FieldName = "DigerYardimlar";
            this.colDigerYardimlar.Name = "colDigerYardimlar";
            this.colDigerYardimlar.OptionsColumn.ReadOnly = true;
            // 
            // colSgkPrimiIsciPayi
            // 
            this.colSgkPrimiIsciPayi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSgkPrimiIsciPayi.AppearanceHeader.Options.UseFont = true;
            this.colSgkPrimiIsciPayi.AppearanceHeader.Options.UseTextOptions = true;
            this.colSgkPrimiIsciPayi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSgkPrimiIsciPayi.FieldName = "SgkPrimiIsciPayi";
            this.colSgkPrimiIsciPayi.Name = "colSgkPrimiIsciPayi";
            // 
            // colIssizlikPrimiIsciPayi
            // 
            this.colIssizlikPrimiIsciPayi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colIssizlikPrimiIsciPayi.AppearanceHeader.Options.UseFont = true;
            this.colIssizlikPrimiIsciPayi.AppearanceHeader.Options.UseTextOptions = true;
            this.colIssizlikPrimiIsciPayi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIssizlikPrimiIsciPayi.FieldName = "IssizlikPrimiIsciPayi";
            this.colIssizlikPrimiIsciPayi.Name = "colIssizlikPrimiIsciPayi";
            // 
            // colGelirVergisi
            // 
            this.colGelirVergisi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGelirVergisi.AppearanceHeader.Options.UseFont = true;
            this.colGelirVergisi.AppearanceHeader.Options.UseTextOptions = true;
            this.colGelirVergisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGelirVergisi.FieldName = "GelirVergisi";
            this.colGelirVergisi.Name = "colGelirVergisi";
            // 
            // colDamgaVergisi
            // 
            this.colDamgaVergisi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colDamgaVergisi.AppearanceHeader.Options.UseFont = true;
            this.colDamgaVergisi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDamgaVergisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDamgaVergisi.FieldName = "DamgaVergisi";
            this.colDamgaVergisi.Name = "colDamgaVergisi";
            // 
            // colSgkMatrahi
            // 
            this.colSgkMatrahi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSgkMatrahi.AppearanceHeader.Options.UseFont = true;
            this.colSgkMatrahi.AppearanceHeader.Options.UseTextOptions = true;
            this.colSgkMatrahi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSgkMatrahi.FieldName = "SgkMatrahi";
            this.colSgkMatrahi.Name = "colSgkMatrahi";
            // 
            // colSgkPrimiIsverenHissesi
            // 
            this.colSgkPrimiIsverenHissesi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSgkPrimiIsverenHissesi.AppearanceHeader.Options.UseFont = true;
            this.colSgkPrimiIsverenHissesi.AppearanceHeader.Options.UseTextOptions = true;
            this.colSgkPrimiIsverenHissesi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSgkPrimiIsverenHissesi.FieldName = "SgkPrimiIsverenHissesi";
            this.colSgkPrimiIsverenHissesi.Name = "colSgkPrimiIsverenHissesi";
            // 
            // colIsizlikPrimiIsverenHisessi
            // 
            this.colIsizlikPrimiIsverenHisessi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colIsizlikPrimiIsverenHisessi.AppearanceHeader.Options.UseFont = true;
            this.colIsizlikPrimiIsverenHisessi.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsizlikPrimiIsverenHisessi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsizlikPrimiIsverenHisessi.FieldName = "IsizlikPrimiIsverenHisessi";
            this.colIsizlikPrimiIsverenHisessi.Name = "colIsizlikPrimiIsverenHisessi";
            // 
            // colSgkTesvikTutar
            // 
            this.colSgkTesvikTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSgkTesvikTutar.AppearanceHeader.Options.UseFont = true;
            this.colSgkTesvikTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colSgkTesvikTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSgkTesvikTutar.FieldName = "SgkTesvikTutar";
            this.colSgkTesvikTutar.Name = "colSgkTesvikTutar";
            // 
            // colSgkOdenecekIsverenHisessi
            // 
            this.colSgkOdenecekIsverenHisessi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSgkOdenecekIsverenHisessi.AppearanceHeader.Options.UseFont = true;
            this.colSgkOdenecekIsverenHisessi.AppearanceHeader.Options.UseTextOptions = true;
            this.colSgkOdenecekIsverenHisessi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSgkOdenecekIsverenHisessi.FieldName = "SgkOdenecekIsverenHisessi";
            this.colSgkOdenecekIsverenHisessi.Name = "colSgkOdenecekIsverenHisessi";
            this.colSgkOdenecekIsverenHisessi.OptionsColumn.ReadOnly = true;
            // 
            // colDamgaVergisiMatrahi
            // 
            this.colDamgaVergisiMatrahi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colDamgaVergisiMatrahi.AppearanceHeader.Options.UseFont = true;
            this.colDamgaVergisiMatrahi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDamgaVergisiMatrahi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDamgaVergisiMatrahi.FieldName = "DamgaVergisiMatrahi";
            this.colDamgaVergisiMatrahi.Name = "colDamgaVergisiMatrahi";
            // 
            // colGelirVergisiMatrahi
            // 
            this.colGelirVergisiMatrahi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGelirVergisiMatrahi.AppearanceHeader.Options.UseFont = true;
            this.colGelirVergisiMatrahi.AppearanceHeader.Options.UseTextOptions = true;
            this.colGelirVergisiMatrahi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGelirVergisiMatrahi.FieldName = "GelirVergisiMatrahi";
            this.colGelirVergisiMatrahi.Name = "colGelirVergisiMatrahi";
            // 
            // colGelirVergisiIndirimi
            // 
            this.colGelirVergisiIndirimi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGelirVergisiIndirimi.AppearanceHeader.Options.UseFont = true;
            this.colGelirVergisiIndirimi.AppearanceHeader.Options.UseTextOptions = true;
            this.colGelirVergisiIndirimi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGelirVergisiIndirimi.FieldName = "GelirVergisiIndirimi";
            this.colGelirVergisiIndirimi.Name = "colGelirVergisiIndirimi";
            // 
            // colEkIndirim
            // 
            this.colEkIndirim.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colEkIndirim.AppearanceHeader.Options.UseFont = true;
            this.colEkIndirim.AppearanceHeader.Options.UseTextOptions = true;
            this.colEkIndirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEkIndirim.FieldName = "EkIndirim";
            this.colEkIndirim.Name = "colEkIndirim";
            this.colEkIndirim.OptionsColumn.ReadOnly = true;
            // 
            // colYillikGelirVergisiMatrahi
            // 
            this.colYillikGelirVergisiMatrahi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colYillikGelirVergisiMatrahi.AppearanceHeader.Options.UseFont = true;
            this.colYillikGelirVergisiMatrahi.AppearanceHeader.Options.UseTextOptions = true;
            this.colYillikGelirVergisiMatrahi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYillikGelirVergisiMatrahi.FieldName = "YillikGelirVergisiMatrahi";
            this.colYillikGelirVergisiMatrahi.Name = "colYillikGelirVergisiMatrahi";
            this.colYillikGelirVergisiMatrahi.OptionsColumn.ReadOnly = true;
            // 
            // colYillikGelirVergisi
            // 
            this.colYillikGelirVergisi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colYillikGelirVergisi.AppearanceHeader.Options.UseFont = true;
            this.colYillikGelirVergisi.AppearanceHeader.Options.UseTextOptions = true;
            this.colYillikGelirVergisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYillikGelirVergisi.FieldName = "YillikGelirVergisi";
            this.colYillikGelirVergisi.Name = "colYillikGelirVergisi";
            this.colYillikGelirVergisi.OptionsColumn.ReadOnly = true;
            // 
            // colSendikaAidati
            // 
            this.colSendikaAidati.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSendikaAidati.AppearanceHeader.Options.UseFont = true;
            this.colSendikaAidati.AppearanceHeader.Options.UseTextOptions = true;
            this.colSendikaAidati.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSendikaAidati.FieldName = "SendikaAidati";
            this.colSendikaAidati.Name = "colSendikaAidati";
            // 
            // colIcra
            // 
            this.colIcra.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colIcra.AppearanceHeader.Options.UseFont = true;
            this.colIcra.AppearanceHeader.Options.UseTextOptions = true;
            this.colIcra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIcra.FieldName = "Icra";
            this.colIcra.Name = "colIcra";
            // 
            // colCeza
            // 
            this.colCeza.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colCeza.AppearanceHeader.Options.UseFont = true;
            this.colCeza.AppearanceHeader.Options.UseTextOptions = true;
            this.colCeza.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCeza.FieldName = "Ceza";
            this.colCeza.Name = "colCeza";
            // 
            // colAvans
            // 
            this.colAvans.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colAvans.AppearanceHeader.Options.UseFont = true;
            this.colAvans.AppearanceHeader.Options.UseTextOptions = true;
            this.colAvans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAvans.FieldName = "Avans";
            this.colAvans.Name = "colAvans";
            this.colAvans.OptionsColumn.ReadOnly = true;
            // 
            // colTersBakiye
            // 
            this.colTersBakiye.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTersBakiye.AppearanceHeader.Options.UseFont = true;
            this.colTersBakiye.AppearanceHeader.Options.UseTextOptions = true;
            this.colTersBakiye.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTersBakiye.FieldName = "TersBakiye";
            this.colTersBakiye.Name = "colTersBakiye";
            // 
            // colAvans2
            // 
            this.colAvans2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colAvans2.AppearanceHeader.Options.UseFont = true;
            this.colAvans2.AppearanceHeader.Options.UseTextOptions = true;
            this.colAvans2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAvans2.FieldName = "Avans2";
            this.colAvans2.Name = "colAvans2";
            // 
            // colAsgariGecimIndirimi
            // 
            this.colAsgariGecimIndirimi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colAsgariGecimIndirimi.AppearanceHeader.Options.UseFont = true;
            this.colAsgariGecimIndirimi.AppearanceHeader.Options.UseTextOptions = true;
            this.colAsgariGecimIndirimi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAsgariGecimIndirimi.FieldName = "AsgariGecimIndirimi";
            this.colAsgariGecimIndirimi.Name = "colAsgariGecimIndirimi";
            // 
            // colNormalKazanc
            // 
            this.colNormalKazanc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colNormalKazanc.AppearanceHeader.Options.UseFont = true;
            this.colNormalKazanc.AppearanceHeader.Options.UseTextOptions = true;
            this.colNormalKazanc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNormalKazanc.FieldName = "NormalKazanc";
            this.colNormalKazanc.Name = "colNormalKazanc";
            this.colNormalKazanc.OptionsColumn.ReadOnly = true;
            // 
            // colNetOdenen
            // 
            this.colNetOdenen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colNetOdenen.AppearanceHeader.Options.UseFont = true;
            this.colNetOdenen.AppearanceHeader.Options.UseTextOptions = true;
            this.colNetOdenen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNetOdenen.FieldName = "NetOdenen";
            this.colNetOdenen.Name = "colNetOdenen";
            // 
            // colToplamOdenen
            // 
            this.colToplamOdenen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colToplamOdenen.AppearanceHeader.Options.UseFont = true;
            this.colToplamOdenen.AppearanceHeader.Options.UseTextOptions = true;
            this.colToplamOdenen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colToplamOdenen.FieldName = "ToplamOdenen";
            this.colToplamOdenen.Name = "colToplamOdenen";
            this.colToplamOdenen.OptionsColumn.ReadOnly = true;
            // 
            // colGeceMesaisi
            // 
            this.colGeceMesaisi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGeceMesaisi.AppearanceHeader.Options.UseFont = true;
            this.colGeceMesaisi.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeceMesaisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeceMesaisi.FieldName = "GeceMesaisi";
            this.colGeceMesaisi.Name = "colGeceMesaisi";
            // 
            // colGeceMesaisiNet
            // 
            this.colGeceMesaisiNet.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGeceMesaisiNet.AppearanceHeader.Options.UseFont = true;
            this.colGeceMesaisiNet.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeceMesaisiNet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeceMesaisiNet.FieldName = "GeceMesaisiNet";
            this.colGeceMesaisiNet.Name = "colGeceMesaisiNet";
            // 
            // colGeceMesaisiTutar
            // 
            this.colGeceMesaisiTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGeceMesaisiTutar.AppearanceHeader.Options.UseFont = true;
            this.colGeceMesaisiTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeceMesaisiTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeceMesaisiTutar.FieldName = "GeceMesaisiTutar";
            this.colGeceMesaisiTutar.Name = "colGeceMesaisiTutar";
            // 
            // colSec
            // 
            this.colSec.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSec.AppearanceHeader.Options.UseFont = true;
            this.colSec.AppearanceHeader.Options.UseTextOptions = true;
            this.colSec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSec.FieldName = "Sec";
            this.colSec.Name = "colSec";
            this.colSec.Visible = true;
            this.colSec.VisibleIndex = 0;
            // 
            // colIscıMemur
            // 
            this.colIscıMemur.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colIscıMemur.AppearanceHeader.Options.UseFont = true;
            this.colIscıMemur.AppearanceHeader.Options.UseTextOptions = true;
            this.colIscıMemur.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIscıMemur.FieldName = "IscıMemur";
            this.colIscıMemur.Name = "colIscıMemur";
            this.colIscıMemur.OptionsColumn.ReadOnly = true;
            this.colIscıMemur.Visible = true;
            this.colIscıMemur.VisibleIndex = 1;
            // 
            // emailDurumuTableAdapter1
            // 
            this.emailDurumuTableAdapter1.ClearBeforeFill = true;
            // 
            // bordlariGetirTableAdapter
            // 
            this.bordlariGetirTableAdapter.ClearBeforeFill = true;
            // 
            // BordroHazirlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BordroHazirlama";
            this.Text = "Bordro Hazırlama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BordroHazirlama_FormClosing);
            this.Load += new System.EventHandler(this.BordroHazirlama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prBordrolar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBordroAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBordroTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBordroYil.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBordro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bordlariGetirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBordrolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnBordroOlustur;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBordroYil;
        private System.Windows.Forms.Label lblBordroNo;
        private System.Windows.Forms.Label lblBordroAy;
        private System.Windows.Forms.Label lblBordroYil;
        private System.Windows.Forms.TextBox txtBordroNo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBordroAy;
        private DevExpress.XtraEditors.SimpleButton btnEmailAyarla;
        private DevExpress.XtraEditors.SimpleButton btnBordroGetir;
        private DevExpress.XtraEditors.SimpleButton btnBordrolariGonder;
        private DevExpress.XtraGrid.GridControl grdBordro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsBordrolar dsBordrolar;
        private dsBordrolarTableAdapters.EmailAdresKontrolu emailAdresKontrolu1;
        private dsBordrolarTableAdapters.EmailDurumuTableAdapter emailDurumuTableAdapter1;
        private DevExpress.XtraEditors.SimpleButton btnHepsiniKaldir;
        private DevExpress.XtraEditors.SimpleButton btnHepsiniSec;
        private System.Windows.Forms.ComboBox cmbSirketKodlari;
        private System.Windows.Forms.Label lblSirketKodlari;
        private System.Windows.Forms.BindingSource bordlariGetirBindingSource;
        private dsBordrolarTableAdapters.BordlariGetirTableAdapter bordlariGetirTableAdapter;
        private System.Windows.Forms.TextBox txtBanka;
        private System.Windows.Forms.Label lblBanka;
        private DevExpress.XtraEditors.ProgressBarControl prBordrolar;
        private DevExpress.XtraGrid.Columns.GridColumn colBlSicil;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colUcret;
        private DevExpress.XtraGrid.Columns.GridColumn colGirisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colTcNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSGKNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCocukAdedi;
        private DevExpress.XtraGrid.Columns.GridColumn colSgkGun;
        private DevExpress.XtraGrid.Columns.GridColumn colNormalCalisma;
        private DevExpress.XtraGrid.Columns.GridColumn colHaftaTatili;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelTatil;
        private DevExpress.XtraGrid.Columns.GridColumn colUcretliIzin;
        private DevExpress.XtraGrid.Columns.GridColumn colYillikIzinGun;
        private DevExpress.XtraGrid.Columns.GridColumn colYillikIzinSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colYillikIzinTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colRaporsGun;
        private DevExpress.XtraGrid.Columns.GridColumn colRaporsSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colRaporsTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colUcretsizIzin;
        private DevExpress.XtraGrid.Columns.GridColumn colUcretsizIzinSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colUcretsizIzinTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colNormalCalismaSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colNormalCalismaTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colHaftaTatiliSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colHaftaTatiliTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelTatilSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelTatilTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colUcretliIzinSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colUcretliIzinTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colTatilMesaisi;
        private DevExpress.XtraGrid.Columns.GridColumn colTatilMesaisiSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colTatilMesaisiTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colFazlaMesai;
        private DevExpress.XtraGrid.Columns.GridColumn colFazlaMesaiSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colFazlaMesaiTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colGeceVardiyasi;
        private DevExpress.XtraGrid.Columns.GridColumn colGeceVardiyasiSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colGeceVardiyasiTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colUcretliIzinGunSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colUcretliIzinSaat1;
        private DevExpress.XtraGrid.Columns.GridColumn colUcretliIzinGunTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colEgitimGun;
        private DevExpress.XtraGrid.Columns.GridColumn colEgitimSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colEgitimTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colRaporGunSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colRaporSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colRaporGunTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colYemekYardimi;
        private DevExpress.XtraGrid.Columns.GridColumn colPerformansPirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colIkramiye;
        private DevExpress.XtraGrid.Columns.GridColumn colYillikIzinYardimi;
        private DevExpress.XtraGrid.Columns.GridColumn colYakacakYardimi;
        private DevExpress.XtraGrid.Columns.GridColumn colBayramYardimi;
        private DevExpress.XtraGrid.Columns.GridColumn colCocukYardimi;
        private DevExpress.XtraGrid.Columns.GridColumn colTahsilYardimi;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaTazminati;
        private DevExpress.XtraGrid.Columns.GridColumn colIhbarTazminati;
        private DevExpress.XtraGrid.Columns.GridColumn colKidemTazminati;
        private DevExpress.XtraGrid.Columns.GridColumn colAskerlikYardimi;
        private DevExpress.XtraGrid.Columns.GridColumn colIzinYardimi;
        private DevExpress.XtraGrid.Columns.GridColumn colPostaBasiTazminati;
        private DevExpress.XtraGrid.Columns.GridColumn colSagSigIsvPayi;
        private DevExpress.XtraGrid.Columns.GridColumn colBenzinYardimi;
        private DevExpress.XtraGrid.Columns.GridColumn colOdulHediye;
        private DevExpress.XtraGrid.Columns.GridColumn colHarcirah;
        private DevExpress.XtraGrid.Columns.GridColumn colDigerYardimlar;
        private DevExpress.XtraGrid.Columns.GridColumn colSgkPrimiIsciPayi;
        private DevExpress.XtraGrid.Columns.GridColumn colIssizlikPrimiIsciPayi;
        private DevExpress.XtraGrid.Columns.GridColumn colGelirVergisi;
        private DevExpress.XtraGrid.Columns.GridColumn colDamgaVergisi;
        private DevExpress.XtraGrid.Columns.GridColumn colSgkMatrahi;
        private DevExpress.XtraGrid.Columns.GridColumn colSgkPrimiIsverenHissesi;
        private DevExpress.XtraGrid.Columns.GridColumn colIsizlikPrimiIsverenHisessi;
        private DevExpress.XtraGrid.Columns.GridColumn colSgkTesvikTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colSgkOdenecekIsverenHisessi;
        private DevExpress.XtraGrid.Columns.GridColumn colDamgaVergisiMatrahi;
        private DevExpress.XtraGrid.Columns.GridColumn colGelirVergisiMatrahi;
        private DevExpress.XtraGrid.Columns.GridColumn colGelirVergisiIndirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colEkIndirim;
        private DevExpress.XtraGrid.Columns.GridColumn colYillikGelirVergisiMatrahi;
        private DevExpress.XtraGrid.Columns.GridColumn colYillikGelirVergisi;
        private DevExpress.XtraGrid.Columns.GridColumn colSendikaAidati;
        private DevExpress.XtraGrid.Columns.GridColumn colIcra;
        private DevExpress.XtraGrid.Columns.GridColumn colCeza;
        private DevExpress.XtraGrid.Columns.GridColumn colAvans;
        private DevExpress.XtraGrid.Columns.GridColumn colTersBakiye;
        private DevExpress.XtraGrid.Columns.GridColumn colAvans2;
        private DevExpress.XtraGrid.Columns.GridColumn colAsgariGecimIndirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colNormalKazanc;
        private DevExpress.XtraGrid.Columns.GridColumn colNetOdenen;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamOdenen;
        private DevExpress.XtraGrid.Columns.GridColumn colGeceMesaisi;
        private DevExpress.XtraGrid.Columns.GridColumn colGeceMesaisiNet;
        private DevExpress.XtraGrid.Columns.GridColumn colGeceMesaisiTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colSec;
        private DevExpress.XtraGrid.Columns.GridColumn colIscıMemur;
        private DevExpress.XtraEditors.SimpleButton btnBordroDurdur;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBordroTipi;
        private System.Windows.Forms.Label lblBordroTip;
    }
}