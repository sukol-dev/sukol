using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sukol
{
    public partial class AboutWindow : Form
    {
        public AboutWindow(string producer, string appName, string version)
        {
            InitializeComponent();

            Text = "About " + appName;

            label1.Text = appName + "\n";
            label1.Text += producer + "\n";
            label1.Text += "Version:  " + version + "\n\n";
            label1.Text += "Warning: This computer program is not protected by copyright law.";

            ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
