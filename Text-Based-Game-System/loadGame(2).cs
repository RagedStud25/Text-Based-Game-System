using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Based_Game_System
{
    public partial class loadGame_2_ : Form
    {
        public loadGame_2_()
        {
            InitializeComponent();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            startScreen startScreen = new startScreen();
            this.Visible = false;
            startScreen.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
