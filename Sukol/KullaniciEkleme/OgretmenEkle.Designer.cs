namespace Sukol.KullaniciEkleme
{
    partial class OgretmenEkle
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
            this.group_ogretmen = new System.Windows.Forms.GroupBox();
            this.tb_sinif = new System.Windows.Forms.TextBox();
            this.label_sinif = new System.Windows.Forms.Label();
            this.group_ogretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_ogretmen
            // 
            this.group_ogretmen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.group_ogretmen.Controls.Add(this.tb_sinif);
            this.group_ogretmen.Controls.Add(this.label_sinif);
            this.group_ogretmen.Location = new System.Drawing.Point(3, 3);
            this.group_ogretmen.Name = "group_ogretmen";
            this.group_ogretmen.Size = new System.Drawing.Size(200, 100);
            this.group_ogretmen.TabIndex = 1;
            this.group_ogretmen.TabStop = false;
            this.group_ogretmen.Text = "Öğretmen Bilgileri";
            // 
            // tb_sinif
            // 
            this.tb_sinif.Location = new System.Drawing.Point(53, 23);
            this.tb_sinif.Name = "tb_sinif";
            this.tb_sinif.Size = new System.Drawing.Size(100, 20);
            this.tb_sinif.TabIndex = 1;
            // 
            // label_sinif
            // 
            this.label_sinif.AutoSize = true;
            this.label_sinif.Location = new System.Drawing.Point(13, 26);
            this.label_sinif.Margin = new System.Windows.Forms.Padding(10);
            this.label_sinif.Name = "label_sinif";
            this.label_sinif.Size = new System.Drawing.Size(27, 13);
            this.label_sinif.TabIndex = 0;
            this.label_sinif.Text = "Sınıf";
            // 
            // OgretmenEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.group_ogretmen);
            this.Name = "OgretmenEkle";
            this.Size = new System.Drawing.Size(206, 106);
            this.group_ogretmen.ResumeLayout(false);
            this.group_ogretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_ogretmen;
        private System.Windows.Forms.Label label_sinif;
        public System.Windows.Forms.TextBox tb_sinif;
    }
}
