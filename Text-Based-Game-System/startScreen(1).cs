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
    public partial class startScreen : Form
    {

        newGame_2_ newGame_2_ = new newGame_2_();
        loadGame_2_ loadGame_2_ = new loadGame_2_();

        public startScreen()
        {
            InitializeComponent();
        }

        private void btnNewGamee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            newGame_2_.Visible = true;
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loadGame_2_.Visible = true;
        }
    }
}
