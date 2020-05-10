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
    public partial class Loading : Form
    {
        int index;
        string[] txs;
        int cycle;
        int maxCycle;
        int cyclesToChangeText;

        public Loading(int saniye, string[] yazilar)
        {
            InitializeComponent();
            if (saniye == 0)
                return;

            txs = yazilar;
            timer1.Interval = 100;

            maxCycle = (1000 * saniye) / timer1.Interval;
            progressBar1.Step = progressBar1.Maximum / maxCycle;
            cycle = maxCycle;
            cyclesToChangeText = maxCycle / yazilar.Length;

            timer1.Start();
            ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cycle == -5)
            {
                timer1.Stop();
                Close();
            }

            if (cycle % cyclesToChangeText == 0 && index < txs.Length)
                label1.Text = txs[index++];

            progressBar1.PerformStep();
            cycle--;

        }
    }
}
