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
    public partial class Div : Form
    {
        public Div()
        {
            InitializeComponent();
        }

        private void Level1Div_Click(object sender, EventArgs e)
        {
            Div1 level1 = new Div1();
            level1.Show();
            this.Close();
        }

        private void Level2Div_Click(object sender, EventArgs e)
        {
            Div2 level2 = new Div2();
            level2.Show();
            this.Close();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            DortIslem.Sound.IntroSound();
        }
    }
}
