using System;
using System.Data.SqlClient;
using System.Linq;
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
            // Add any specific logic for pictureBox2 click event
        }

        private void lblLastAutoSave_Click(object sender, EventArgs e)
        {
            // Create an instance of DatabaseHelper
            DatabaseHelper dbHelper = new DatabaseHelper();

            // Get the latest player details
            PlayerDetails latestPlayerDetails = dbHelper.GetLatestPlayerDetails();

            // Access the mainGameScreen form instance or create a new instance if it's not open
            mainGameScreen mainGameForm = Application.OpenForms.OfType<mainGameScreen>().FirstOrDefault() ?? new mainGameScreen();

            // Update UI with the latest player details
            mainGameForm.HealthPB.Value = latestPlayerDetails.PlayerHealth;
            mainGameForm.SanityPB.Value = latestPlayerDetails.PlayerSanity;
            mainGameForm.StrengthPB.Value = latestPlayerDetails.PlayerStrength;
            mainGameForm.IntPB.Value = latestPlayerDetails.PlayerIntelligence;
            mainGameForm.DexPB.Value = latestPlayerDetails.PlayerDexterity;
            mainGameForm.labelIint.Text = latestPlayerDetails.PlayerIntelligence.ToString();
            mainGameForm.labelDex.Text = latestPlayerDetails.PlayerDexterity.ToString();
            mainGameForm.labelStrength.Text = latestPlayerDetails.PlayerStrength.ToString();
            mainGameForm.labelHealth.Text = latestPlayerDetails.PlayerHealth.ToString();
            mainGameForm.labelSanity.Text = latestPlayerDetails.PlayerSanity.ToString();
            mainGameForm.labelPlayerLevel.Text = latestPlayerDetails.PlayerLevel.ToString();
            mainGameForm.PlayerNameLBL.Text = latestPlayerDetails.PlayerName;

            // Show or bring to front the mainGameScreen form
            mainGameForm.Show();

            // Close the loadGame form
            this.Close();
        }
    }
}