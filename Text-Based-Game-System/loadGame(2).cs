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
using System.Xml.Schema;

namespace Text_Based_Game_System
{
    public partial class loadGame_2_ : Form
    {
        public loadGame_2_()
        {
            InitializeComponent();
        }

        public void addPlayerName() {
            SqlConnection con;
            string connectionString = "Data Source=LAPTOP-KJTSSLLV\\SQLEXPRESS;Initial Catalog=DB_TextBasedGameSystem;Integrated Security=True";

            con = new SqlConnection(connectionString);

            con.Open();
            string sql = "select * from [PlayerDetails]";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string DATAReader = reader.GetValue(0).ToString(); //Gets data from SQL Database(DB_Shop)
                comboPlayername.Items.Add(DATAReader);
            }
            con.Close();
        }

        public void getPlayerName()
        {
            SqlConnection con;
            string connectionString = "Data Source=LAPTOP-KJTSSLLV\\SQLEXPRESS;Initial Catalog=DB_TextBasedGameSystem;Integrated Security=True";

            con = new SqlConnection(connectionString);

            con.Open();
            string sql = "select * from [PlayerDetails] where PlayerID = '" + comboPlayername.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                labelPlayerID.Text = reader.GetValue(1).ToString();
               
                labelPlayerGender.Text = reader.GetValue(2).ToString();
            }
            if (labelPlayerGender.Text == "Male")
            {
                PBgender.Image = Image.FromFile("C:\\Users\\Lenovo\\Downloads\\GENDERMALE.png");

            }
            else if (labelPlayerGender.Text == "Female")
            {
                PBgender.Image = Image.FromFile("C:\\Users\\Lenovo\\Downloads\\GENDERFEMALE.png");
            }

                con.Close();
        }


        public void displayPlayerStats()
        {
            SqlConnection con;
            string connectionString = "Data Source=LAPTOP-KJTSSLLV\\SQLEXPRESS;Initial Catalog=DB_TextBasedGameSystem;Integrated Security=True";

            con = new SqlConnection(connectionString);

            con.Open();
            string sql = "select * from [PlayerStats] where PlayerID = '" + comboPlayername.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                labelPlayerHP.Text = reader.GetValue(1).ToString();
                labelPlayerSanity.Text = reader.GetValue(2).ToString();
                labelPlayerlvl.Text = reader.GetValue(6).ToString();
                labelPlayerStr.Text = reader.GetValue(3).ToString();
                labelPlayerInt.Text = reader.GetValue(4).ToString();
                labelPlayerDex.Text = reader.GetValue(5).ToString();
            }
            con.Close();

            getPlayerName();
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

        private void frmLoad_LoadGame(object sender, EventArgs e)
        {
            addPlayerName();
        }

        private void comboSelect(object sender, EventArgs e)
        {
            
            displayPlayerStats();
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MainGameScreenLoad.getPlayerID = Convert.ToInt32(comboPlayername.Text);
            MainGameScreenLoad mainGameScreenLoad = new MainGameScreenLoad();

            string textBoxValue = labelPlayerID.Text;
            mainGameScreenLoad.TextBoxValue = textBoxValue;

            string playerGenderValue = labelPlayerGender.Text;
            mainGameScreenLoad.playerGenderSet = playerGenderValue;

            this.Visible = false;
            mainGameScreenLoad.Visible = true;


        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            int whereID = Convert.ToInt32(comboPlayername.Text);

            string connetionString;
            SqlConnection con;
            connetionString = "Data Source=LAPTOP-KJTSSLLV\\SQLEXPRESS;Initial Catalog=DB_TextBasedGameSystem;Integrated Security=True";
            con = new SqlConnection(connetionString);

            con.Open(); // This updates the currency from the program to the sql database. 
         
          SqlCommand cmdUpdate = new SqlCommand("DELETE FROM[PlayerStats] WHERE PlayerID = " + whereID, con);
          cmdUpdate = new SqlCommand("DELETE FROM [PlayerSavePoint] WHERE PlayerID = " + whereID, con);
          
          cmdUpdate.ExecuteNonQuery();
          
            con.Close();

            con.Open();
          
            SqlCommand DeletePlayerDetails = new SqlCommand("DELETE FROM [PlayerDetails] WHERE PlayerID = " + whereID, con);
            DeletePlayerDetails.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted Successfully");
        }
    }
}
