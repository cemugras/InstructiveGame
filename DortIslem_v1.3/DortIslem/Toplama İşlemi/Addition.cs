using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DortIslem
{

    public partial class Addition : Form
    {
        

        public Addition()
        {
            InitializeComponent();
        }

        private void Level1Sum_Click(object sender, EventArgs e)
        {
            Addition1 level1 = new Addition1();
            level1.Show();
            this.Close();
        }

        private void Level2Sum_Click(object sender, EventArgs e)
        {
            DortIslem.Toplama_İşlemi.Addition2 level2 = new DortIslem.Toplama_İşlemi.Addition2();
            level2.Show();
            this.Close();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            DortIslem.Sound.IntroSound();
        }

        private void Addition_Load(object sender, EventArgs e)
        {

        }
    }
}
