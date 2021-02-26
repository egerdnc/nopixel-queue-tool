using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace np_tool
{
    public partial class NoPixel : Form

    {
        bool shit = false;
        public NoPixel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("fivem://connect/gta.nopixel.net");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text);

            if (checkBox1.Checked)
            {
                timer1.Interval = x;
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process.Start("fivem://connect/gta.nopixel.net");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text);
            if (x < 3000)
            {
                MessageBox.Show("shit");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nopixel.net");
        }
    }
}
