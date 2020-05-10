namespace Sukol
{
    partial class DuyuruPaneli
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
            this.tableLayout_main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_siniflar = new System.Windows.Forms.ComboBox();
            this.label_sinif = new System.Windows.Forms.Label();
            this.button_duyuruEkle = new System.Windows.Forms.Button();
            this.flowLayout_duyurular = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayout_main.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_main
            // 
            this.tableLayout_main.AutoSize = true;
            this.tableLayout_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayout_main.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayout_main.ColumnCount = 1;
            this.tableLayout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_main.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayout_main.Controls.Add(this.flowLayout_duyurular, 0, 1);
            this.tableLayout_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_main.Name = "tableLayout_main";
            this.tableLayout_main.RowCount = 2;
            this.tableLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout_main.Size = new System.Drawing.Size(494, 578);
            this.tableLayout_main.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.comboBox_siniflar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_sinif, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_duyuruEkle, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(490, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBox_siniflar
            // 
            this.comboBox_siniflar.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_siniflar.FormattingEnabled = true;
            this.comboBox_siniflar.Location = new System.Drawing.Point(46, 10);
            this.comboBox_siniflar.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_siniflar.Name = "comboBox_siniflar";
            this.comboBox_siniflar.Size = new System.Drawing.Size(180, 21);
            this.comboBox_siniflar.TabIndex = 5;
            this.comboBox_siniflar.SelectedIndexChanged += new System.EventHandler(this.comboBox_siniflar_SelectedIndexChanged);
            // 
            // label_sinif
            // 
            this.label_sinif.AutoSize = true;
            this.label_sinif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_sinif.Location = new System.Drawing.Point(3, 0);
            this.label_sinif.Name = "label_sinif";
            this.label_sinif.Size = new System.Drawing.Size(30, 40);
            this.label_sinif.TabIndex = 1;
            this.label_sinif.Text = "Sınıf";
            this.label_sinif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_duyuruEkle
            // 
            this.button_duyuruEkle.AutoSize = true;
            this.button_duyuruEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_duyuruEkle.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_duyuruEkle.Location = new System.Drawing.Point(386, 5);
            this.button_duyuruEkle.Margin = new System.Windows.Forms.Padding(5);
            this.button_duyuruEkle.Name = "button_duyuruEkle";
            this.button_duyuruEkle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button_duyuruEkle.Size = new System.Drawing.Size(99, 30);
            this.button_duyuruEkle.TabIndex = 0;
            this.button_duyuruEkle.Text = "Duyuru Ekle";
            this.button_duyuruEkle.UseVisualStyleBackColor = true;
            this.button_duyuruEkle.Click += new System.EventHandler(this.button_duyuruEkle_Click);
            // 
            // flowLayout_duyurular
            // 
            this.flowLayout_duyurular.AutoScroll = true;
            this.flowLayout_duyurular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayout_duyurular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout_duyurular.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayout_duyurular.Location = new System.Drawing.Point(12, 54);
            this.flowLayout_duyurular.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayout_duyurular.Name = "flowLayout_duyurular";
            this.flowLayout_duyurular.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayout_duyurular.Size = new System.Drawing.Size(470, 512);
            this.flowLayout_duyurular.TabIndex = 1;
            this.flowLayout_duyurular.WrapContents = false;
            // 
            // DuyuruPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(494, 578);
            this.Controls.Add(this.tableLayout_main);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "DuyuruPaneli";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Duyuru";
            this.Load += new System.EventHandler(this.DuyuruPaneli_Load);
            this.tableLayout_main.ResumeLayout(false);
            this.tableLayout_main.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_duyuruEkle;
        private System.Windows.Forms.Label label_sinif;
        private System.Windows.Forms.ComboBox comboBox_siniflar;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_duyurular;
    }
}