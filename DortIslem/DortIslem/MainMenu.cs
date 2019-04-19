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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuNotification dilbildirim = new MenuNotification();
            dilbildirim.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuExit exit = new MenuExit();
            exit.Show();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuHelp help = new MenuHelp();
            help.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Addition toplama = new Addition();
            toplama.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubsButton_Click(object sender, EventArgs e)
        {
            DortIslem.Çıkarma_İşlemi.Minus cikarma = new DortIslem.Çıkarma_İşlemi.Minus();
            cikarma.Show();
        }
    }
}
