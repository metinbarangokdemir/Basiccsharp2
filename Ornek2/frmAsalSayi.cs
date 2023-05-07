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
    public partial class frmAsalSayi : Form
    {
        public frmAsalSayi()
        {
            InitializeComponent();
        }

        private void btnkontrolEt_Click(object sender, EventArgs e)
        {
            asalMi(txtSayi1.Text);          
        }

        /// <summary>
        /// Asal sayı kontrolü yapmak için kullanılır
        /// </summary>
        /// <param name="sayi">Kontrol etmek istediğiniz değeri string biçimde giriniz</param>
        void asalMi(string sayi)
        {
            int sayac = 0;            
            for (int i = 1; i <= int.Parse(sayi); i++)
            {
                if (int.Parse(sayi) % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 2)
            {
                MessageBox.Show("Girdiğiniz sayısı Asal Sayıdır.");
            }
            else
            {
                MessageBox.Show("Girdiğiniz asal değildir.");
            }
        }

    }
}
