using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sukol
{
    public partial class DuyuruItem : UserControl
    {
        string yazar;
        string metin;
        string tarih;

        public DuyuruItem(string yazar, string metin, string tarih)
        {
            InitializeComponent();

            this.yazar = yazar;
            this.metin = metin;
            this.tarih = tarih;

            label_yazar.Text = yazar;
            label_tarih.Text = tarih;
            tb_metin.Text = metin;
        }

        public DuyuruItem()
        {
            InitializeComponent();
        }
    }
}
