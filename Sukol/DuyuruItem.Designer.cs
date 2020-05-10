namespace Sukol
{
    partial class DuyuruItem
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
            this.tableLayout_main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_yazar_tarih = new System.Windows.Forms.TableLayoutPanel();
            this.label_yazar = new System.Windows.Forms.Label();
            this.label_tarih = new System.Windows.Forms.Label();
            this.tb_metin = new System.Windows.Forms.RichTextBox();
            this.tableLayout_main.SuspendLayout();
            this.tableLayout_yazar_tarih.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_main
            // 
            this.tableLayout_main.AutoSize = true;
            this.tableLayout_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayout_main.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayout_main.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayout_main.ColumnCount = 1;
            this.tableLayout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_main.Controls.Add(this.tableLayout_yazar_tarih, 0, 0);
            this.tableLayout_main.Controls.Add(this.tb_metin, 0, 1);
            this.tableLayout_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_main.Name = "tableLayout_main";
            this.tableLayout_main.RowCount = 2;
            this.tableLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout_main.Size = new System.Drawing.Size(400, 200);
            this.tableLayout_main.TabIndex = 0;
            // 
            // tableLayout_yazar_tarih
            // 
            this.tableLayout_yazar_tarih.ColumnCount = 2;
            this.tableLayout_yazar_tarih.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_yazar_tarih.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_yazar_tarih.Controls.Add(this.label_yazar, 0, 0);
            this.tableLayout_yazar_tarih.Controls.Add(this.label_tarih, 1, 0);
            this.tableLayout_yazar_tarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_yazar_tarih.Location = new System.Drawing.Point(2, 2);
            this.tableLayout_yazar_tarih.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout_yazar_tarih.Name = "tableLayout_yazar_tarih";
            this.tableLayout_yazar_tarih.RowCount = 1;
            this.tableLayout_yazar_tarih.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_yazar_tarih.Size = new System.Drawing.Size(396, 20);
            this.tableLayout_yazar_tarih.TabIndex = 0;
            // 
            // label_yazar
            // 
            this.label_yazar.AutoSize = true;
            this.label_yazar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_yazar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_yazar.Location = new System.Drawing.Point(3, 3);
            this.label_yazar.Margin = new System.Windows.Forms.Padding(3);
            this.label_yazar.Name = "label_yazar";
            this.label_yazar.Size = new System.Drawing.Size(192, 14);
            this.label_yazar.TabIndex = 0;
            this.label_yazar.Text = "...";
            this.label_yazar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_tarih
            // 
            this.label_tarih.AutoSize = true;
            this.label_tarih.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_tarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tarih.Location = new System.Drawing.Point(201, 3);
            this.label_tarih.Margin = new System.Windows.Forms.Padding(3);
            this.label_tarih.Name = "label_tarih";
            this.label_tarih.Size = new System.Drawing.Size(192, 14);
            this.label_tarih.TabIndex = 1;
            this.label_tarih.Text = "...";
            this.label_tarih.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_metin
            // 
            this.tb_metin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_metin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_metin.Location = new System.Drawing.Point(2, 24);
            this.tb_metin.Margin = new System.Windows.Forms.Padding(0);
            this.tb_metin.MinimumSize = new System.Drawing.Size(20, 20);
            this.tb_metin.Name = "tb_metin";
            this.tb_metin.ReadOnly = true;
            this.tb_metin.Size = new System.Drawing.Size(396, 174);
            this.tb_metin.TabIndex = 1;
            this.tb_metin.Text = "";
            // 
            // DuyuruItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout_main);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "DuyuruItem";
            this.Size = new System.Drawing.Size(400, 200);
            this.tableLayout_main.ResumeLayout(false);
            this.tableLayout_yazar_tarih.ResumeLayout(false);
            this.tableLayout_yazar_tarih.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout_main;
        private System.Windows.Forms.TableLayoutPanel tableLayout_yazar_tarih;
        private System.Windows.Forms.Label label_yazar;
        private System.Windows.Forms.Label label_tarih;
        private System.Windows.Forms.RichTextBox tb_metin;
    }
}
