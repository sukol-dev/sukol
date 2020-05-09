using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sukol.KullaniciEkleme
{
    public partial class OgrenciEkle : UserControl
    {
        public OgrenciEkle()
        {
            InitializeComponent();
            cb_sinif.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
