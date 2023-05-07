using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci yeniOgrenci = new Ogrenci();
            yeniOgrenci.adSoyad = "Ali Çelik";
            yeniOgrenci.numara = "123";

            Okul yeniOkul = new Okul();
            
        }

        class Ogrenci
        {
            public string ogrenciNo;
            public string adSoyad;
            public string numara;
            private string ozelDurum;
        }

        class Okul:Ogrenci
        {
            public string ogretmenAdSoyad;
            public string ogretmenSicilNo;
        }



    }
}
