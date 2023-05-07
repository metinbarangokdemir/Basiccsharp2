using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class frmKareKok : Form
    {
        public frmKareKok()
        {
            InitializeComponent();
        }

        private void btnkareKok_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Sqrt(int.Parse(txtSayi.Text)).ToString());
        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
