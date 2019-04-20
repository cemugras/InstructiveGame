using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DortIslem.Bölme_İşlemi
{
    public partial class Div2 : Form
    {
        int sayi;
        int sayi2;
        int sayi3;
        public Div2()
        {
            InitializeComponent();

            Random rastgele = new Random();
            sayi2 = rastgele.Next(6, 12);
            sayi = rastgele.Next(1, 6);

            sayi3 = sayi * sayi2;

            add1.Text = sayi3.ToString();
            add2.Text = sayi.ToString();
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            string sonuc = Dividing.Text;
            if (sonuc.IsNumeric())
            {
                int sayi4 = Convert.ToInt32(sonuc);
                if (sayi4 == sayi3 / sayi)
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

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi2 = rastgele.Next(6, 12);
            sayi = rastgele.Next(1, 6);

            sayi3 = sayi * sayi2;

            add1.Text = sayi3.ToString();
            add2.Text = sayi.ToString();

            Dividing.Clear();
            Sonuc.Text = "Lutfen işlemi tamamlayınız.";
        }

        private void ReturnDiv_Click(object sender, EventArgs e)
        {
            this.Close();
            Div bolme = new Div();
            bolme.Show();
        }

        private void ReturnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
