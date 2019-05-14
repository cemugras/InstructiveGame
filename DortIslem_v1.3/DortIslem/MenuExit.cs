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
    public partial class MenuExit : Form
    {
        public MenuExit()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitConfirm_Click(object sender, EventArgs e)
        {

        }

        private void MenuExit_Load(object sender, EventArgs e)
        {
            Sound.ExitSound();
        }
    }
}
