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
        //Get from database. THis will serve as the save point on the user.

        int playerChoiceSavepoint = 1;

        public bool btnChoiceOneClicked = false;
        public bool btnChoiceTwoClicked = false;
        public bool btnChoiceThreeClicked = false;
        public bool btnContinueClicked = false;

        // player stats
        public static int playerInt;
        public static int playerDex;
        public static int playerStr;
        int playerHealth;
        int playerExp;
        int playerSanity;
        int playerLevel;

        levelUpBoxUserForm levelUpBoxUser = new levelUpBoxUserForm();

        public mainGameScreen()
        {
            InitializeComponent();
            gameStart();
        }

        //Getter and setter method for level up pop up form//
        public static int getlabelSTR
        {
            get { return playerStr; }
            set { playerStr = value; }
        }
        public static int getlabelINT
        {
            get { return playerInt; }
            set { playerInt = value; }
        }

        public static int getlabelDEX
        {
            get { return playerDex; }
            set { playerDex = value; }
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

        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnContinueClicked = true;
            gameStart();
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            startScreen startScreen = new startScreen();
            startScreen.Show();
        }

        static int GetLatestPlayerID()
        {
            string connectionString = "Data Source=DESKTOP-O47AIOR\\SQLEXPRESS;Initial Catalog=DB_TextBasedGameSystem;Integrated Security=True";
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

            string connectionString = "Data Source=DESKTOP-O47AIOR\\SQLEXPRESS;Initial Catalog=DB_TextBasedGameSystem;Integrated Security=True";

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

                            labelIint.Text = playerIntelligence.ToString();
                            labelDex.Text = playerDexterity.ToString();
                            labelStrength.Text = playerStrength.ToString();

                            labelHealth.Text = playerHealth.ToString();
                            labelSanity.Text = playerSanity.ToString();
                            labelExp.Text = playerExp.ToString();

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

            // transfer picBox from newGame to mainGame
            charPicBox.Image = newGame_2_.charPic;

            playerInt = Convert.ToInt32(labelIint.Text);
            playerDex = Convert.ToInt32(labelDex.Text);
            playerStr = Convert.ToInt32(labelStrength.Text);


        }
        public string TextBoxValue
        {
            set
            {
                // Assuming labelForm2 is the name of your Label control
                PlayerNameLBL.Text = value;
            }

        }

        // main story 1
        public void mainStory_1()
        {

            labelMainstory.Text = "On a Monday morning, you woke up to the sound of your alarm. Today's your first day working as a waiter at a restaurant called \"Joblibee.\" You're nervous right now because you remembered that it's a famous restaurant and the interviewer told you that you must be able to work under pressure. \r\n\r\n\"I can do this!\" you said to yourself, while looking at the mirror, placing your nameplate on your polo. \r\n \nClick Continue to Proceed.";

            btnContinue.Enabled = true;
            btnContinue.Visible = true;
            playerChoiceSavepoint++;
        }

        // filler 1
        public void fillerStory_1()
        {
            labelMainstory.Text = "While you're on your way to work, you saw an old woman struggling on her way home as the field that she's walking on has a lot of stairs. \r\n\r\na. help her and be late\r\nb. ask someone near you to help the old woman (50% success)\r\nc. pretend that you didn't see her and walk away\r\n\n";

            if (btnChoiceOneClicked == true)
            {
                labelMainstory.Text = ".. so you helped the old woman to reach her home and sacrificed minutes of your time. \r\n\r\n\"Thank you for helping me. Please take this bag of fruits as this is the only way I can give my thanks.\" \r\n\r\n\"Ohh.. I appreciate it grandma but I'm fine, thank you!\"\r\n\r\nYou said goodbye to the old woman and still had 5 minutes left, so you did your best to run as fast as you could.\r\n \n\nClick Continue...";
                btnChoiceOneClicked = false;

                playerExp = expPB.Value + 25;
                expPB.Value = playerExp;
                labelExp.Text = playerExp.ToString();

                //playerChoiceSavepoint++;
            }
            else if (btnChoiceTwoClicked == true) //CHOICE B
            {
                // base chance of success
                int baseChance = 2;

                // player stats
                int IntStats = IntPB.Value;

                // generate number from 1 to 100
                Random random = new Random();
                int choice = random.Next(1, 100);

                // Calculate the chance of success based on player stats
                int chanceOfSucess = baseChance + IntStats;

                if (choice <= chanceOfSucess)
                {
                    labelMainstory.Text = "\nSuccess! \n\n.. you saw an unknown person passing by and you approached him. \r\n\r\n\"Excuse me--\" you asked..\r\n\r\n\"Who are you? What do you need?\" said the unknown person, giving you confused looks. \r\n\r\n\"May I ask if you can help that woman?\" you pointed at the old woman.\r\n\r\n\"Of course. Go on with your errands now.\"\r\n\r\nit made sense that the man doesn't want to help the woman, so you just did it yourself. \r\nThe woman kindly helped the old woman, and you went on your way to the interview room.\r\n \nClick Continue";
                    btnChoiceTwoClicked = false;

                    playerExp = expPB.Value + 25;
                    expPB.Value = playerExp;
                    labelExp.Text = playerExp.ToString();

                    playerChoiceSavepoint++;

                }
                else
                {
                    labelMainstory.Text = "\nFailed! \n\n.. you saw an unknown person passing by and you approached him. \r\n\r\n\"Excuse me--\" you asked..\r\n\r\n\"Who are you? What do you need?\" said the unknown person, giving you confused looks. \r\n\r\n\"uhm.. may I ask if you can help that woman?\" you pointed at the old woman.\r\n\r\n\"And why do I have to help her? why don't you do it yourself?\"\r\n\r\nit made sense that the man doesn't want to help the woman, so you just did it yourself. (- 25 sanity) \n\nClick Continue";
                    btnChoiceTwoClicked = false;

                    playerSanity = SanityPB.Value - 25;
                    SanityPB.Value = playerSanity;

                    playerExp = expPB.Value + 10;
                    expPB.Value = playerExp;

                    labelSanity.Text = playerSanity.ToString();
                    labelExp.Text = playerExp.ToString();

                    playerChoiceSavepoint++;
                }

            }
            else if (btnChoiceThreeClicked == true) //CHOICE C
            {
                labelMainstory.Text = "you pretended that you didn't see the old woman and slowly you felt guilty on not helping her. although it saved your reputation in the company for being punctual. (- 1 sanity) \n\nClick Continue...";
                btnChoiceThreeClicked = false;

                playerSanity = SanityPB.Value - 25;
                SanityPB.Value = playerSanity;

                playerExp = expPB.Value + 25;
                expPB.Value = playerExp;

                labelSanity.Text = playerSanity.ToString();
                labelExp.Text = playerExp.ToString();

                playerChoiceSavepoint++;
            }
        }

        // main story 2
        public void mainStory_2()
        {
            labelMainstory.Text = "At work, many of the staffs welcomed you and gave you gifts. You introduced yourself to all of them and after that the manager came in and said,\r\n\r\n\"What's with the commotion? What are you doing in this time? I am expecting that all of you are now working in the kitchen, right?\"\r\n\r\nall of the workers started to go back to their respective stations while the manager head towards you that made you nervous. \r\n\r\n\"So, you're the reason why they are all not in their respective stations, hmm?\r\n\r\nyou nodded. \r\n\r\n\"Don't be nervous kid, I was just acting according to my role. Anyways, welcome to Joblibee. I hope you have a brave heart as your tasks are not for the weak. You may now go to your station.\"\r\n\r\nAfter few minutes, the restaurant is now finally accepting customers. You're co-worker asked you to help him serve the food in table 15, but you also overheard that a family is in need of something. \r\n\r\na. prioritise helping your co-worker\r\nb. help the other customer first, then help your co-worker\r\nc. ask another waiter to help the other table\r\n";

            if (btnChoiceOneClicked == true)
            {
                labelMainstory.Text = "the customer got mad as no other waiters are paying attention to their requests. And decided to leave the restaurant. \n\nClick Continue...";
                btnChoiceOneClicked = false;

                playerExp = expPB.Value + 25;
                expPB.Value = playerExp;
                labelExp.Text = playerExp.ToString();

                playerChoiceSavepoint++;
            }
            else if (btnChoiceTwoClicked == true) //CHOICE B
            {
                labelMainstory.Text = "but the customers in table 15 are asking why is their order incomplete, blaming your co-worker. Your co-worker got angry and decided not to talk to you for the rest of the day. \n(-25 Sanity) \n\nClick Continue...";
                btnChoiceTwoClicked = false;

                playerSanity = SanityPB.Value - 25;
                SanityPB.Value = playerSanity;

                playerExp = expPB.Value + 25;
                expPB.Value = playerExp;

                labelSanity.Text = playerSanity.ToString();
                labelExp.Text = playerExp.ToString();

                playerChoiceSavepoint++;
            }
            else if (btnChoiceThreeClicked == true) //CHOICE C
            {
                labelMainstory.Text = "The manager came out and asked the other staff about the situation. However, the problem was already solved and the customers are now satisfied.\r\n\r\n\"This is the first time that I saw customers this irritated.\" you said, heart pounding, scared that the scenario almost kick you out of your job. \r\n \n(+25 Sanity) \n\nClick Continue...";
                btnChoiceThreeClicked = false;

                playerSanity = SanityPB.Value + 25;
                SanityPB.Value = playerSanity;

                playerExp = expPB.Value + 25;
                expPB.Value = playerExp;

                labelSanity.Text = playerSanity.ToString();
                labelExp.Text = playerExp.ToString();

                playerChoiceSavepoint++;
            }
        }

        // main story 3
        public void mainStory_3()
        {
            labelMainstory.Text = "\"Don't worry, we're used to it. It's not our fault that all of us are busy. They can come to the cashier to ask for utensils if there are no waiters available.\" said your co-worker.\r\n\r\n\"oh well.. I'll get used to it someday\"\r\n\r\nIt's already closing hours. You packed up your things, getting ready to go home. You are excited to come home that you're already imagining yourself laying down in your soft bed and watching an interesting movie. \r\n\r\n\"Hey, wanna hang out with us tonight?\" your daydreaming ends as one of your co-workers asked you to go out with them. \r\n\r\na. say yes and go with them\r\nb. lie and told them that your parents are looking for you\r\nc. ignore your co-worker and proceed to go home.\r\n";

            if (btnChoiceOneClicked == true)
            {
                labelMainstory.Text = "since this is your first day, you said yes to your co-worker without knowing the location first. all your co-workers are ready to go. It’s near your workplace, so all of you decided to walk instead of riding a tricycle.\r\n\r\nYou are slowly approaching the place they told you and to your surprise, it’s a bar and not a restaurant. \r\n\r\n“You drink, right?” your co-worker asked.\r\n\r\n“To be honest, I don’t drink..” you said, leaving them in disbelief.\r\n“Now’s the time you drink! This is a tradition every time we have a new co-worker” they said.\r\n\r\nYou can’t do anything but to agree since you don’t want to disappoint them.\r\n\r\nThey made you drink the beer, and after many hours of bonding and drinking, it’s time to go home.\r\n \n\nClick Continue...";
                btnChoiceOneClicked = false;

                playerExp = expPB.Value + 25;
                expPB.Value = playerExp;
                labelExp.Text = playerExp.ToString();

                playerChoiceSavepoint++;
            }
            else if (btnChoiceTwoClicked == true) //CHOICE B
            {
                // base chance of success
                int baseChance = 2;

                // player stats
                int IntStats = IntPB.Value;

                // generate number from 1 to 100
                Random random = new Random();
                int choice = random.Next(1, 100);

                // Calculate the chance of success based on player stats
                int chanceOfSucess = baseChance + IntStats;

                if (choice <= chanceOfSucess)
                {
                    labelMainstory.Text = "\nSuccess! \n\n.. you successfully convinced your co-workers that your parents are looking for you, and hence they let you go home.(+25 Sanity)\r\n \nClick Continue";
                    btnChoiceTwoClicked = false;

                    playerSanity = SanityPB.Value + 25;
                    SanityPB.Value = playerSanity;

                    playerExp = expPB.Value + 25;
                    expPB.Value = playerExp;

                    labelSanity.Text = playerSanity.ToString();
                    labelExp.Text = playerExp.ToString();

                    playerChoiceSavepoint++;
                }
                else
                {
                    labelMainstory.Text = "\nFailed! \n\n.. Your co-workers see through your lies and with a cringe face says “We know you’re lying you know. You can just ignore the invitation and go home.”. You go home feeling extremely embarrassed. (-25 Sanity) \n\nClick Continue";
                    btnChoiceTwoClicked = false;

                    playerSanity = SanityPB.Value - 25;
                    SanityPB.Value = playerSanity;

                    playerExp = expPB.Value + 10;
                    expPB.Value = playerExp;

                    labelSanity.Text = playerSanity.ToString();
                    labelExp.Text = playerExp.ToString();

                    playerChoiceSavepoint++;
                }
            }
            else if (btnChoiceThreeClicked == true) //CHOICE C
            {
                labelMainstory.Text = "Nervously ignore your co-worker and proceed to go home.\n\nClick Continue...";
                btnChoiceThreeClicked = false;

                playerExp = expPB.Value + 25;
                expPB.Value = playerExp;
                labelExp.Text = playerExp.ToString();

                playerChoiceSavepoint++;
            }
        }

        // filler 2
        public void fillerStory_2()
        {
            labelMainstory.Text = "It’s raining and good thing, you brought an umbrella. While walking, you saw a lady who was struggling in holding a lot of things and didn't have an umbrella. \r\n\r\na. help her\r\nb. ignore her\r\nc. laugh at her\r\n";

            if (btnChoiceOneClicked == true)
            {
                labelMainstory.Text = "you helped the lady and it granted you something and it vanished. (+25 Sanity) \n\nClick Continue";
                btnChoiceOneClicked = false;

                playerSanity = SanityPB.Value - 25;
                SanityPB.Value = playerSanity;

                playerExp = expPB.Value + 25;
                expPB.Value = playerExp;

                labelSanity.Text = playerSanity.ToString();
                labelExp.Text = playerExp.ToString();

                playerChoiceSavepoint++;
            }
            else if (btnChoiceTwoClicked == true) //CHOICE B
            {
                labelMainstory.Text = "you were dizzy and feeling nauseous, so you ignored the lady. \n\nClick Continue";
                btnChoiceTwoClicked = false;

                playerExp = expPB.Value + 25;
                expPB.Value = playerExp;
                labelExp.Text = playerExp.ToString();

                playerChoiceSavepoint++;
            }
            else if (btnChoiceThreeClicked == true) //CHOICE C
            {
                labelMainstory.Text = "you were too drunk and laughed at the lady who was soaking wet in the rain. she stared into your soul and felt like she said something you can’t hear. (-25 Sanity, -25 Health) \n\nClick Continue...";
                btnChoiceThreeClicked = false;

                playerSanity = SanityPB.Value - 25;
                SanityPB.Value = playerSanity;

                playerHealth = HealthPB.Value - 25;
                HealthPB.Value = playerHealth;

                playerExp = expPB.Value + 25;
                expPB.Value = playerExp;

                labelSanity.Text = playerSanity.ToString();
                labelExp.Text = playerExp.ToString();
                playerChoiceSavepoint++;
            }
        }

        // main story 4
        public void mainStory_4()
        {
            labelMainstory.Text = "You came home tired and longing for your bed. \r\n\r\n“This is so tiring, I almost forgot I need to have time for myself. Maybe I should just do it tomorrow. I really need to take a rest.”\r\n\r\nTo be continued…\r\n";
        }

        public void playerLevelUpMechanics() // If user's xp reached 100. This will show the level up stats form.
        {
            playerLevel = Convert.ToInt32(labelPlayerLevel.Text);

            if(playerExp == 100)
            {
                playerLevel++;
                labelPlayerLevel.Text = playerLevel.ToString();
                playerExp = 0;
                expPB.Value = playerExp;
                levelUpBoxUser.Visible = true;

            }
        }

        public void gameStart()
        {
            

            switch (playerChoiceSavepoint)
            {
                case 1:
                    mainStory_1();
                    break;

                case 2:
                    fillerStory_1();
                    break;

                case 3:
                    mainStory_2();
                    break;

                case 4:
                    mainStory_3();
                    break;

                case 5:
                    fillerStory_2();
                    break;

                case 6:
                    mainStory_4();
                    break;


            }

        }


        // test button
        private void button1_Click(object sender, EventArgs e)
        {
            gameStart();
        }

        private void btnTestExpiGen_Click(object sender, EventArgs e)
        {
            playerExp = expPB.Value + 25;
            expPB.Value = playerExp;
        }

        private void automaticRefresh(object sender, EventArgs e) //Timer for refreshing the playerlevelupmechanics to detect real-time adjusstments.
        {
            playerLevelUpMechanics();
        }
    }
}
