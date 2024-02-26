namespace Bordro_Gonder
{
    partial class ParametreTanimlari
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtBankaBilgileri = new System.Windows.Forms.TextBox();
            this.lblBankaBilgileri = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtLogoAdresi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(152, 95);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(212, 23);
            this.btnKaydet.TabIndex = 65;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtBankaBilgileri
            // 
            this.txtBankaBilgileri.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankaBilgileri.Location = new System.Drawing.Point(152, 20);
            this.txtBankaBilgileri.Name = "txtBankaBilgileri";
            this.txtBankaBilgileri.Size = new System.Drawing.Size(212, 23);
            this.txtBankaBilgileri.TabIndex = 64;
            // 
            // lblBankaBilgileri
            // 
            this.lblBankaBilgileri.BackColor = System.Drawing.Color.Silver;
            this.lblBankaBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBankaBilgileri.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankaBilgileri.Location = new System.Drawing.Point(12, 20);
            this.lblBankaBilgileri.Name = "lblBankaBilgileri";
            this.lblBankaBilgileri.Size = new System.Drawing.Size(140, 23);
            this.lblBankaBilgileri.TabIndex = 63;
            this.lblBankaBilgileri.Text = "Banka Bilgileri";
            this.lblBankaBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.Silver;
            this.lblLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLogo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogo.Location = new System.Drawing.Point(12, 57);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(140, 23);
            this.lblLogo.TabIndex = 63;
            this.lblLogo.Text = "Logo Adresi";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLogoAdresi
            // 
            this.txtLogoAdresi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLogoAdresi.Location = new System.Drawing.Point(152, 57);
            this.txtLogoAdresi.Name = "txtLogoAdresi";
            this.txtLogoAdresi.Size = new System.Drawing.Size(212, 23);
            this.txtLogoAdresi.TabIndex = 64;
            // 
            // ParametreTanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 132);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtLogoAdresi);
            this.Controls.Add(this.txtBankaBilgileri);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblBankaBilgileri);
            this.Name = "ParametreTanimlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametre Tanımları";
            this.Load += new System.EventHandler(this.ParametreTanimlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtBankaBilgileri;
        private System.Windows.Forms.Label lblBankaBilgileri;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtLogoAdresi;
    }
}