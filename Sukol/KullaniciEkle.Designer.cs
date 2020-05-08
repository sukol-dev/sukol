namespace Sukol
{
    partial class KullaniciEkle
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
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.checkBox_gorevli = new System.Windows.Forms.CheckBox();
            this.checkBox_ogretmen = new System.Windows.Forms.CheckBox();
            this.checkBox_ogrenci = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(309, 15);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(150, 20);
            this.textBox_kullaniciAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(309, 48);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(150, 20);
            this.textBox_sifre.TabIndex = 3;
            // 
            // checkBox_gorevli
            // 
            this.checkBox_gorevli.AutoSize = true;
            this.checkBox_gorevli.Location = new System.Drawing.Point(13, 21);
            this.checkBox_gorevli.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.checkBox_gorevli.Name = "checkBox_gorevli";
            this.checkBox_gorevli.Size = new System.Drawing.Size(59, 17);
            this.checkBox_gorevli.TabIndex = 4;
            this.checkBox_gorevli.Text = "Görevli";
            this.checkBox_gorevli.UseVisualStyleBackColor = true;
            // 
            // checkBox_ogretmen
            // 
            this.checkBox_ogretmen.AutoSize = true;
            this.checkBox_ogretmen.Location = new System.Drawing.Point(13, 48);
            this.checkBox_ogretmen.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.checkBox_ogretmen.Name = "checkBox_ogretmen";
            this.checkBox_ogretmen.Size = new System.Drawing.Size(72, 17);
            this.checkBox_ogretmen.TabIndex = 5;
            this.checkBox_ogretmen.Text = "Öğretmen";
            this.checkBox_ogretmen.UseVisualStyleBackColor = true;
            // 
            // checkBox_ogrenci
            // 
            this.checkBox_ogrenci.AutoSize = true;
            this.checkBox_ogrenci.Location = new System.Drawing.Point(13, 75);
            this.checkBox_ogrenci.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.checkBox_ogrenci.Name = "checkBox_ogrenci";
            this.checkBox_ogrenci.Size = new System.Drawing.Size(63, 17);
            this.checkBox_ogrenci.TabIndex = 6;
            this.checkBox_ogrenci.Text = "Öğrenci";
            this.checkBox_ogrenci.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_gorevli);
            this.groupBox1.Controls.Add(this.checkBox_ogrenci);
            this.groupBox1.Controls.Add(this.checkBox_ogretmen);
            this.groupBox1.Location = new System.Drawing.Point(235, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 108);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roller";
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(69, 48);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(150, 20);
            this.textBox_soyad.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ad";
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(69, 15);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(150, 20);
            this.textBox_ad.TabIndex = 8;
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(69, 79);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(150, 108);
            this.button_ekle.TabIndex = 12;
            this.button_ekle.Text = "Ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 220);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.textBox_soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_kullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KullaniciEkle";
            this.Text = "Kullanıcı Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.CheckBox checkBox_gorevli;
        private System.Windows.Forms.CheckBox checkBox_ogretmen;
        private System.Windows.Forms.CheckBox checkBox_ogrenci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Button button_ekle;
    }
}