namespace Sukol.KullaniciEkleme
{
    partial class OgrenciEkle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.group_ogrenci = new System.Windows.Forms.GroupBox();
            this.tb_no = new System.Windows.Forms.TextBox();
            this.label_no = new System.Windows.Forms.Label();
            this.label_sinif = new System.Windows.Forms.Label();
            this.cb_sinif = new System.Windows.Forms.ComboBox();
            this.group_ogrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_ogrenci
            // 
            this.group_ogrenci.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.group_ogrenci.Controls.Add(this.cb_sinif);
            this.group_ogrenci.Controls.Add(this.label_sinif);
            this.group_ogrenci.Controls.Add(this.tb_no);
            this.group_ogrenci.Controls.Add(this.label_no);
            this.group_ogrenci.Location = new System.Drawing.Point(3, 3);
            this.group_ogrenci.Name = "group_ogrenci";
            this.group_ogrenci.Size = new System.Drawing.Size(200, 100);
            this.group_ogrenci.TabIndex = 0;
            this.group_ogrenci.TabStop = false;
            this.group_ogrenci.Text = "Öğrenci Bilgileri";
            // 
            // tb_no
            // 
            this.tb_no.Location = new System.Drawing.Point(72, 23);
            this.tb_no.Name = "tb_no";
            this.tb_no.Size = new System.Drawing.Size(100, 20);
            this.tb_no.TabIndex = 1;
            // 
            // label_no
            // 
            this.label_no.AutoSize = true;
            this.label_no.Location = new System.Drawing.Point(13, 26);
            this.label_no.Margin = new System.Windows.Forms.Padding(10);
            this.label_no.Name = "label_no";
            this.label_no.Size = new System.Drawing.Size(46, 13);
            this.label_no.TabIndex = 0;
            this.label_no.Text = "Okul No";
            // 
            // label_sinif
            // 
            this.label_sinif.AutoSize = true;
            this.label_sinif.Location = new System.Drawing.Point(13, 52);
            this.label_sinif.Margin = new System.Windows.Forms.Padding(10);
            this.label_sinif.Name = "label_sinif";
            this.label_sinif.Size = new System.Drawing.Size(27, 13);
            this.label_sinif.TabIndex = 2;
            this.label_sinif.Text = "Sınıf";
            // 
            // cb_sinif
            // 
            this.cb_sinif.FormattingEnabled = true;
            this.cb_sinif.Location = new System.Drawing.Point(72, 49);
            this.cb_sinif.Name = "cb_sinif";
            this.cb_sinif.Size = new System.Drawing.Size(100, 21);
            this.cb_sinif.TabIndex = 4;
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.group_ogrenci);
            this.Name = "OgrenciEkle";
            this.Size = new System.Drawing.Size(206, 106);
            this.group_ogrenci.ResumeLayout(false);
            this.group_ogrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_ogrenci;
        private System.Windows.Forms.Label label_no;
        public System.Windows.Forms.TextBox tb_no;
        private System.Windows.Forms.Label label_sinif;
        public System.Windows.Forms.ComboBox cb_sinif;
    }
}
