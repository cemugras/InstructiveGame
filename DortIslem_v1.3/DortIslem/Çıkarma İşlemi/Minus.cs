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
    public partial class Minus : Form
    {
        public Minus()
        {
            InitializeComponent();
        }

        private void Level1Minus_Click(object sender, EventArgs e)
        {
            Minus1 level1 = new Minus1();
            level1.Show();
            this.Close();
        }

        private void MainMenu_Click_1(object sender, EventArgs e)
        {
            this.Close();
            DortIslem.Sound.IntroSound();
        }

        private void Level2Minus_Click(object sender, EventArgs e)
        {
            Minus2 level2 = new Minus2();
            level2.Show();
            this.Close();
        }

        private void Notification_Click(object sender, EventArgs e)
        {

        }
    }
}
