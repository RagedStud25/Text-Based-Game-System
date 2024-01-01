using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Based_Game_System
{
    public partial class newGame_2_ : Form
    {

        public newGame_2_()
        {
            InitializeComponent();
          
        }
        // pictureBox

        public static Image charPic;

        public static Image char1
        {
            get { return charPic; }
            set { charPic = value; }
        }

        public static Image char2
        {
            get { return charPic; }
            set { charPic = value; }
        }

        private void radBtnMale_CheckedChanged(object sender, EventArgs e)
        {
            char1 = picboxChar1.Image;
        }

        private void radBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            char2 = picboxChar2.Image;
        }


        private void btnBack1_Click(object sender, EventArgs e)
        {
            startScreen startScreen = new startScreen();
            this.Visible = false;
            startScreen.Visible = true;
        }



        private void btnBeginStory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChar.Text))
            {
                MessageBox.Show("Please input a name!");
            }
            else
            {
                //string connetionString;
                //string sql = null;
                //SqlConnection con;
                string gender = "";
                if (radBtnFemale.Checked) { gender = "Female"; }
                else if (radBtnMale.Checked) { gender = "Male"; }

                Random rnd = new Random();
               int @int = 0;
                for (int j = 0; j < 4; j++)
                {
                    @int = rnd.Next(15,35);
                }
                int dex = 0;
                for (int j = 0; j < 4; j++)
                {
                    dex = rnd.Next(15, 35);
                }
                int str = 0;
                for (int j = 0; j < 4; j++)
                {
                    str = rnd.Next(15, 35);
                }
               
                string connectionString = "Data Source=LAPTOP-KJTSSLLV\\SQLEXPRESS;Initial Catalog=DB_TextBasedGameSystem;Integrated Security=True";

                // Create a connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("dbo.InsertPlayerWithSavePoint", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.Add(new SqlParameter("@playerNameParam", SqlDbType.NVarChar, 255) { Value = txtChar.Text });
                        command.Parameters.Add(new SqlParameter("@playerGenderParam", SqlDbType.NVarChar, 15) { Value = gender });
                        command.Parameters.Add(new SqlParameter("@playerHealthParam", SqlDbType.Int) { Value = 100 });
                        command.Parameters.Add(new SqlParameter("@playerSanityParam", SqlDbType.Int) { Value = 100 });
                        command.Parameters.Add(new SqlParameter("@playerStrengthParam", SqlDbType.Int) { Value = str });
                        command.Parameters.Add(new SqlParameter("@playerIntelligenceParam", SqlDbType.Int) { Value = @int });
                        command.Parameters.Add(new SqlParameter("@playerDexterityParam", SqlDbType.Int) { Value = dex });
                        command.Parameters.Add(new SqlParameter("@playerLevelParam", SqlDbType.Int) { Value = 1 });
                        command.Parameters.Add(new SqlParameter("@progressDataParam", SqlDbType.NVarChar, -1) { Value = "Level 1 completed" });

                        // Execute the command
                        command.ExecuteNonQuery();

                        Console.WriteLine("Player and save point created successfully.");
                    }



                }

                mainGameScreen mainGameScreen = new mainGameScreen();
                this.Visible = false;
                mainGameScreen.Visible = true;
                mainGameScreen.Show();
                string textBoxValue = txtChar.Text;
                mainGameScreen.TextBoxValue = textBoxValue;

            }
        }
    }
}
