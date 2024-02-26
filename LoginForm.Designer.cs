namespace Bordro_Gonder
{
    partial class LoginForm
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
            this.oto = new System.Windows.Forms.CheckBox();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSirketAdi = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSirket = new System.Windows.Forms.TextBox();
            this.lblServerAdi = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtBordroVeritabani = new System.Windows.Forms.TextBox();
            this.txtBordroKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtBordroSifre = new System.Windows.Forms.TextBox();
            this.lblBordroVeritabani = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // oto
            // 
            this.oto.AutoSize = true;
            this.oto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.oto.Location = new System.Drawing.Point(209, 343);
            this.oto.Name = "oto";
            this.oto.Size = new System.Drawing.Size(116, 18);
            this.oto.TabIndex = 5;
            this.oto.Text = "Otomatik Bağlan";
            this.oto.UseVisualStyleBackColor = true;
            // 
            // btnBaglan
            // 
            this.btnBaglan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.btnBaglan.Location = new System.Drawing.Point(129, 314);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(196, 23);
            this.btnBaglan.TabIndex = 6;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.BackColor = System.Drawing.Color.Silver;
            this.lblSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSifre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(12, 214);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(117, 20);
            this.lblSifre.TabIndex = 50;
            this.lblSifre.Text = "Şifre";
            this.lblSifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Silver;
            this.lblKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(12, 190);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(117, 20);
            this.lblKullaniciAdi.TabIndex = 51;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            this.lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSirketAdi
            // 
            this.lblSirketAdi.BackColor = System.Drawing.Color.Silver;
            this.lblSirketAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSirketAdi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSirketAdi.Location = new System.Drawing.Point(12, 167);
            this.lblSirketAdi.Name = "lblSirketAdi";
            this.lblSirketAdi.Size = new System.Drawing.Size(117, 20);
            this.lblSirketAdi.TabIndex = 52;
            this.lblSirketAdi.Text = "Şirket Adı";
            this.lblSirketAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(129, 213);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(196, 22);
            this.txtSifre.TabIndex = 4;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(129, 190);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(196, 22);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // txtSirket
            // 
            this.txtSirket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSirket.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.txtSirket.Location = new System.Drawing.Point(129, 167);
            this.txtSirket.Name = "txtSirket";
            this.txtSirket.Size = new System.Drawing.Size(196, 22);
            this.txtSirket.TabIndex = 2;
            // 
            // lblServerAdi
            // 
            this.lblServerAdi.BackColor = System.Drawing.Color.Silver;
            this.lblServerAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServerAdi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServerAdi.Location = new System.Drawing.Point(12, 144);
            this.lblServerAdi.Name = "lblServerAdi";
            this.lblServerAdi.Size = new System.Drawing.Size(117, 20);
            this.lblServerAdi.TabIndex = 53;
            this.lblServerAdi.Text = "Server Adı";
            this.lblServerAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtServer
            // 
            this.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.txtServer.Location = new System.Drawing.Point(129, 144);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(196, 22);
            this.txtServer.TabIndex = 1;
            // 
            // txtBordroVeritabani
            // 
            this.txtBordroVeritabani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBordroVeritabani.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.txtBordroVeritabani.Location = new System.Drawing.Point(129, 237);
            this.txtBordroVeritabani.Name = "txtBordroVeritabani";
            this.txtBordroVeritabani.Size = new System.Drawing.Size(196, 22);
            this.txtBordroVeritabani.TabIndex = 2;
            // 
            // txtBordroKullaniciAdi
            // 
            this.txtBordroKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBordroKullaniciAdi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.txtBordroKullaniciAdi.Location = new System.Drawing.Point(129, 260);
            this.txtBordroKullaniciAdi.Name = "txtBordroKullaniciAdi";
            this.txtBordroKullaniciAdi.Size = new System.Drawing.Size(196, 22);
            this.txtBordroKullaniciAdi.TabIndex = 3;
            // 
            // txtBordroSifre
            // 
            this.txtBordroSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBordroSifre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.txtBordroSifre.Location = new System.Drawing.Point(129, 283);
            this.txtBordroSifre.Name = "txtBordroSifre";
            this.txtBordroSifre.PasswordChar = '*';
            this.txtBordroSifre.Size = new System.Drawing.Size(196, 22);
            this.txtBordroSifre.TabIndex = 4;
            // 
            // lblBordroVeritabani
            // 
            this.lblBordroVeritabani.BackColor = System.Drawing.Color.Silver;
            this.lblBordroVeritabani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBordroVeritabani.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBordroVeritabani.Location = new System.Drawing.Point(12, 237);
            this.lblBordroVeritabani.Name = "lblBordroVeritabani";
            this.lblBordroVeritabani.Size = new System.Drawing.Size(117, 20);
            this.lblBordroVeritabani.TabIndex = 52;
            this.lblBordroVeritabani.Text = "Bordro Veritabanı";
            this.lblBordroVeritabani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Bordro Kullanıcı Adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Bordro Şifre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bordro_Gonder.Properties.Resources.djc_logo_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 371);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.oto);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblBordroVeritabani);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtBordroSifre);
            this.Controls.Add(this.lblSirketAdi);
            this.Controls.Add(this.txtBordroKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtBordroVeritabani);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSirket);
            this.Controls.Add(this.lblServerAdi);
            this.Controls.Add(this.txtServer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diniz Johnson Controls Giriş";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox oto;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSirketAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSirket;
        private System.Windows.Forms.Label lblServerAdi;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtBordroVeritabani;
        private System.Windows.Forms.TextBox txtBordroKullaniciAdi;
        private System.Windows.Forms.TextBox txtBordroSifre;
        private System.Windows.Forms.Label lblBordroVeritabani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}