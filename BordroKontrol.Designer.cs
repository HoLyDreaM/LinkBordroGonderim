namespace Bordro_Gonder
{
    partial class BordroKontrol
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
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.dtBitis = new DevExpress.XtraEditors.DateEdit();
            this.dtBaslangic = new DevExpress.XtraEditors.DateEdit();
            this.btnBordroGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnHatasizBordrolar = new DevExpress.XtraEditors.SimpleButton();
            this.btnHataliBordrolar = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdBordroKontrol = new DevExpress.XtraGrid.GridControl();
            this.dsBordrolar = new Bordro_Gonder.dsBordrolar();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTcNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmailAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMesaj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.emailAdresKontrolu1 = new Bordro_Gonder.dsBordrolarTableAdapters.EmailAdresKontrolu();
            this.emailDurumuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailDurumuTableAdapter = new Bordro_Gonder.dsBordrolarTableAdapters.EmailDurumuTableAdapter();
            this.colDosyaYolu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitis.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangic.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangic.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBordroKontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBordrolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailDurumuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBitisTarihi);
            this.panel1.Controls.Add(this.lblBaslangicTarihi);
            this.panel1.Controls.Add(this.dtBitis);
            this.panel1.Controls.Add(this.dtBaslangic);
            this.panel1.Controls.Add(this.btnBordroGonder);
            this.panel1.Controls.Add(this.btnHatasizBordrolar);
            this.panel1.Controls.Add(this.btnHataliBordrolar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 113);
            this.panel1.TabIndex = 0;
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.BackColor = System.Drawing.Color.Silver;
            this.lblBitisTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBitisTarihi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitisTarihi.Location = new System.Drawing.Point(268, 18);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(97, 20);
            this.lblBitisTarihi.TabIndex = 60;
            this.lblBitisTarihi.Text = "Bitiş Tarihi";
            this.lblBitisTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.BackColor = System.Drawing.Color.Silver;
            this.lblBaslangicTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBaslangicTarihi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(12, 18);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(97, 20);
            this.lblBaslangicTarihi.TabIndex = 60;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi";
            this.lblBaslangicTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtBitis
            // 
            this.dtBitis.EditValue = new System.DateTime(2014, 4, 30, 13, 1, 8, 800);
            this.dtBitis.EnterMoveNextControl = true;
            this.dtBitis.Location = new System.Drawing.Point(365, 18);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBitis.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtBitis.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtBitis.Size = new System.Drawing.Size(149, 20);
            this.dtBitis.TabIndex = 8;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.EditValue = new System.DateTime(2014, 4, 30, 13, 1, 14, 964);
            this.dtBaslangic.EnterMoveNextControl = true;
            this.dtBaslangic.Location = new System.Drawing.Point(109, 18);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBaslangic.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtBaslangic.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtBaslangic.Size = new System.Drawing.Size(149, 20);
            this.dtBaslangic.TabIndex = 8;
            // 
            // btnBordroGonder
            // 
            this.btnBordroGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBordroGonder.Appearance.Options.UseFont = true;
            this.btnBordroGonder.Location = new System.Drawing.Point(360, 67);
            this.btnBordroGonder.Name = "btnBordroGonder";
            this.btnBordroGonder.Size = new System.Drawing.Size(155, 24);
            this.btnBordroGonder.TabIndex = 7;
            this.btnBordroGonder.Text = "&Bordrolari Gonder";
            this.btnBordroGonder.Click += new System.EventHandler(this.btnBordroGonder_Click);
            // 
            // btnHatasizBordrolar
            // 
            this.btnHatasizBordrolar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnHatasizBordrolar.Appearance.Options.UseFont = true;
            this.btnHatasizBordrolar.Location = new System.Drawing.Point(184, 67);
            this.btnHatasizBordrolar.Name = "btnHatasizBordrolar";
            this.btnHatasizBordrolar.Size = new System.Drawing.Size(155, 24);
            this.btnHatasizBordrolar.TabIndex = 2;
            this.btnHatasizBordrolar.Text = "&Hatasız Bordrolar";
            this.btnHatasizBordrolar.Click += new System.EventHandler(this.btnHatasizBordrolar_Click);
            // 
            // btnHataliBordrolar
            // 
            this.btnHataliBordrolar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnHataliBordrolar.Appearance.Options.UseFont = true;
            this.btnHataliBordrolar.Location = new System.Drawing.Point(12, 67);
            this.btnHataliBordrolar.Name = "btnHataliBordrolar";
            this.btnHataliBordrolar.Size = new System.Drawing.Size(155, 24);
            this.btnHataliBordrolar.TabIndex = 1;
            this.btnHataliBordrolar.Text = "&Hatalı Bordrolar";
            this.btnHataliBordrolar.Click += new System.EventHandler(this.btnHataliBordrolar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdBordroKontrol);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 358);
            this.panel2.TabIndex = 1;
            // 
            // grdBordroKontrol
            // 
            this.grdBordroKontrol.DataSource = this.emailDurumuBindingSource;
            this.grdBordroKontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBordroKontrol.Location = new System.Drawing.Point(0, 0);
            this.grdBordroKontrol.MainView = this.gridView1;
            this.grdBordroKontrol.Name = "grdBordroKontrol";
            this.grdBordroKontrol.Size = new System.Drawing.Size(904, 358);
            this.grdBordroKontrol.TabIndex = 0;
            this.grdBordroKontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsBordrolar
            // 
            this.dsBordrolar.DataSetName = "dsBordrolar";
            this.dsBordrolar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdSoyad,
            this.colTcNo,
            this.colEmailAdres,
            this.colMesaj,
            this.colTarih,
            this.colDosyaYolu,
            this.colDurum});
            this.gridView1.GridControl = this.grdBordroKontrol;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colAdSoyad
            // 
            this.colAdSoyad.AppearanceCell.Options.UseTextOptions = true;
            this.colAdSoyad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdSoyad.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colAdSoyad.AppearanceHeader.Options.UseFont = true;
            this.colAdSoyad.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdSoyad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdSoyad.Caption = "İsim Soyisim";
            this.colAdSoyad.FieldName = "AdSoyad";
            this.colAdSoyad.Name = "colAdSoyad";
            this.colAdSoyad.Visible = true;
            this.colAdSoyad.VisibleIndex = 0;
            // 
            // colTcNo
            // 
            this.colTcNo.AppearanceCell.Options.UseTextOptions = true;
            this.colTcNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTcNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTcNo.AppearanceHeader.Options.UseFont = true;
            this.colTcNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colTcNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTcNo.Caption = "Tc Kimlik Numarası";
            this.colTcNo.FieldName = "TcNo";
            this.colTcNo.Name = "colTcNo";
            this.colTcNo.Visible = true;
            this.colTcNo.VisibleIndex = 1;
            // 
            // colEmailAdres
            // 
            this.colEmailAdres.AppearanceCell.Options.UseTextOptions = true;
            this.colEmailAdres.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmailAdres.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colEmailAdres.AppearanceHeader.Options.UseFont = true;
            this.colEmailAdres.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmailAdres.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmailAdres.Caption = "E-Mail Adres";
            this.colEmailAdres.FieldName = "EmailAdres";
            this.colEmailAdres.Name = "colEmailAdres";
            this.colEmailAdres.Visible = true;
            this.colEmailAdres.VisibleIndex = 2;
            // 
            // colMesaj
            // 
            this.colMesaj.AppearanceCell.Options.UseTextOptions = true;
            this.colMesaj.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMesaj.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMesaj.AppearanceHeader.Options.UseFont = true;
            this.colMesaj.AppearanceHeader.Options.UseTextOptions = true;
            this.colMesaj.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMesaj.Caption = "Rapor Mesajı";
            this.colMesaj.FieldName = "Mesaj";
            this.colMesaj.Name = "colMesaj";
            this.colMesaj.Visible = true;
            this.colMesaj.VisibleIndex = 3;
            // 
            // colDurum
            // 
            this.colDurum.AppearanceCell.Options.UseTextOptions = true;
            this.colDurum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDurum.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDurum.AppearanceHeader.Options.UseFont = true;
            this.colDurum.AppearanceHeader.Options.UseTextOptions = true;
            this.colDurum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDurum.Caption = "Gönderim Durumu";
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 4;
            // 
            // emailDurumuBindingSource
            // 
            this.emailDurumuBindingSource.DataMember = "EmailDurumu";
            this.emailDurumuBindingSource.DataSource = this.dsBordrolar;
            // 
            // emailDurumuTableAdapter
            // 
            this.emailDurumuTableAdapter.ClearBeforeFill = true;
            // 
            // colDosyaYolu
            // 
            this.colDosyaYolu.AppearanceCell.Options.UseTextOptions = true;
            this.colDosyaYolu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDosyaYolu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDosyaYolu.AppearanceHeader.Options.UseFont = true;
            this.colDosyaYolu.AppearanceHeader.Options.UseTextOptions = true;
            this.colDosyaYolu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDosyaYolu.FieldName = "DosyaYolu";
            this.colDosyaYolu.Name = "colDosyaYolu";
            this.colDosyaYolu.Visible = true;
            this.colDosyaYolu.VisibleIndex = 5;
            // 
            // colTarih
            // 
            this.colTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTarih.AppearanceHeader.Options.UseFont = true;
            this.colTarih.AppearanceHeader.Options.UseTextOptions = true;
            this.colTarih.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 4;
            // 
            // BordroKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BordroKontrol";
            this.Text = "Bordro Gönderim Kontrolü";
            this.Load += new System.EventHandler(this.BordroKontrol_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtBitis.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangic.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangic.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBordroKontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBordrolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailDurumuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnBordroGonder;
        private DevExpress.XtraEditors.SimpleButton btnHatasizBordrolar;
        private DevExpress.XtraEditors.SimpleButton btnHataliBordrolar;
        private DevExpress.XtraGrid.GridControl grdBordroKontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsBordrolar dsBordrolar;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colTcNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colMesaj;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private dsBordrolarTableAdapters.EmailAdresKontrolu emailAdresKontrolu1;
        private DevExpress.XtraEditors.DateEdit dtBitis;
        private DevExpress.XtraEditors.DateEdit dtBaslangic;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.BindingSource emailDurumuBindingSource;
        private dsBordrolarTableAdapters.EmailDurumuTableAdapter emailDurumuTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colDosyaYolu;
    }
}