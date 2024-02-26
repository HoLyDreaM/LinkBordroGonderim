namespace Bordro_Gonder
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLoginAyari = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmailAyarlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnBordroHazirlama = new DevExpress.XtraBars.BarButtonItem();
            this.btnBordroKontrolu = new DevExpress.XtraBars.BarButtonItem();
            this.btnParametreBilgileri = new DevExpress.XtraBars.BarButtonItem();
            this.rbMenu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Login = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.BarMenuStilAyari = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSirketName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSirket = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKayanYazi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTarihAyari = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerTarih = new System.Windows.Forms.Timer(this.components);
            this.Koseicon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLoginAyari,
            this.btnGuncelle,
            this.btnEmailAyarlari,
            this.btnBordroHazirlama,
            this.btnBordroKontrolu,
            this.btnParametreBilgileri});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbMenu});
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(875, 140);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnLoginAyari
            // 
            this.btnLoginAyari.Caption = "Giriş Ayarı";
            this.btnLoginAyari.Id = 1;
            this.btnLoginAyari.LargeGlyph = global::Bordro_Gonder.Properties.Resources.login;
            this.btnLoginAyari.LargeWidth = 80;
            this.btnLoginAyari.Name = "btnLoginAyari";
            this.btnLoginAyari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoginAyari_ItemClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Id = 6;
            this.btnGuncelle.Name = "btnGuncelle";
            // 
            // btnEmailAyarlari
            // 
            this.btnEmailAyarlari.Caption = "E-Mail Ayarları";
            this.btnEmailAyarlari.Id = 3;
            this.btnEmailAyarlari.LargeGlyph = global::Bordro_Gonder.Properties.Resources.Email;
            this.btnEmailAyarlari.LargeWidth = 80;
            this.btnEmailAyarlari.Name = "btnEmailAyarlari";
            this.btnEmailAyarlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmailAyarlari_ItemClick);
            // 
            // btnBordroHazirlama
            // 
            this.btnBordroHazirlama.Caption = "Bordro Hazırlama";
            this.btnBordroHazirlama.Id = 4;
            this.btnBordroHazirlama.LargeGlyph = global::Bordro_Gonder.Properties.Resources.BordroHazirlama;
            this.btnBordroHazirlama.LargeWidth = 80;
            this.btnBordroHazirlama.Name = "btnBordroHazirlama";
            this.btnBordroHazirlama.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBordroHazirlama_ItemClick);
            // 
            // btnBordroKontrolu
            // 
            this.btnBordroKontrolu.Caption = "Bordro Kontrolü";
            this.btnBordroKontrolu.Id = 5;
            this.btnBordroKontrolu.LargeGlyph = global::Bordro_Gonder.Properties.Resources.BordroKontrol;
            this.btnBordroKontrolu.LargeWidth = 80;
            this.btnBordroKontrolu.Name = "btnBordroKontrolu";
            this.btnBordroKontrolu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBordroKontrolu_ItemClick);
            // 
            // btnParametreBilgileri
            // 
            this.btnParametreBilgileri.Caption = "Parametre Bilgileri";
            this.btnParametreBilgileri.Id = 7;
            this.btnParametreBilgileri.LargeGlyph = global::Bordro_Gonder.Properties.Resources.ParametreKontrol;
            this.btnParametreBilgileri.LargeWidth = 80;
            this.btnParametreBilgileri.Name = "btnParametreBilgileri";
            this.btnParametreBilgileri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnParametreBilgileri_ItemClick);
            // 
            // rbMenu
            // 
            this.rbMenu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Login,
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.rbMenu.Name = "rbMenu";
            this.rbMenu.Text = "Menü";
            // 
            // Login
            // 
            this.Login.ItemLinks.Add(this.btnLoginAyari);
            this.Login.Name = "Login";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEmailAyarlari);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBordroHazirlama);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBordroKontrolu);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnParametreBilgileri);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // BarMenuStilAyari
            // 
            this.BarMenuStilAyari.LookAndFeel.SkinName = "Office 2010 Silver";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(875, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 518);
            this.barDockControlBottom.Size = new System.Drawing.Size(875, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 518);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(875, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 518);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSirketName,
            this.lblSirket,
            this.lblKayanYazi,
            this.lblTarihAyari,
            this.lblTarih});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSirketName
            // 
            this.lblSirketName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSirketName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSirketName.Image = global::Bordro_Gonder.Properties.Resources.sirket;
            this.lblSirketName.Name = "lblSirketName";
            this.lblSirketName.Size = new System.Drawing.Size(63, 17);
            this.lblSirketName.Text = "Şirket :";
            // 
            // lblSirket
            // 
            this.lblSirket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSirket.Name = "lblSirket";
            this.lblSirket.Size = new System.Drawing.Size(0, 17);
            // 
            // lblKayanYazi
            // 
            this.lblKayanYazi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKayanYazi.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblKayanYazi.Name = "lblKayanYazi";
            this.lblKayanYazi.Size = new System.Drawing.Size(781, 17);
            this.lblKayanYazi.Spring = true;
            // 
            // lblTarihAyari
            // 
            this.lblTarihAyari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTarihAyari.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTarihAyari.Image = global::Bordro_Gonder.Properties.Resources.saat;
            this.lblTarihAyari.Name = "lblTarihAyari";
            this.lblTarihAyari.Size = new System.Drawing.Size(16, 17);
            // 
            // lblTarih
            // 
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 17);
            // 
            // timerTarih
            // 
            this.timerTarih.Enabled = true;
            this.timerTarih.Tick += new System.EventHandler(this.timerTarih_Tick);
            // 
            // Koseicon
            // 
            this.Koseicon.Icon = ((System.Drawing.Icon)(resources.GetObject("Koseicon.Icon")));
            this.Koseicon.Text = "Major Bordro Gönderim Programı";
            this.Koseicon.Visible = true;
            this.Koseicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Koseicon_MouseDoubleClick);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 539);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Diniz Johnson Controls Personel Bordroları Gönderme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.Resize += new System.EventHandler(this.AnaForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnLoginAyari;
        private DevExpress.XtraBars.BarButtonItem btnGuncelle;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Login;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblSirketName;
        public System.Windows.Forms.ToolStripStatusLabel lblSirket;
        private System.Windows.Forms.ToolStripStatusLabel lblKayanYazi;
        private System.Windows.Forms.ToolStripStatusLabel lblTarihAyari;
        private System.Windows.Forms.ToolStripStatusLabel lblTarih;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.LookAndFeel.DefaultLookAndFeel BarMenuStilAyari;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.Timer timerTarih;
        private DevExpress.XtraBars.BarButtonItem btnEmailAyarlari;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnBordroHazirlama;
        private DevExpress.XtraBars.BarButtonItem btnBordroKontrolu;
        private System.Windows.Forms.NotifyIcon Koseicon;
        private DevExpress.XtraBars.BarButtonItem btnParametreBilgileri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}

