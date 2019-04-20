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
    public partial class Multi : Form
    {
        public Multi()
        {
            InitializeComponent();
        }

        private void Level1Multi_Click(object sender, EventArgs e)
        {
            Multi1 level1 = new Multi1();
            level1.Show();
            this.Close();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Level2Multi_Click(object sender, EventArgs e)
        {
            Multi2 level2 = new Multi2();
            level2.Show();
            this.Close();
        }
    }
}