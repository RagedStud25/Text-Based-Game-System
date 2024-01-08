namespace Text_Based_Game_System
{
    partial class mainGameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGameScreen));
            this.borderPlayer1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerNameLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPlayerLevel = new System.Windows.Forms.Label();
            this.charPicBox = new System.Windows.Forms.PictureBox();
            this.HealthPB = new System.Windows.Forms.ProgressBar();
            this.SanityPB = new System.Windows.Forms.ProgressBar();
            this.IntPB = new System.Windows.Forms.ProgressBar();
            this.DexPB = new System.Windows.Forms.ProgressBar();
            this.StrengthPB = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.expPB = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelMainstory = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnChoiceOne = new System.Windows.Forms.Button();
            this.btnChoiceTwo = new System.Windows.Forms.Button();
            this.btnChoiceThree = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelIint = new System.Windows.Forms.Label();
            this.labelDex = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelSanity = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTestExpiGen = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.labelWherePlayerID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.btnTestMinusSanity = new System.Windows.Forms.Button();
            this.btnKIllsme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.charPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // borderPlayer1
            // 
            this.borderPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.borderPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderPlayer1.Location = new System.Drawing.Point(12, 11);
            this.borderPlayer1.Name = "borderPlayer1";
            this.borderPlayer1.Size = new System.Drawing.Size(1090, 201);
            this.borderPlayer1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Health:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sanity:";
            // 
            // PlayerNameLBL
            // 
            this.PlayerNameLBL.AutoSize = true;
            this.PlayerNameLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameLBL.Location = new System.Drawing.Point(236, 26);
            this.PlayerNameLBL.Name = "PlayerNameLBL";
            this.PlayerNameLBL.Size = new System.Drawing.Size(172, 34);
            this.PlayerNameLBL.TabIndex = 21;
            this.PlayerNameLBL.Text = "PlayerName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Strength:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(656, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Dexterity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Intelligence:";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Showcard Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.Location = new System.Drawing.Point(1036, 17);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(47, 44);
            this.labelHome.TabIndex = 28;
            this.labelHome.Text = "⌂";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(232, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Level:";
            // 
            // labelPlayerLevel
            // 
            this.labelPlayerLevel.AutoSize = true;
            this.labelPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerLevel.Location = new System.Drawing.Point(312, 176);
            this.labelPlayerLevel.Name = "labelPlayerLevel";
            this.labelPlayerLevel.Size = new System.Drawing.Size(23, 25);
            this.labelPlayerLevel.TabIndex = 30;
            this.labelPlayerLevel.Text = "1";
            // 
            // charPicBox
            // 
            this.charPicBox.Location = new System.Drawing.Point(27, 26);
            this.charPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charPicBox.Name = "charPicBox";
            this.charPicBox.Size = new System.Drawing.Size(187, 172);
            this.charPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.charPicBox.TabIndex = 16;
            this.charPicBox.TabStop = false;
            // 
            // HealthPB
            // 
            this.HealthPB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.HealthPB.ForeColor = System.Drawing.Color.LimeGreen;
            this.HealthPB.Location = new System.Drawing.Point(319, 68);
            this.HealthPB.Margin = new System.Windows.Forms.Padding(4);
            this.HealthPB.Name = "HealthPB";
            this.HealthPB.Size = new System.Drawing.Size(189, 28);
            this.HealthPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HealthPB.TabIndex = 31;
            this.HealthPB.Value = 100;
            // 
            // SanityPB
            // 
            this.SanityPB.ForeColor = System.Drawing.Color.LimeGreen;
            this.SanityPB.Location = new System.Drawing.Point(317, 103);
            this.SanityPB.Margin = new System.Windows.Forms.Padding(4);
            this.SanityPB.Name = "SanityPB";
            this.SanityPB.Size = new System.Drawing.Size(191, 28);
            this.SanityPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SanityPB.TabIndex = 32;
            this.SanityPB.Value = 89;
            // 
            // IntPB
            // 
            this.IntPB.ForeColor = System.Drawing.Color.LimeGreen;
            this.IntPB.Location = new System.Drawing.Point(788, 68);
            this.IntPB.Margin = new System.Windows.Forms.Padding(4);
            this.IntPB.Name = "IntPB";
            this.IntPB.Size = new System.Drawing.Size(191, 28);
            this.IntPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.IntPB.TabIndex = 33;
            this.IntPB.Value = 15;
            // 
            // DexPB
            // 
            this.DexPB.ForeColor = System.Drawing.Color.LimeGreen;
            this.DexPB.Location = new System.Drawing.Point(788, 103);
            this.DexPB.Margin = new System.Windows.Forms.Padding(4);
            this.DexPB.Name = "DexPB";
            this.DexPB.Size = new System.Drawing.Size(191, 28);
            this.DexPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DexPB.TabIndex = 34;
            this.DexPB.Value = 100;
            // 
            // StrengthPB
            // 
            this.StrengthPB.ForeColor = System.Drawing.Color.LimeGreen;
            this.StrengthPB.Location = new System.Drawing.Point(788, 139);
            this.StrengthPB.Margin = new System.Windows.Forms.Padding(4);
            this.StrengthPB.Name = "StrengthPB";
            this.StrengthPB.Size = new System.Drawing.Size(191, 28);
            this.StrengthPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.StrengthPB.TabIndex = 35;
            this.StrengthPB.Value = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Exp:";
            // 
            // expPB
            // 
            this.expPB.ForeColor = System.Drawing.Color.LimeGreen;
            this.expPB.Location = new System.Drawing.Point(317, 139);
            this.expPB.Margin = new System.Windows.Forms.Padding(4);
            this.expPB.Name = "expPB";
            this.expPB.Size = new System.Drawing.Size(191, 28);
            this.expPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.expPB.TabIndex = 37;
            // 
            // labelMainstory
            // 
            this.labelMainstory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainstory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainstory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMainstory.Location = new System.Drawing.Point(12, 226);
            this.labelMainstory.Name = "labelMainstory";
            this.labelMainstory.Size = new System.Drawing.Size(1090, 577);
            this.labelMainstory.TabIndex = 38;
            this.labelMainstory.Text = resources.GetString("labelMainstory.Text");
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnChoiceOne
            // 
            this.btnChoiceOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceOne.Location = new System.Drawing.Point(12, 866);
            this.btnChoiceOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChoiceOne.Name = "btnChoiceOne";
            this.btnChoiceOne.Size = new System.Drawing.Size(363, 58);
            this.btnChoiceOne.TabIndex = 39;
            this.btnChoiceOne.Text = "Choice A";
            this.btnChoiceOne.UseVisualStyleBackColor = true;
            this.btnChoiceOne.Click += new System.EventHandler(this.btnChoiceOne_Click);
            // 
            // btnChoiceTwo
            // 
            this.btnChoiceTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceTwo.Location = new System.Drawing.Point(380, 866);
            this.btnChoiceTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChoiceTwo.Name = "btnChoiceTwo";
            this.btnChoiceTwo.Size = new System.Drawing.Size(368, 58);
            this.btnChoiceTwo.TabIndex = 40;
            this.btnChoiceTwo.Text = "Choice B";
            this.btnChoiceTwo.UseVisualStyleBackColor = true;
            this.btnChoiceTwo.Click += new System.EventHandler(this.btnChoiceTwo_Click);
            // 
            // btnChoiceThree
            // 
            this.btnChoiceThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceThree.Location = new System.Drawing.Point(753, 865);
            this.btnChoiceThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChoiceThree.Name = "btnChoiceThree";
            this.btnChoiceThree.Size = new System.Drawing.Size(349, 59);
            this.btnChoiceThree.TabIndex = 41;
            this.btnChoiceThree.Text = "Choice C";
            this.btnChoiceThree.UseVisualStyleBackColor = true;
            this.btnChoiceThree.Click += new System.EventHandler(this.btnChoiceThree_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(12, 815);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(553, 43);
            this.btnContinue.TabIndex = 43;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1016, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 72);
            this.button1.TabIndex = 42;
            this.button1.Text = "btnTestRandom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelIint
            // 
            this.labelIint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIint.Location = new System.Drawing.Point(987, 68);
            this.labelIint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIint.Name = "labelIint";
            this.labelIint.Size = new System.Drawing.Size(69, 28);
            this.labelIint.TabIndex = 44;
            this.labelIint.Text = "000";
            // 
            // labelDex
            // 
            this.labelDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDex.Location = new System.Drawing.Point(987, 103);
            this.labelDex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDex.Name = "labelDex";
            this.labelDex.Size = new System.Drawing.Size(69, 28);
            this.labelDex.TabIndex = 45;
            this.labelDex.Text = "000";
            // 
            // labelStrength
            // 
            this.labelStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrength.Location = new System.Drawing.Point(987, 139);
            this.labelStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(69, 28);
            this.labelStrength.TabIndex = 46;
            this.labelStrength.Text = "000";
            // 
            // labelSanity
            // 
            this.labelSanity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSanity.Location = new System.Drawing.Point(516, 103);
            this.labelSanity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSanity.Name = "labelSanity";
            this.labelSanity.Size = new System.Drawing.Size(49, 28);
            this.labelSanity.TabIndex = 48;
            this.labelSanity.Text = "000";
            // 
            // labelExp
            // 
            this.labelExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExp.Location = new System.Drawing.Point(516, 139);
            this.labelExp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(49, 28);
            this.labelExp.TabIndex = 49;
            this.labelExp.Text = "000";
            // 
            // labelHealth
            // 
            this.labelHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealth.Location = new System.Drawing.Point(516, 68);
            this.labelHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(49, 28);
            this.labelHealth.TabIndex = 47;
            this.labelHealth.Text = "000";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(561, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 28);
            this.label11.TabIndex = 50;
            this.label11.Text = "/100";
            // 
            // btnTestExpiGen
            // 
            this.btnTestExpiGen.Location = new System.Drawing.Point(1016, 473);
            this.btnTestExpiGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTestExpiGen.Name = "btnTestExpiGen";
            this.btnTestExpiGen.Size = new System.Drawing.Size(71, 54);
            this.btnTestExpiGen.TabIndex = 51;
            this.btnTestExpiGen.Text = "EXP HERE";
            this.btnTestExpiGen.UseVisualStyleBackColor = true;
            this.btnTestExpiGen.Click += new System.EventHandler(this.btnTestExpiGen_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.automaticRefresh);
            // 
            // labelWherePlayerID
            // 
            this.labelWherePlayerID.AutoSize = true;
            this.labelWherePlayerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWherePlayerID.Location = new System.Drawing.Point(465, 27);
            this.labelWherePlayerID.Name = "labelWherePlayerID";
            this.labelWherePlayerID.Size = new System.Drawing.Size(194, 31);
            this.labelWherePlayerID.TabIndex = 52;
            this.labelWherePlayerID.Text = "LatestPlayerID";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(571, 815);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(532, 43);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(421, 27);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(50, 31);
            this.labelID.TabIndex = 54;
            this.labelID.Text = "ID:";
            // 
            // btnTestMinusSanity
            // 
            this.btnTestMinusSanity.Location = new System.Drawing.Point(1016, 606);
            this.btnTestMinusSanity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTestMinusSanity.Name = "btnTestMinusSanity";
            this.btnTestMinusSanity.Size = new System.Drawing.Size(71, 70);
            this.btnTestMinusSanity.TabIndex = 93;
            this.btnTestMinusSanity.Text = "- 25 Sanity";
            this.btnTestMinusSanity.UseVisualStyleBackColor = true;
            this.btnTestMinusSanity.Click += new System.EventHandler(this.btnTestMinusSanity_Click);
            // 
            // btnKIllsme
            // 
            this.btnKIllsme.Location = new System.Drawing.Point(1016, 531);
            this.btnKIllsme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKIllsme.Name = "btnKIllsme";
            this.btnKIllsme.Size = new System.Drawing.Size(71, 71);
            this.btnKIllsme.TabIndex = 92;
            this.btnKIllsme.Text = "- 25 HP";
            this.btnKIllsme.UseVisualStyleBackColor = true;
            this.btnKIllsme.Click += new System.EventHandler(this.btnKIllsme_Click);
            // 
            // mainGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1117, 980);
            this.Controls.Add(this.btnTestMinusSanity);
            this.Controls.Add(this.btnKIllsme);
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
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.charPicBox);
            this.Controls.Add(this.borderPlayer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainGameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainGameScreen";
            this.Load += new System.EventHandler(this.mainGameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label borderPlayer1;
        private System.Windows.Forms.PictureBox charPicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PlayerNameLBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPlayerLevel;
        private System.Windows.Forms.ProgressBar HealthPB;
        private System.Windows.Forms.ProgressBar SanityPB;
        private System.Windows.Forms.ProgressBar IntPB;
        private System.Windows.Forms.ProgressBar DexPB;
        private System.Windows.Forms.ProgressBar StrengthPB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar expPB;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelMainstory;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnChoiceThree;
        private System.Windows.Forms.Button btnChoiceTwo;
        private System.Windows.Forms.Button btnChoiceOne;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelIint;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelDex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label labelSanity;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Button btnTestExpiGen;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label labelWherePlayerID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnTestMinusSanity;
        private System.Windows.Forms.Button btnKIllsme;
    }
}