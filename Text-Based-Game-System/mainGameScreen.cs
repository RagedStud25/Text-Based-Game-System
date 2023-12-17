using System;
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
     
        
        public mainGameScreen()
        {
            InitializeComponent();
            
          
        }

        int latestPlayerId = GetLatestPlayerID();

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
            //  int playerId = 1; // Replace with the actual player ID
            GetPlayerStats(latestPlayerId);



        }
        public string TextBoxValue
        {
            set
            {
                // Assuming labelForm2 is the name of your Label control
                PlayerNameLBL.Text = value;
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
      
    }
}
