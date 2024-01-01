using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Based_Game_System
{
    public partial class mainGameScreen : Form
    {
        int choice = 1; //Get from database. THis will serve as the save point on the user.

        public bool btnChoiceOneClicked = false;
        public bool btnChoiceTwoClicked = false;
        public bool btnChoiceThreeClicked = false;

        public mainGameScreen()
        {
            InitializeComponent();
            gameStart();
        }

        int latestPlayerId = GetLatestPlayerID();

        private void btnChoiceOne_Click(object sender, EventArgs e)
        {
            btnChoiceOneClicked = true;
            gameStart();
        }

        private void btnChoiceTwo_Click(object sender, EventArgs e)
        {
            btnChoiceTwoClicked = true;
            gameStart();
        }

        private void btnChoiceThree_Click(object sender, EventArgs e)
        {
            btnChoiceThreeClicked = true;
            gameStart();
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            startScreen startScreen = new startScreen();
            startScreen.Show();
        }

        static int GetLatestPlayerID()
        {
            string connectionString = "Data Source=LAPTOP-KJTSSLLV\\SQLEXPRESS;Initial Catalog=DB_TextBasedGameSystem;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetLatestPlayerID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Execute the command and retrieve the latest player ID
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        void GetPlayerStats(int playerId) {

            string connectionString = "Data Source=LAPTOP-KJTSSLLV\\SQLEXPRESS;Initial Catalog=DB_TextBasedGameSystem;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetPlayerStats", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@playerID", SqlDbType.Int) { Value = playerId });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access data using column names or indices
                            int playerHealth = Convert.ToInt32(reader["PlayerHealth"]);
                            int playerSanity = Convert.ToInt32(reader["PlayerSanity"]);
                            int playerStrength = Convert.ToInt32(reader["PlayerStrength"]);
                            int playerIntelligence = Convert.ToInt32(reader["PlayerIntelligence"]);
                            int playerDexterity = Convert.ToInt32(reader["PlayerDexterity"]);

                            HealthPB.Value = playerHealth;
                            SanityPB.Value = playerSanity;
                            StrengthPB.Value = playerStrength;
                            IntPB.Value = playerIntelligence;
                            DexPB.Value = playerDexterity;

                            Console.WriteLine($"Player Stats: Health={playerHealth}, Sanity={playerSanity}, Strength={playerStrength}, Intelligence={playerIntelligence}, Dexterity={playerDexterity}");
                        }
                    }
                }
            }
        }

        private void mainGameScreen_Load(object sender, EventArgs e)
        {
            HealthPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            HealthPB.ForeColor = Color.Red;
            //  int playerId = 1; // Replace with the actual player ID
            GetPlayerStats(latestPlayerId);

            // transfer picBox from newGame to mainGame
            charPicBox.Image = newGame_2_.charPic;

            
        }
        public string TextBoxValue
        {
            set
            {
                // Assuming labelForm2 is the name of your Label control
                PlayerNameLBL.Text = value;
            }

        }

        public void mainStory_1() //Main story 1
        {
            labelMainstory.Text = "MAIN GAME STORY (1) \n Choices: \n A. Maitim \n B. Maputi \n C. Snigger";

            if (btnChoiceOneClicked == true) //CHOICE A
            {
                labelMainstory.Text = "HELLO WhiteAss \n\n\n\n\n\n LOADING...";
                btnChoiceOneClicked = false;
                choice++;
            }
            else if (btnChoiceTwoClicked == true) //CHOICE B
            {
                labelMainstory.Text = "HELLO Maitim \n\n\n\n\n\n LOADING...";
                btnChoiceTwoClicked = false;
                choice++;
            }
            else if (btnChoiceThreeClicked == true) //CHOICE C
            {
                labelMainstory.Text = "HELLO Snig \n\n\n\n\n\n LOADING...";
                btnChoiceThreeClicked = false;
                choice++;
            }
        }

        public void fillerStory_1() //Filler 1
        {
            labelMainstory.Text = "ARE YOU GAY? \n Choices: \n A. Yes \n B. No \n C. yesn't";

            if (btnChoiceOneClicked == true)
            {
                labelMainstory.Text = "gayass faggot";
                btnChoiceOneClicked = false;
                choice++;
            }
        }

        public void gameStart()
        {
            switch (choice)
            {
                case 1:
                    mainStory_1();
                    break;

                case 2:
                    fillerStory_1();
                    break;

                case 3:
                    labelMainstory.Text = "FILLER (2)";
                    break;

                case 4:
                    labelMainstory.Text = "MAIN GAME STORY (2)";
                    break;

                case 5:
                    labelMainstory.Text = "FILLER (3)";
                    break;

                case 6:
                    labelMainstory.Text = "FILLER (4)";
                    break;

                case 7:
                    labelMainstory.Text = "MAIN GAME STORY (3)";
                    break;
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AttackBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameStart();
        }

        private void automaticRefresh(object sender, EventArgs e)
        {
            gameStart();
        }

    }
}
