using System;
using System.Windows.Forms;

namespace UForSchleife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdSchleife1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "";
            for (double d = 35; d >= 20; d = d - 2.5)
                LblAnzeige.Text += d + "\n";
        }

        private void CmdSchleife2_Click(object sender, EventArgs e)
        {
            int count = 0;
            double summe = 0.0, mw;

            LblAnzeige.Text = "";
            for (double d = 35; d >= 20; d = d - 2.5)
            {
                LblAnzeige.Text += d + "\n";
                count = count + 1;
                summe = summe + d;
            }

            mw = summe / count;
            LblAnzeige.Text += "Summe: " + summe + "\n";
            LblAnzeige.Text += "Mittelwert: " + mw;
        }
    }
}
