using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DortIslem.Çarpma_İşlemi
{
    public partial class Multi1 : Form
    {
        int sayi;
        int sayi2;
        public Multi1()
        {
            InitializeComponent();

            Random rastgele = new Random();
            sayi2 = rastgele.Next(1, 9);
            sayi = rastgele.Next(sayi2, 10);

            add1.Text = sayi.ToString();
            add2.Text = sayi2.ToString();
        }

        private void ButtonMulti_Click(object sender, EventArgs e)
        {
            string sonuc = Multiplication.Text;
            if (sonuc.IsNumeric())
            {
                int sayi3 = Convert.ToInt32(sonuc);
                if (sayi3 == sayi * sayi2)
                {
                    Sonuc.Text = "Sonuc Dogru, Tebrikler";
                    DortIslem.Sound.TrueSound();
                }
                else
                {
                    Sonuc.Text = "Sonuc Yanlis, Tekrar Deneyin";
                    DortIslem.Sound.WrongSound();
                }
            }
            else
            {
                Sonuc.Text = "Girilen Değer Rakam Değil.";
                DortIslem.Sound.WrongSound();
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi2 = rastgele.Next(1, 9);
            sayi = rastgele.Next(sayi2, 10);

            add1.Text = sayi.ToString();
            add2.Text = sayi2.ToString();

            Multiplication.Clear();
            Sonuc.Text = "Lutfen işlemi tamamlayınız.";
        }

        private void ReturnMulti_Click(object sender, EventArgs e)
        {
            this.Close();
            Multi carpma = new Multi();
            carpma.Show();
        }

        private void ReturnMain_Click(object sender, EventArgs e)
        {
            this.Close();
            DortIslem.Sound.IntroSound();
        }
    }
}
