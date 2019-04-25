using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DortIslem.Toplama_İşlemi
{
    public partial class Addition2 : Form
    {
        int sayi;
        int sayi2;

        public Addition2()
        {
            InitializeComponent();

            Random rastgele = new Random();
            sayi = rastgele.Next(10,100);
            sayi2 = rastgele.Next(10,100);

            add1.Text = sayi.ToString();
            add2.Text = sayi2.ToString();
        }

        private void Addition2_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string sonuc = Addition.Text;
            if (sonuc.IsNumeric())
            {
                    int sayi3 = Convert.ToInt32(sonuc);
                if (sayi3 == sayi + sayi2)
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
            sayi = rastgele.Next(10, 100);
            sayi2 = rastgele.Next(10, 100);

            add1.Text = sayi.ToString();
            add2.Text = sayi2.ToString();

            Addition.Clear();
            Sonuc.Text = "Lutfen işlemi tamamlayınız.";
        }

        private void ReturnAddition_Click(object sender, EventArgs e)
        {
            this.Close();
            Addition toplama = new Addition();
            toplama.Show();
        }

        private void ReturnMain_Click(object sender, EventArgs e)
        {
            this.Close();
            DortIslem.Sound.IntroSound();
        }
    }
}
