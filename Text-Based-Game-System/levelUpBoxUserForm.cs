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
    public partial class levelUpBoxUserForm : Form
    {
        public levelUpBoxUserForm()
        {
            InitializeComponent();
        }

        int pointsSpend = 4; //User points to spend. Default is always 4. if points is added to a certain stats, the points to spend will decrease accordingly.
        int pointsSTR = 0; //Default point (0 )to add to STR Stat. This will increase/decrease based on the clicked button (btnIncrease will increment. btnSubtract will decrement)

        public bool btnIncreaseSTR_Clicked = false; //Used on if else statement whether the certain button is clicked or not.
        public bool btnSubstractSTR_Clicked = false;


        private void frmloadLevelUp(object sender, EventArgs e)
        {
            mainGameScreen mainGameScreen = new mainGameScreen();
            labelStr.Text = mainGameScreen.GetLabelSTR.ToString();
            labelDex.Text = mainGameScreen.GetLabelDEX.ToString();
            labelInt.Text = mainGameScreen.GetLabelINT.ToString();
        }

        public void pointsCalculation()
        {
            if (btnIncreaseSTR_Clicked == true) { //If else for pointsCalculation for strength.
                btnIncreaseSTR_Clicked = false;
                pointsSTR++;
                labelStr.Text = pointsSTR.ToString();
                pointsSpend--;
                labelPointsSpendSTR.Text = pointsSpend.ToString();
            }
            else if (btnSubstractSTR_Clicked == true) {
                btnSubstractSTR_Clicked = false;
                pointsSTR--;
                labelStr.Text = pointsSTR.ToString();
                pointsSpend++;
                labelPointsSpendSTR.Text = pointsSpend.ToString();
            }
        }

        private void btnIncreaseSTR_Click(object sender, EventArgs e)
        {
            btnIncreaseSTR_Clicked = true;
            
            pointsCalculation();
        }

        private void btnSubstractSTR_Click(object sender, EventArgs e)
        {
            btnSubstractSTR_Clicked = true;

            pointsCalculation();
        }
    }
}
