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
        
        int pointsSTR; //Default point (0 )to add to STR Stat. This will increase/decrease based on the clicked button (btnIncrease will increment. btnSubtract will decrement)
        int pointsINT;
        int pointsDEX;


        public bool btnIncreaseINT_Clicked = false;  //Used on if else statement whether the certain button is clicked or not.
        public bool btnSubstractINT_Clicked = false;

        public bool btnIncreaseDEX_Clicked = false;
        public bool btnSubstractDEX_Clicked = false;

        public bool btnIncreaseSTR_Clicked = false;
        public bool btnSubstractSTR_Clicked = false;

        int labelChange = 0; // this is used to show the points used in different stats when the user clicked the decrease or increase button

        private void frmloadLevelUp(object sender, EventArgs e)
        {
            mainGameScreen mainGameScreen = new mainGameScreen();
            labelStr.Text = mainGameScreen.getlabelSTR.ToString();
            labelDex.Text = mainGameScreen.getlabelDEX.ToString();
            labelInt.Text = mainGameScreen.getlabelINT.ToString();

            btnSubstractINT.Enabled = false;
            btnSubstractDEX.Enabled = false;
            btnSubstractSTR.Enabled = false;
        }

        public void pointsCalculationINT()
        {

            if (btnIncreaseINT_Clicked == true)
            { //If else for pointsCalculation for strength.
                btnIncreaseINT_Clicked = false;
                pointsINT = Convert.ToInt32(labelInt.Text);
                pointsINT++;
                labelInt.Text = pointsINT.ToString();

                pointsSpend--;
                labelPointsToSpend.Text = pointsSpend.ToString();

                labelChange = Convert.ToInt32(labelPointsSpendINT.Text);
                labelChange++;
                labelPointsSpendINT.Text = labelChange.ToString();

                if (labelPointsToSpend.Text == "0")
                {
                    MessageBox.Show("No more points to spend");
                    btnIncreaseINT.Enabled = false;
                    btnIncreaseDEX.Enabled = false;
                    btnIncreaseSTR.Enabled = false;
                }

                btnSubstractINT.Enabled = true;
                btnSubstractDEX.Enabled = true;
                btnSubstractSTR.Enabled = true;


            }
            else if (btnSubstractINT_Clicked == true)
            {
                btnSubstractINT_Clicked = false;
                pointsINT = Convert.ToInt32(labelInt.Text);
                pointsINT--;
                labelInt.Text = pointsINT.ToString();

                pointsSpend++;
                labelPointsToSpend.Text = pointsSpend.ToString();

                labelChange = Convert.ToInt32(labelPointsSpendINT.Text);
                labelChange--;
                labelPointsSpendINT.Text = labelChange.ToString();

                // to prevent negative numbers
                if (labelPointsToSpend.Text != "4")
                {
                    btnIncreaseINT.Enabled = true;
                    btnIncreaseDEX.Enabled = true;
                    btnIncreaseSTR.Enabled = true;

                    btnSubstractINT.Enabled = true;
                    btnSubstractDEX.Enabled = true;
                    btnSubstractSTR.Enabled = true;
                } 
                else
                {
                    btnSubstractINT.Enabled = false;
                    btnSubstractDEX.Enabled = false;
                    btnSubstractSTR.Enabled = false;
                }

            }
        }

        public void pointsCalculationDEX()
        {
            
            if (btnIncreaseDEX_Clicked == true)
            { //If else for pointsCalculation for strength.
                btnIncreaseDEX_Clicked = false;
                pointsDEX = Convert.ToInt32(labelDex.Text);
                pointsDEX++;
                labelDex.Text = pointsDEX.ToString();

                pointsSpend--;
                labelPointsToSpend.Text = pointsSpend.ToString();

                labelChange = Convert.ToInt32(labelPointsSpendDEX.Text);
                labelChange++;
                labelPointsSpendDEX.Text = labelChange.ToString();

                if (labelPointsToSpend.Text == "0")
                {
                    MessageBox.Show("No more points to spend");
                    btnIncreaseINT.Enabled = false;
                    btnIncreaseDEX.Enabled = false;
                    btnIncreaseSTR.Enabled = false;
                }

                btnSubstractINT.Enabled = true;
                btnSubstractDEX.Enabled = true;
                btnSubstractSTR.Enabled = true;

            }
            else if (btnSubstractDEX_Clicked == true)
            {
                btnSubstractDEX_Clicked = false;
                pointsDEX = Convert.ToInt32(labelDex.Text);
                pointsDEX--;
                labelDex.Text = pointsDEX.ToString();

                pointsSpend++;
                labelPointsToSpend.Text = pointsSpend.ToString();

                labelChange = Convert.ToInt32(labelPointsSpendDEX.Text);
                labelChange--;
                labelPointsSpendDEX.Text = labelChange.ToString();

                // to prevent negative numbers
                if (labelPointsToSpend.Text != "4")
                {
                    btnIncreaseINT.Enabled = true;
                    btnIncreaseDEX.Enabled = true;
                    btnIncreaseSTR.Enabled = true;

                    btnSubstractINT.Enabled = true;
                    btnSubstractDEX.Enabled = true;
                    btnSubstractSTR.Enabled = true;
                }
                else
                {
                    btnSubstractINT.Enabled = false;
                    btnSubstractDEX.Enabled = false;
                    btnSubstractSTR.Enabled = false;
                }

            }
        }

        public void pointsCalculationSTR()
        {
            if (btnIncreaseSTR_Clicked == true) { //If else for pointsCalculation for strength.
                btnIncreaseSTR_Clicked = false;
                pointsSTR = Convert.ToInt32(labelStr.Text);
                pointsSTR++;
                labelStr.Text = pointsSTR.ToString();

                pointsSpend--;
                labelPointsToSpend.Text = pointsSpend.ToString();

                labelChange = Convert.ToInt32(labelPointsSpendSTR.Text);
                labelChange++;
                labelPointsSpendSTR.Text = labelChange.ToString();

                if (labelPointsToSpend.Text == "0" )
                {
                    MessageBox.Show("No more points to spend");
                    btnIncreaseINT.Enabled = false;
                    btnIncreaseDEX.Enabled = false;
                    btnIncreaseSTR.Enabled = false;
                }

                btnSubstractINT.Enabled = true;
                btnSubstractDEX.Enabled = true;
                btnSubstractSTR.Enabled = true;

            }
            else if (btnSubstractSTR_Clicked == true) {
                btnSubstractSTR_Clicked = false;
                pointsSTR = Convert.ToInt32(labelStr.Text);
                pointsSTR--;
                labelStr.Text = pointsSTR.ToString();

                pointsSpend++;
                labelPointsToSpend.Text = pointsSpend.ToString();

                labelChange = Convert.ToInt32(labelPointsSpendSTR.Text);
                labelChange--;
                labelPointsSpendSTR.Text = labelChange.ToString();

                // to prevent negative numbers
                if (labelPointsToSpend.Text != "4")
                {
                    btnIncreaseINT.Enabled = true;
                    btnIncreaseDEX.Enabled = true;
                    btnIncreaseSTR.Enabled = true;

                    btnSubstractINT.Enabled = true;
                    btnSubstractDEX.Enabled = true;
                    btnSubstractSTR.Enabled = true;
                }
                else
                {
                    btnSubstractINT.Enabled = false;
                    btnSubstractDEX.Enabled = false;
                    btnSubstractSTR.Enabled = false;
                }

            }
        }

        private void btnIncreaseINT_Click(object sender, EventArgs e)
        {
            btnIncreaseINT_Clicked = true;
            pointsCalculationINT();
        }

        private void btnSubstractINT_Click(object sender, EventArgs e)
        {
            btnSubstractINT_Clicked = true;
            pointsCalculationINT();
        }

        private void btnIncreaseDEX_Click(object sender, EventArgs e)
        {
            btnIncreaseDEX_Clicked = true;
            pointsCalculationDEX();
        }

        private void btnSubstractDEX_Click(object sender, EventArgs e)
        {
            btnSubstractDEX_Clicked = true;
            pointsCalculationDEX();
        }
        private void btnIncreaseSTR_Click(object sender, EventArgs e)
        {
            btnIncreaseSTR_Clicked = true;
            pointsCalculationSTR();
        }

        private void btnSubstractSTR_Click(object sender, EventArgs e)
        {
            btnSubstractSTR_Clicked = true;
            pointsCalculationSTR();
        }

    }
}
