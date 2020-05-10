namespace Sukol
{
    partial class FormGirisYap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_x = new System.Windows.Forms.Button();
            this.maskedTextBox_sifre = new System.Windows.Forms.MaskedTextBox();
            this.label_sifre = new System.Windows.Forms.Label();
            this.label_kullaniciAdi = new System.Windows.Forms.Label();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.button_giris = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button_x);
            this.panel1.Controls.Add(this.maskedTextBox_sifre);
            this.panel1.Controls.Add(this.label_sifre);
            this.panel1.Controls.Add(this.label_kullaniciAdi);
            this.panel1.Controls.Add(this.textBox_kullaniciAdi);
            this.panel1.Controls.Add(this.button_giris);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 714);
            this.panel1.TabIndex = 0;
            // 
            // button_x
            // 
            this.button_x.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_x.AutoSize = true;
            this.button_x.BackColor = System.Drawing.Color.Red;
            this.button_x.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_x.Location = new System.Drawing.Point(562, 374);
            this.button_x.Name = "button_x";
            this.button_x.Size = new System.Drawing.Size(75, 23);
            this.button_x.TabIndex = 6;
            this.button_x.Text = "X";
            this.button_x.UseVisualStyleBackColor = false;
            this.button_x.Click += new System.EventHandler(this.button_x_Click);
            // 
            // maskedTextBox_sifre
            // 
            this.maskedTextBox_sifre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskedTextBox_sifre.Location = new System.Drawing.Point(549, 319);
            this.maskedTextBox_sifre.Name = "maskedTextBox_sifre";
            this.maskedTextBox_sifre.PasswordChar = '*';
            this.maskedTextBox_sifre.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_sifre.TabIndex = 5;
            // 
            // label_sifre
            // 
            this.label_sifre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_sifre.AutoSize = true;
            this.label_sifre.Location = new System.Drawing.Point(482, 322);
            this.label_sifre.Name = "label_sifre";
            this.label_sifre.Size = new System.Drawing.Size(28, 13);
            this.label_sifre.TabIndex = 3;
            this.label_sifre.Text = "Şifre";
            // 
            // label_kullaniciAdi
            // 
            this.label_kullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_kullaniciAdi.AutoSize = true;
            this.label_kullaniciAdi.Location = new System.Drawing.Point(482, 292);
            this.label_kullaniciAdi.Name = "label_kullaniciAdi";
            this.label_kullaniciAdi.Size = new System.Drawing.Size(63, 13);
            this.label_kullaniciAdi.TabIndex = 2;
            this.label_kullaniciAdi.Text = "Kullanıcı adı";
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(549, 289);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.textBox_kullaniciAdi.TabIndex = 1;
            this.textBox_kullaniciAdi.Text = "tester";
            // 
            // button_giris
            // 
            this.button_giris.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_giris.AutoSize = true;
            this.button_giris.Location = new System.Drawing.Point(562, 345);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(75, 23);
            this.button_giris.TabIndex = 0;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // FormGirisYap
            // 
            this.AcceptButton = this.button_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 714);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGirisYap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisYap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GirisYap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.Label label_sifre;
        private System.Windows.Forms.Label label_kullaniciAdi;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_sifre;
        private System.Windows.Forms.Button button_x;
    }
}