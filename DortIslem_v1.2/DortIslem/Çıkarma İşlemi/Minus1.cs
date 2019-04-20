using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DortIslem.Çıkarma_İşlemi
{
    public partial class Minus1 : Form
    {
        int sayi;
        int sayi2;
        public Minus1()
        {
            InitializeComponent();

            Random rastgele = new Random();
            sayi2 = rastgele.Next(1, 9);
            sayi = rastgele.Next(sayi2,10);
            
            add1.Text = sayi.ToString();
            add2.Text = sayi2.ToString();
        }

        private void Addition_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sonuc_Click(object sender, EventArgs e)
        {

        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            string sonuc = Addition.Text;
            if (sonuc.IsNumeric())
            {
                int sayi3 = Convert.ToInt32(sonuc);
                if (sayi3 == sayi - sayi2)
                {
                    Sonuc.Text = "Sonuc Dogru, Tebrikler";
                }
                else
                {
                    Sonuc.Text = "Sonuc Yanlis, Tekrar Deneyin";
                }
            }
            else
            {
                Sonuc.Text = "Girilen Değer Rakam Değil.";
            }
        }

        private void ButtonRefresh_Click_1(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi2 = rastgele.Next(1, 9);
            sayi = rastgele.Next(sayi2, 10);

            add1.Text = sayi.ToString();
            add2.Text = sayi2.ToString();

            Addition.Clear();
            Sonuc.Text = "Lutfen işlemi tamamlayınız.";
        }

        private void ReturnMinus_Click(object sender, EventArgs e)
        {
            this.Close();
            Minus cikarma = new Minus();
            cikarma.Show();
        }

        private void ReturnMain_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
