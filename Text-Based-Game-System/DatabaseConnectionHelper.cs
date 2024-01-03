using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Text_Based_Game_System
{
    public class PlayerDetails
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public string PlayerGender { get; set; }
        public int PlayerHealth { get; set; }
        public int PlayerSanity { get; set; }
        public int PlayerStrength { get; set; }
        public int PlayerIntelligence { get; set; }
        public int PlayerDexterity { get; set; }
        public int PlayerLevel { get; set; }
    }
    public class DatabaseHelper
    {

        private static string connectionString = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=ProjectFinal;Integrated Security=True";

        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public static void CloseConnection(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable GetPlayers()
        {
            DataTable players = new DataTable();

            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT PlayerID, PlayerName FROM PlayerDetails", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(players);
                    }
                }
            }

            return players;
        }

        public void SavePlayerStats(int playerId, int health, int sanity, int strength, int intelligence, int dexterity, int level)
        {
            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand("UPDATE PlayerStats SET PlayerHealth = @Health, PlayerSanity = @Sanity, " +
                                                           "PlayerStrength = @Strength, PlayerIntelligence = @Intelligence, " +
                                                           "PlayerDexterity = @Dexterity, PlayerLevel = @Level " +
                                                           "WHERE PlayerID = @PlayerID", connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", playerId);
                    command.Parameters.AddWithValue("@Health", health);
                    command.Parameters.AddWithValue("@Sanity", sanity);
                    command.Parameters.AddWithValue("@Strength", strength);
                    command.Parameters.AddWithValue("@Intelligence", intelligence);
                    command.Parameters.AddWithValue("@Dexterity", dexterity);
                    command.Parameters.AddWithValue("@Level", level);

                    command.ExecuteNonQuery();
                }
            }
        }

        public bool SavePlayerProgress(int playerId, string progressData, int saveSlot)
        {
            try
            {
                using (SqlConnection connection = OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand("SavePlayerProgress", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@playerID", SqlDbType.Int) { Value = playerId });
                        command.Parameters.Add(new SqlParameter("@progressData", SqlDbType.NVarChar) { Value = progressData });
                        command.Parameters.Add(new SqlParameter("@saveSlot", SqlDbType.Int) { Value = saveSlot });

                        // Execute the save command
                        command.ExecuteNonQuery();
                    }
                }

                // If the save is successful, return true
                return true;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                // If the save fails, return false
                return false;
            }
        }

        public string GetPlayerName(int playerId)
        {
            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT PlayerName FROM PlayerDetails WHERE PlayerID = @PlayerID", connection))
                {
                    command.Parameters.Add(new SqlParameter("@PlayerID", SqlDbType.Int) { Value = playerId });

                    // Execute the command and retrieve the player name
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        // Handle the case where no player name is found (you may want to display a message to the user)
                        return "Unknown Player";
                    }
                }
            }
        }

        public void GetPlayerStats(int playerId, ProgressBar healthPB, ProgressBar sanityPB, ProgressBar strengthPB, ProgressBar intPB, ProgressBar dexPB,
            Label labelIint, Label labelDex, Label labelStrength, Label labelHealth, Label labelSanity, Label labelPlayerLevel)
        {
            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand("GetPlayerStats", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@playerID", SqlDbType.Int) { Value = playerId });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int playerHealth = Convert.ToInt32(reader["PlayerHealth"]);
                            int playerSanity = Convert.ToInt32(reader["PlayerSanity"]);
                            int playerStrength = Convert.ToInt32(reader["PlayerStrength"]);
                            int playerIntelligence = Convert.ToInt32(reader["PlayerIntelligence"]);
                            int playerDexterity = Convert.ToInt32(reader["PlayerDexterity"]);

                            // Update form controls
                            healthPB.Value = playerHealth;
                            sanityPB.Value = playerSanity;
                            strengthPB.Value = playerStrength;
                            intPB.Value = playerIntelligence;
                            dexPB.Value = playerDexterity;

                            labelIint.Text = playerIntelligence.ToString();
                            labelDex.Text = playerDexterity.ToString();
                            labelStrength.Text = playerStrength.ToString();
                            labelHealth.Text = playerHealth.ToString();
                            labelSanity.Text = playerSanity.ToString();

                            Console.WriteLine($"Player Stats: Health={playerHealth}, Sanity={playerSanity}, Strength={playerStrength}, Intelligence={playerIntelligence}, Dexterity={playerDexterity}");
                        }
                    }
                }
            }
        }

        public void UpdatePlayerStatsAndName(int playerId, ProgressBar healthPB, ProgressBar sanityPB, ProgressBar strengthPB, ProgressBar intPB, ProgressBar dexPB,
            Label labelIint, Label labelDex, Label labelStrength, Label labelHealth, Label labelSanity, Label labelPlayerLevel, Label PlayerNameLBL)
        {
            // Update the player stats and name in the form
            GetPlayerStats(playerId, healthPB, sanityPB, strengthPB, intPB, dexPB, labelIint, labelDex, labelStrength, labelHealth, labelSanity, labelPlayerLevel);

            // Assuming you have a label for the player's name
            PlayerNameLBL.Text = GetPlayerName(playerId);
        }

        public int GetLatestPlayerID()
        {
            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand("GetLatestPlayerID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public void UpdatePlayerStats(int playerId, int playerLevel)
        {
            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand("UpdatePlayerStats", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@playerID", SqlDbType.Int) { Value = playerId });
                    command.Parameters.Add(new SqlParameter("@playerLevel", SqlDbType.Int) { Value = playerLevel });

                    // Execute the update command
                    command.ExecuteNonQuery();
                }
            }
        }
        public PlayerDetails GetLatestPlayerDetails()
        {
            PlayerDetails playerDetails = new PlayerDetails();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT TOP 1 pd.PlayerID, pd.PlayerName, pd.PlayerGender,
                                  ps.PlayerHealth, ps.PlayerSanity, ps.PlayerStrength,
                                  ps.PlayerIntelligence, ps.PlayerDexterity, ps.PlayerLevel
                    FROM PlayerDetails pd
                    INNER JOIN PlayerStats ps ON pd.PlayerID = ps.PlayerID
                    ORDER BY pd.PlayerID DESC;
                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            playerDetails.PlayerID = (int)reader["PlayerID"];
                            playerDetails.PlayerName = reader["PlayerName"].ToString();
                            playerDetails.PlayerGender = reader["PlayerGender"].ToString();
                            playerDetails.PlayerHealth = (int)reader["PlayerHealth"];
                            playerDetails.PlayerSanity = (int)reader["PlayerSanity"];
                            playerDetails.PlayerStrength = (int)reader["PlayerStrength"];
                            playerDetails.PlayerIntelligence = (int)reader["PlayerIntelligence"];
                            playerDetails.PlayerDexterity = (int)reader["PlayerDexterity"];
                            playerDetails.PlayerLevel = (int)reader["PlayerLevel"];
                        }
                    }
                }
            }

            return playerDetails;
        }
        public int GetLastPlayerChoice(int playerId)
        {
            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT TOP 1 SaveSlot FROM PlayerSavePoint WHERE PlayerID = @PlayerID ORDER BY SaveTime DESC", connection))
                {
                    command.Parameters.Add(new SqlParameter("@PlayerID", SqlDbType.Int) { Value = playerId });

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int lastPlayerChoice))
                    {
                        return lastPlayerChoice;
                    }
                }
            }

            // If no player choice is found, return a default value
            return 1; // Replace with your default value
        }
    }
}
