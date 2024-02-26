namespace Bordro_Gonder
{
    partial class EMailAyarlari
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
            this.btnSina = new System.Windows.Forms.Button();
            this.lblGidenSunucuPortu = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblGidenSunucu = new System.Windows.Forms.Label();
            this.txtSunucu = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.sll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSina
            // 
            this.btnSina.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.btnSina.Location = new System.Drawing.Point(198, 148);
            this.btnSina.Name = "btnSina";
            this.btnSina.Size = new System.Drawing.Size(196, 23);
            this.btnSina.TabIndex = 6;
            this.btnSina.Text = "Hesap Ayarlarını Sına";
            this.btnSina.UseVisualStyleBackColor = true;
            this.btnSina.Click += new System.EventHandler(this.btnSina_Click);
            // 
            // lblGidenSunucuPortu
            // 
            this.lblGidenSunucuPortu.BackColor = System.Drawing.Color.Silver;
            this.lblGidenSunucuPortu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGidenSunucuPortu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGidenSunucuPortu.Location = new System.Drawing.Point(6, 45);
            this.lblGidenSunucuPortu.Name = "lblGidenSunucuPortu";
            this.lblGidenSunucuPortu.Size = new System.Drawing.Size(192, 20);
            this.lblGidenSunucuPortu.TabIndex = 57;
            this.lblGidenSunucuPortu.Text = "Giden Sunucu Portu";
            this.lblGidenSunucuPortu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.txtPort.Location = new System.Drawing.Point(198, 45);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(196, 22);
            this.txtPort.TabIndex = 2;
            // 
            // lblGidenSunucu
            // 
            this.lblGidenSunucu.BackColor = System.Drawing.Color.Silver;
            this.lblGidenSunucu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGidenSunucu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGidenSunucu.Location = new System.Drawing.Point(6, 21);
            this.lblGidenSunucu.Name = "lblGidenSunucu";
            this.lblGidenSunucu.Size = new System.Drawing.Size(192, 20);
            this.lblGidenSunucu.TabIndex = 58;
            this.lblGidenSunucu.Text = "Giden Posta Sunucusu (Smtp)";
            this.lblGidenSunucu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSunucu
            // 
            this.txtSunucu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSunucu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.txtSunucu.Location = new System.Drawing.Point(198, 20);
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Size = new System.Drawing.Size(196, 22);
            this.txtSunucu.TabIndex = 1;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Silver;
            this.lblKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(6, 71);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(192, 20);
            this.lblKullaniciAdi.TabIndex = 57;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            this.lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSifre
            // 
            this.lblSifre.BackColor = System.Drawing.Color.Silver;
            this.lblSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSifre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(6, 97);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(192, 20);
            this.lblSifre.TabIndex = 57;
            this.lblSifre.Text = "Şifre";
            this.lblSifre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKullanici
            // 
            this.txtKullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullanici.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.txtKullanici.Location = new System.Drawing.Point(198, 70);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(196, 22);
            this.txtKullanici.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(198, 97);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(196, 22);
            this.txtSifre.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(6, 177);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(388, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // sll
            // 
            this.sll.AutoSize = true;
            this.sll.Location = new System.Drawing.Point(198, 125);
            this.sll.Name = "sll";
            this.sll.Size = new System.Drawing.Size(46, 17);
            this.sll.TabIndex = 5;
            this.sll.Text = "SSL";
            this.sll.UseVisualStyleBackColor = true;
            // 
            // EMailAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 215);
            this.Controls.Add(this.sll);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSina);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblGidenSunucuPortu);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblGidenSunucu);
            this.Controls.Add(this.txtSunucu);
            this.Name = "EMailAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Mail Ayarları";
            this.Load += new System.EventHandler(this.EMailAyarlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSina;
        private System.Windows.Forms.Label lblGidenSunucuPortu;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblGidenSunucu;
        private System.Windows.Forms.TextBox txtSunucu;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox sll;
    }
}