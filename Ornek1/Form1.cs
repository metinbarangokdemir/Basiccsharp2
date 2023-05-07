using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            foreach (Button item in groupBox1.Controls)
            {
                item.BackColor = Color.Red;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            foreach (Button item in groupBox1.Controls)
            {
                item.BackColor = colorDialog1.Color;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            foreach (Button item in groupBox1.Controls)
            {
                item.Width = trackBar1.Value*10;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
