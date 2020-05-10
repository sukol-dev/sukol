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
        Random rnd = new Random();
        public AboutWindow(string producer, string appName, string version)
        {
            InitializeComponent();

            Text = "About " + appName;

            label1.Text = appName + "\n";
            label1.Text += producer + "\n";
            label1.Text += "Version:  " + version + "\n\n";
            label1.Text += "Warning: This computer program is not protected by copyright law.";

            timer1.Start();

            ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromKnownColor((KnownColor)rnd.Next(Enum.GetNames(typeof(KnownColor)).Length));

        }
    }
}
