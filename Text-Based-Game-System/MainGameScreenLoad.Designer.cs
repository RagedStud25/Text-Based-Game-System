namespace Text_Based_Game_System
{
    partial class MainGameScreenLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameScreenLoad));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.labelWherePlayerID = new System.Windows.Forms.Label();
            this.btnTestExpiGen = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelSanity = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelDex = new System.Windows.Forms.Label();
            this.labelIint = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnKIllsme = new System.Windows.Forms.Button();
            this.btnChoiceThree = new System.Windows.Forms.Button();
            this.btnChoiceTwo = new System.Windows.Forms.Button();
            this.btnChoiceOne = new System.Windows.Forms.Button();
            this.labelMainstory = new System.Windows.Forms.Label();
            this.expPB = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.StrengthPB = new System.Windows.Forms.ProgressBar();
            this.DexPB = new System.Windows.Forms.ProgressBar();
            this.IntPB = new System.Windows.Forms.ProgressBar();
            this.SanityPB = new System.Windows.Forms.ProgressBar();
            this.HealthPB = new System.Windows.Forms.ProgressBar();
            this.labelPlayerLevel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerNameLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.borderPlayer1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.charPicBox = new System.Windows.Forms.PictureBox();
            this.labelPlayerGender = new System.Windows.Forms.Label();
            this.btnTestMinusSanity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.automaticRefresher);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(571, 811);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(532, 43);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelWherePlayerID
            // 
            this.labelWherePlayerID.AutoSize = true;
            this.labelWherePlayerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWherePlayerID.Location = new System.Drawing.Point(505, 30);
            this.labelWherePlayerID.Name = "labelWherePlayerID";
            this.labelWherePlayerID.Size = new System.Drawing.Size(194, 31);
            this.labelWherePlayerID.TabIndex = 86;
            this.labelWherePlayerID.Text = "LatestPlayerID";
            // 
            // btnTestExpiGen
            // 
            this.btnTestExpiGen.Location = new System.Drawing.Point(1016, 469);
            this.btnTestExpiGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTestExpiGen.Name = "btnTestExpiGen";
            this.btnTestExpiGen.Size = new System.Drawing.Size(71, 54);
            this.btnTestExpiGen.TabIndex = 85;
            this.btnTestExpiGen.Text = "EXP HERE";
            this.btnTestExpiGen.UseVisualStyleBackColor = true;
            this.btnTestExpiGen.Click += new System.EventHandler(this.btnTestExpiGen_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(564, 71);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 28);
            this.label11.TabIndex = 84;
            this.label11.Text = "/100";
            // 
            // labelExp
            // 
            this.labelExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExp.Location = new System.Drawing.Point(519, 143);
            this.labelExp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(49, 28);
            this.labelExp.TabIndex = 83;
            this.labelExp.Text = "000";
            // 
            // labelSanity
            // 
            this.labelSanity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSanity.Location = new System.Drawing.Point(519, 106);
            this.labelSanity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSanity.Name = "labelSanity";
            this.labelSanity.Size = new System.Drawing.Size(49, 28);
            this.labelSanity.TabIndex = 82;
            this.labelSanity.Text = "000";
            // 
            // labelHealth
            // 
            this.labelHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealth.Location = new System.Drawing.Point(519, 71);
            this.labelHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(49, 28);
            this.labelHealth.TabIndex = 81;
            this.labelHealth.Text = "000";
            // 
            // labelStrength
            // 
            this.labelStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrength.Location = new System.Drawing.Point(989, 143);
            this.labelStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(69, 28);
            this.labelStrength.TabIndex = 80;
            this.labelStrength.Text = "000";
            // 
            // labelDex
            // 
            this.labelDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDex.Location = new System.Drawing.Point(989, 106);
            this.labelDex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDex.Name = "labelDex";
            this.labelDex.Size = new System.Drawing.Size(69, 28);
            this.labelDex.TabIndex = 79;
            this.labelDex.Text = "000";
            // 
            // labelIint
            // 
            this.labelIint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIint.Location = new System.Drawing.Point(989, 71);
            this.labelIint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIint.Name = "labelIint";
            this.labelIint.Size = new System.Drawing.Size(69, 28);
            this.labelIint.TabIndex = 78;
            this.labelIint.Text = "000";
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(12, 811);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(553, 43);
            this.btnContinue.TabIndex = 77;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnKIllsme
            // 
            this.btnKIllsme.Location = new System.Drawing.Point(1012, 528);
            this.btnKIllsme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKIllsme.Name = "btnKIllsme";
            this.btnKIllsme.Size = new System.Drawing.Size(75, 71);
            this.btnKIllsme.TabIndex = 76;
            this.btnKIllsme.Text = "- 25 HP";
            this.btnKIllsme.UseVisualStyleBackColor = true;
            this.btnKIllsme.Click += new System.EventHandler(this.btnKIllsme_Click);
            // 
            // btnChoiceThree
            // 
            this.btnChoiceThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceThree.Location = new System.Drawing.Point(753, 862);
            this.btnChoiceThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChoiceThree.Name = "btnChoiceThree";
            this.btnChoiceThree.Size = new System.Drawing.Size(349, 59);
            this.btnChoiceThree.TabIndex = 75;
            this.btnChoiceThree.Text = "Choice C";
            this.btnChoiceThree.UseVisualStyleBackColor = true;
            this.btnChoiceThree.Click += new System.EventHandler(this.btnChoiceThree_Click);
            // 
            // btnChoiceTwo
            // 
            this.btnChoiceTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceTwo.Location = new System.Drawing.Point(380, 862);
            this.btnChoiceTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChoiceTwo.Name = "btnChoiceTwo";
            this.btnChoiceTwo.Size = new System.Drawing.Size(368, 58);
            this.btnChoiceTwo.TabIndex = 74;
            this.btnChoiceTwo.Text = "Choice B";
            this.btnChoiceTwo.UseVisualStyleBackColor = true;
            this.btnChoiceTwo.Click += new System.EventHandler(this.btnChoiceTwo_Click);
            // 
            // btnChoiceOne
            // 
            this.btnChoiceOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceOne.Location = new System.Drawing.Point(12, 862);
            this.btnChoiceOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChoiceOne.Name = "btnChoiceOne";
            this.btnChoiceOne.Size = new System.Drawing.Size(363, 58);
            this.btnChoiceOne.TabIndex = 73;
            this.btnChoiceOne.Text = "Choice A";
            this.btnChoiceOne.UseVisualStyleBackColor = true;
            this.btnChoiceOne.Click += new System.EventHandler(this.btnChoiceOne_Click);
            // 
            // labelMainstory
            // 
            this.labelMainstory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainstory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainstory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMainstory.Location = new System.Drawing.Point(12, 222);
            this.labelMainstory.Name = "labelMainstory";
            this.labelMainstory.Size = new System.Drawing.Size(1090, 577);
            this.labelMainstory.TabIndex = 72;
            this.labelMainstory.Text = resources.GetString("labelMainstory.Text");
            // 
            // expPB
            // 
            this.expPB.ForeColor = System.Drawing.Color.LimeGreen;
            this.expPB.Location = new System.Drawing.Point(320, 143);
            this.expPB.Margin = new System.Windows.Forms.Padding(4);
            this.expPB.Name = "expPB";
            this.expPB.Size = new System.Drawing.Size(191, 28);
            this.expPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.expPB.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 70;
            this.label8.Text = "Exp:";
            // 
            // StrengthPB
            // 
            this.StrengthPB.ForeColor = System.Drawing.Color.LimeGreen;
            this.StrengthPB.Location = new System.Drawing.Point(791, 143);
            this.StrengthPB.Margin = new System.Windows.Forms.Padding(4);
            this.StrengthPB.Name = "StrengthPB";
            this.StrengthPB.Size = new System.Drawing.Size(191, 28);
            this.StrengthPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.StrengthPB.TabIndex = 69;
            this.StrengthPB.Value = 100;
            // 
            // DexPB
            // 
            this.DexPB.ForeColor = System.Drawing.Color.LimeGreen;
            this.DexPB.Location = new System.Drawing.Point(791, 106);
            this.DexPB.Margin = new System.Windows.Forms.Padding(4);
            this.DexPB.Name = "DexPB";
            this.DexPB.Size = new System.Drawing.Size(191, 28);
            this.DexPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DexPB.TabIndex = 68;
            this.DexPB.Value = 100;
            // 
            // IntPB
            // 
            this.IntPB.ForeColor = System.Drawing.Color.LimeGreen;
            this.IntPB.Location = new System.Drawing.Point(791, 71);
            this.IntPB.Margin = new System.Windows.Forms.Padding(4);
            this.IntPB.Name = "IntPB";
            this.IntPB.Size = new System.Drawing.Size(191, 28);
            this.IntPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.IntPB.TabIndex = 67;
            this.IntPB.Value = 15;
            // 
            // SanityPB
            // 
            this.SanityPB.ForeColor = System.Drawing.Color.LimeGreen;
            this.SanityPB.Location = new System.Drawing.Point(320, 106);
            this.SanityPB.Margin = new System.Windows.Forms.Padding(4);
            this.SanityPB.Name = "SanityPB";
            this.SanityPB.Size = new System.Drawing.Size(191, 28);
            this.SanityPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SanityPB.TabIndex = 66;
            this.SanityPB.Value = 89;
            // 
            // HealthPB
            // 
            this.HealthPB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.HealthPB.ForeColor = System.Drawing.Color.LimeGreen;
            this.HealthPB.Location = new System.Drawing.Point(321, 71);
            this.HealthPB.Margin = new System.Windows.Forms.Padding(4);
            this.HealthPB.Name = "HealthPB";
            this.HealthPB.Size = new System.Drawing.Size(189, 28);
            this.HealthPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HealthPB.TabIndex = 65;
            this.HealthPB.Value = 100;
            // 
            // labelPlayerLevel
            // 
            this.labelPlayerLevel.AutoSize = true;
            this.labelPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerLevel.Location = new System.Drawing.Point(315, 180);
            this.labelPlayerLevel.Name = "labelPlayerLevel";
            this.labelPlayerLevel.Size = new System.Drawing.Size(23, 25);
            this.labelPlayerLevel.TabIndex = 64;
            this.labelPlayerLevel.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "Level:";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Showcard Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.Location = new System.Drawing.Point(1043, 30);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(47, 44);
            this.labelHome.TabIndex = 62;
            this.labelHome.Text = "⌂";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(659, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "Intelligence:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(659, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "Dexterity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(659, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "Strength:";
            // 
            // PlayerNameLBL
            // 
            this.PlayerNameLBL.AutoSize = true;
            this.PlayerNameLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameLBL.Location = new System.Drawing.Point(239, 30);
            this.PlayerNameLBL.Name = "PlayerNameLBL";
            this.PlayerNameLBL.Size = new System.Drawing.Size(172, 34);
            this.PlayerNameLBL.TabIndex = 58;
            this.PlayerNameLBL.Text = "PlayerName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Sanity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Health:";
            // 
            // borderPlayer1
            // 
            this.borderPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.borderPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderPlayer1.Location = new System.Drawing.Point(13, 14);
            this.borderPlayer1.Name = "borderPlayer1";
            this.borderPlayer1.Size = new System.Drawing.Size(1090, 201);
            this.borderPlayer1.TabIndex = 54;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(449, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(50, 31);
            this.labelID.TabIndex = 88;
            this.labelID.Text = "ID:";
            // 
            // charPicBox
            // 
            this.charPicBox.Image = global::Text_Based_Game_System.Properties.Resources.male1;
            this.charPicBox.Location = new System.Drawing.Point(29, 30);
            this.charPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charPicBox.Name = "charPicBox";
            this.charPicBox.Size = new System.Drawing.Size(187, 172);
            this.charPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.charPicBox.TabIndex = 89;
            this.charPicBox.TabStop = false;
            this.charPicBox.Click += new System.EventHandler(this.charPicBox_Click);
            // 
            // labelPlayerGender
            // 
            this.labelPlayerGender.AutoSize = true;
            this.labelPlayerGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerGender.Location = new System.Drawing.Point(728, 30);
            this.labelPlayerGender.Name = "labelPlayerGender";
            this.labelPlayerGender.Size = new System.Drawing.Size(194, 31);
            this.labelPlayerGender.TabIndex = 90;
            this.labelPlayerGender.Text = "LatestPlayerID";
            // 
            // btnTestMinusSanity
            // 
            this.btnTestMinusSanity.Location = new System.Drawing.Point(1012, 603);
            this.btnTestMinusSanity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTestMinusSanity.Name = "btnTestMinusSanity";
            this.btnTestMinusSanity.Size = new System.Drawing.Size(75, 71);
            this.btnTestMinusSanity.TabIndex = 91;
            this.btnTestMinusSanity.Text = "- 25 Sanity";
            this.btnTestMinusSanity.UseVisualStyleBackColor = true;
            this.btnTestMinusSanity.Click += new System.EventHandler(this.btnTestMinusSanity_Click);
            // 
            // MainGameScreenLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1116, 1000);
            this.Controls.Add(this.btnTestMinusSanity);
            this.Controls.Add(this.labelPlayerGender);
            this.Controls.Add(this.charPicBox);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelWherePlayerID);
            this.Controls.Add(this.btnTestExpiGen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelExp);
            this.Controls.Add(this.labelSanity);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.labelDex);
            this.Controls.Add(this.labelIint);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnKIllsme);
            this.Controls.Add(this.btnChoiceThree);
            this.Controls.Add(this.btnChoiceTwo);
            this.Controls.Add(this.btnChoiceOne);
            this.Controls.Add(this.labelMainstory);
            this.Controls.Add(this.expPB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StrengthPB);
            this.Controls.Add(this.DexPB);
            this.Controls.Add(this.IntPB);
            this.Controls.Add(this.SanityPB);
            this.Controls.Add(this.HealthPB);
            this.Controls.Add(this.labelPlayerLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PlayerNameLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borderPlayer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainGameScreenLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainGameScreenLoad";
            this.Load += new System.EventHandler(this.frmMainGameScreenLoad);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelWherePlayerID;
        private System.Windows.Forms.Button btnTestExpiGen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label labelSanity;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelDex;
        private System.Windows.Forms.Label labelIint;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnKIllsme;
        private System.Windows.Forms.Button btnChoiceThree;
        private System.Windows.Forms.Button btnChoiceTwo;
        private System.Windows.Forms.Button btnChoiceOne;
        private System.Windows.Forms.Label labelMainstory;
        private System.Windows.Forms.ProgressBar expPB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar StrengthPB;
        private System.Windows.Forms.ProgressBar DexPB;
        private System.Windows.Forms.ProgressBar IntPB;
        private System.Windows.Forms.ProgressBar SanityPB;
        private System.Windows.Forms.ProgressBar HealthPB;
        private System.Windows.Forms.Label labelPlayerLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PlayerNameLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label borderPlayer1;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.PictureBox charPicBox;
        private System.Windows.Forms.Label labelPlayerGender;
        private System.Windows.Forms.Button btnTestMinusSanity;
    }
}