namespace Sukol.KullaniciEkleme
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
            this.label_kullaniciAdi = new System.Windows.Forms.Label();
            this.label_sifre = new System.Windows.Forms.Label();
            this.checkBox_gorevli = new System.Windows.Forms.CheckBox();
            this.checkBox_ogretmen = new System.Windows.Forms.CheckBox();
            this.checkBox_ogrenci = new System.Windows.Forms.CheckBox();
            this.group_roller = new System.Windows.Forms.GroupBox();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.label_soyad = new System.Windows.Forms.Label();
            this.label_ad = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.panel_rol_giris = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_kullanici_bilgileri = new System.Windows.Forms.Panel();
            this.maskedTextBox_sifre = new System.Windows.Forms.MaskedTextBox();
            this.group_roller.SuspendLayout();
            this.panel_kullanici_bilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(300, 3);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(150, 22);
            this.textBox_kullaniciAdi.TabIndex = 2;
            // 
            // label_kullaniciAdi
            // 
            this.label_kullaniciAdi.AutoSize = true;
            this.label_kullaniciAdi.Location = new System.Drawing.Point(223, 6);
            this.label_kullaniciAdi.Margin = new System.Windows.Forms.Padding(10);
            this.label_kullaniciAdi.Name = "label_kullaniciAdi";
            this.label_kullaniciAdi.Size = new System.Drawing.Size(70, 13);
            this.label_kullaniciAdi.TabIndex = 1;
            this.label_kullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // label_sifre
            // 
            this.label_sifre.AutoSize = true;
            this.label_sifre.Location = new System.Drawing.Point(263, 34);
            this.label_sifre.Margin = new System.Windows.Forms.Padding(10);
            this.label_sifre.Name = "label_sifre";
            this.label_sifre.Size = new System.Drawing.Size(30, 13);
            this.label_sifre.TabIndex = 2;
            this.label_sifre.Text = "Şifre";
            // 
            // checkBox_gorevli
            // 
            this.checkBox_gorevli.AutoSize = true;
            this.checkBox_gorevli.Location = new System.Drawing.Point(13, 21);
            this.checkBox_gorevli.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.checkBox_gorevli.Name = "checkBox_gorevli";
            this.checkBox_gorevli.Size = new System.Drawing.Size(62, 17);
            this.checkBox_gorevli.TabIndex = 4;
            this.checkBox_gorevli.Text = "Görevli";
            this.checkBox_gorevli.UseVisualStyleBackColor = true;
            this.checkBox_gorevli.CheckedChanged += new System.EventHandler(this.checkBox_gorevli_CheckedChanged);
            // 
            // checkBox_ogretmen
            // 
            this.checkBox_ogretmen.AutoSize = true;
            this.checkBox_ogretmen.Location = new System.Drawing.Point(13, 48);
            this.checkBox_ogretmen.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.checkBox_ogretmen.Name = "checkBox_ogretmen";
            this.checkBox_ogretmen.Size = new System.Drawing.Size(78, 17);
            this.checkBox_ogretmen.TabIndex = 5;
            this.checkBox_ogretmen.Text = "Öğretmen";
            this.checkBox_ogretmen.UseVisualStyleBackColor = true;
            this.checkBox_ogretmen.CheckedChanged += new System.EventHandler(this.checkBox_ogretmen_CheckedChanged);
            // 
            // checkBox_ogrenci
            // 
            this.checkBox_ogrenci.AutoSize = true;
            this.checkBox_ogrenci.Location = new System.Drawing.Point(13, 75);
            this.checkBox_ogrenci.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.checkBox_ogrenci.Name = "checkBox_ogrenci";
            this.checkBox_ogrenci.Size = new System.Drawing.Size(67, 17);
            this.checkBox_ogrenci.TabIndex = 6;
            this.checkBox_ogrenci.Text = "Öğrenci";
            this.checkBox_ogrenci.UseVisualStyleBackColor = true;
            this.checkBox_ogrenci.CheckedChanged += new System.EventHandler(this.checkBox_ogrenci_CheckedChanged);
            // 
            // group_roller
            // 
            this.group_roller.Controls.Add(this.checkBox_gorevli);
            this.group_roller.Controls.Add(this.checkBox_ogrenci);
            this.group_roller.Controls.Add(this.checkBox_ogretmen);
            this.group_roller.Location = new System.Drawing.Point(226, 70);
            this.group_roller.Name = "group_roller";
            this.group_roller.Size = new System.Drawing.Size(224, 108);
            this.group_roller.TabIndex = 7;
            this.group_roller.TabStop = false;
            this.group_roller.Text = "Roller";
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(60, 31);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(151, 22);
            this.textBox_soyad.TabIndex = 1;
            // 
            // label_soyad
            // 
            this.label_soyad.AutoSize = true;
            this.label_soyad.Location = new System.Drawing.Point(10, 34);
            this.label_soyad.Margin = new System.Windows.Forms.Padding(10);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(38, 13);
            this.label_soyad.TabIndex = 10;
            this.label_soyad.Text = "Soyad";
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Location = new System.Drawing.Point(27, 6);
            this.label_ad.Margin = new System.Windows.Forms.Padding(10);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(21, 13);
            this.label_ad.TabIndex = 9;
            this.label_ad.Text = "Ad";
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(60, 3);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(150, 22);
            this.textBox_ad.TabIndex = 0;
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(60, 79);
            this.button_ekle.Margin = new System.Windows.Forms.Padding(10);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(150, 92);
            this.button_ekle.TabIndex = 7;
            this.button_ekle.Text = "Ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_click);
            // 
            // panel_rol_giris
            // 
            this.panel_rol_giris.AutoSize = true;
            this.panel_rol_giris.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_rol_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel_rol_giris.Location = new System.Drawing.Point(12, 225);
            this.panel_rol_giris.Margin = new System.Windows.Forms.Padding(10);
            this.panel_rol_giris.Name = "panel_rol_giris";
            this.panel_rol_giris.Padding = new System.Windows.Forms.Padding(10);
            this.panel_rol_giris.Size = new System.Drawing.Size(20, 20);
            this.panel_rol_giris.TabIndex = 13;
            // 
            // panel_kullanici_bilgileri
            // 
            this.panel_kullanici_bilgileri.Controls.Add(this.maskedTextBox_sifre);
            this.panel_kullanici_bilgileri.Controls.Add(this.label_ad);
            this.panel_kullanici_bilgileri.Controls.Add(this.textBox_kullaniciAdi);
            this.panel_kullanici_bilgileri.Controls.Add(this.button_ekle);
            this.panel_kullanici_bilgileri.Controls.Add(this.label_kullaniciAdi);
            this.panel_kullanici_bilgileri.Controls.Add(this.textBox_soyad);
            this.panel_kullanici_bilgileri.Controls.Add(this.label_sifre);
            this.panel_kullanici_bilgileri.Controls.Add(this.label_soyad);
            this.panel_kullanici_bilgileri.Controls.Add(this.group_roller);
            this.panel_kullanici_bilgileri.Controls.Add(this.textBox_ad);
            this.panel_kullanici_bilgileri.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel_kullanici_bilgileri.Location = new System.Drawing.Point(12, 12);
            this.panel_kullanici_bilgileri.MinimumSize = new System.Drawing.Size(456, 200);
            this.panel_kullanici_bilgileri.Name = "panel_kullanici_bilgileri";
            this.panel_kullanici_bilgileri.Size = new System.Drawing.Size(456, 200);
            this.panel_kullanici_bilgileri.TabIndex = 14;
            // 
            // maskedTextBox_sifre
            // 
            this.maskedTextBox_sifre.Location = new System.Drawing.Point(300, 31);
            this.maskedTextBox_sifre.Name = "maskedTextBox_sifre";
            this.maskedTextBox_sifre.PasswordChar = '*';
            this.maskedTextBox_sifre.Size = new System.Drawing.Size(150, 22);
            this.maskedTextBox_sifre.TabIndex = 7;
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(480, 261);
            this.Controls.Add(this.panel_kullanici_bilgileri);
            this.Controls.Add(this.panel_rol_giris);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "KullaniciEkle";
            this.Text = "Kullanıcı Ekle";
            this.group_roller.ResumeLayout(false);
            this.group_roller.PerformLayout();
            this.panel_kullanici_bilgileri.ResumeLayout(false);
            this.panel_kullanici_bilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.Label label_kullaniciAdi;
        private System.Windows.Forms.Label label_sifre;
        private System.Windows.Forms.CheckBox checkBox_gorevli;
        private System.Windows.Forms.CheckBox checkBox_ogretmen;
        private System.Windows.Forms.CheckBox checkBox_ogrenci;
        private System.Windows.Forms.GroupBox group_roller;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.FlowLayoutPanel panel_rol_giris;
        private System.Windows.Forms.Panel panel_kullanici_bilgileri;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_sifre;
    }
}