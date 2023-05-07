using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        class vatandas
        {
            public string tckimlikNo;
            public string adSoyad;
            public DateTime dogumTarihi;

            void yashesapla()
            {

            }
        }

        class yok:vatandas
        {
            public string okulAdi;
            public string okulAdresi;
            public string okultelefonNo;
        }
        
        class universite:yok
        {
            public string ogrenciNo;
            public string kampusAdi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            universite yeniOgrenci = new universite();
            yeniOgrenci.tckimlikNo = "1";
            yeniOgrenci.adSoyad = "ali yılmaz";
            yeniOgrenci.dogumTarihi =Convert.ToDateTime("10.10.2000").Date;
            yeniOgrenci.okulAdresi = "Beyazıt İstanbul";
            yeniOgrenci.okulAdi = "İstanbul Üniversitesi";
            yeniOgrenci.okultelefonNo = "123456";
            yeniOgrenci.ogrenciNo = "qwqweqwe";
            yeniOgrenci.kampusAdi = "Avcılar";
            MessageBox.Show(yeniOgrenci.okulAdi);
        }
    }
}
