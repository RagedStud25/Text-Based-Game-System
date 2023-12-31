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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelMainstory = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnChoiceOne = new System.Windows.Forms.Button();
            this.btnChoiceTwo = new System.Windows.Forms.Button();
            this.btnChoiceThree = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.charPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // borderPlayer1
            // 
            this.borderPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.borderPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderPlayer1.Location = new System.Drawing.Point(1, 0);
            this.borderPlayer1.Name = "borderPlayer1";
            this.borderPlayer1.Size = new System.Drawing.Size(810, 208);
            this.borderPlayer1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Health:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sanity:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PlayerNameLBL
            // 
            this.PlayerNameLBL.AutoSize = true;
            this.PlayerNameLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameLBL.Location = new System.Drawing.Point(185, 20);
            this.PlayerNameLBL.Name = "PlayerNameLBL";
            this.PlayerNameLBL.Size = new System.Drawing.Size(172, 34);
            this.PlayerNameLBL.TabIndex = 21;
            this.PlayerNameLBL.Text = "PlayerName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Strength:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Dexterity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Intelligence:";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Showcard Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.Location = new System.Drawing.Point(739, 10);
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
            this.label7.Location = new System.Drawing.Point(187, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Level:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelPlayerLevel
            // 
            this.labelPlayerLevel.AutoSize = true;
            this.labelPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerLevel.Location = new System.Drawing.Point(267, 156);
            this.labelPlayerLevel.Name = "labelPlayerLevel";
            this.labelPlayerLevel.Size = new System.Drawing.Size(23, 25);
            this.labelPlayerLevel.TabIndex = 30;
            this.labelPlayerLevel.Text = "3";
            // 
            // charPicBox
            // 
            this.charPicBox.Location = new System.Drawing.Point(29, 20);
            this.charPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charPicBox.Name = "charPicBox";
            this.charPicBox.Size = new System.Drawing.Size(133, 121);
            this.charPicBox.TabIndex = 16;
            this.charPicBox.TabStop = false;
            // 
            // HealthPB
            // 
            this.HealthPB.Location = new System.Drawing.Point(272, 57);
            this.HealthPB.Margin = new System.Windows.Forms.Padding(4);
            this.HealthPB.Name = "HealthPB";
            this.HealthPB.Size = new System.Drawing.Size(133, 28);
            this.HealthPB.TabIndex = 31;
            this.HealthPB.Value = 100;
            // 
            // SanityPB
            // 
            this.SanityPB.Location = new System.Drawing.Point(272, 92);
            this.SanityPB.Margin = new System.Windows.Forms.Padding(4);
            this.SanityPB.Name = "SanityPB";
            this.SanityPB.Size = new System.Drawing.Size(133, 28);
            this.SanityPB.TabIndex = 32;
            this.SanityPB.Value = 89;
            // 
            // IntPB
            // 
            this.IntPB.Location = new System.Drawing.Point(656, 33);
            this.IntPB.Margin = new System.Windows.Forms.Padding(4);
            this.IntPB.Name = "IntPB";
            this.IntPB.Size = new System.Drawing.Size(91, 25);
            this.IntPB.TabIndex = 33;
            this.IntPB.Value = 21;
            // 
            // DexPB
            // 
            this.DexPB.Location = new System.Drawing.Point(656, 71);
            this.DexPB.Margin = new System.Windows.Forms.Padding(4);
            this.DexPB.Name = "DexPB";
            this.DexPB.Size = new System.Drawing.Size(91, 25);
            this.DexPB.TabIndex = 34;
            this.DexPB.Value = 100;
            // 
            // StrengthPB
            // 
            this.StrengthPB.Location = new System.Drawing.Point(656, 110);
            this.StrengthPB.Margin = new System.Windows.Forms.Padding(4);
            this.StrengthPB.Name = "StrengthPB";
            this.StrengthPB.Size = new System.Drawing.Size(91, 25);
            this.StrengthPB.TabIndex = 35;
            this.StrengthPB.Value = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Exp:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(272, 124);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 28);
            this.progressBar1.TabIndex = 37;
            this.progressBar1.Value = 35;
            // 
            // labelMainstory
            // 
            this.labelMainstory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainstory.Location = new System.Drawing.Point(26, 238);
            this.labelMainstory.Name = "labelMainstory";
            this.labelMainstory.Size = new System.Drawing.Size(760, 318);
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
            this.btnChoiceOne.Location = new System.Drawing.Point(31, 599);
            this.btnChoiceOne.Name = "btnChoiceOne";
            this.btnChoiceOne.Size = new System.Drawing.Size(229, 94);
            this.btnChoiceOne.TabIndex = 39;
            this.btnChoiceOne.Text = "Choice A";
            this.btnChoiceOne.UseVisualStyleBackColor = true;
            // 
            // btnChoiceTwo
            // 
            this.btnChoiceTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceTwo.Location = new System.Drawing.Point(296, 599);
            this.btnChoiceTwo.Name = "btnChoiceTwo";
            this.btnChoiceTwo.Size = new System.Drawing.Size(229, 94);
            this.btnChoiceTwo.TabIndex = 40;
            this.btnChoiceTwo.Text = "Choice B";
            this.btnChoiceTwo.UseVisualStyleBackColor = true;
            // 
            // btnChoiceThree
            // 
            this.btnChoiceThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceThree.Location = new System.Drawing.Point(557, 599);
            this.btnChoiceThree.Name = "btnChoiceThree";
            this.btnChoiceThree.Size = new System.Drawing.Size(229, 94);
            this.btnChoiceThree.TabIndex = 41;
            this.btnChoiceThree.Text = "Choice C";
            this.btnChoiceThree.UseVisualStyleBackColor = true;
            // 
            // mainGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 705);
            this.Controls.Add(this.btnChoiceThree);
            this.Controls.Add(this.btnChoiceTwo);
            this.Controls.Add(this.btnChoiceOne);
            this.Controls.Add(this.labelMainstory);
            this.Controls.Add(this.progressBar1);
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelMainstory;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnChoiceThree;
        private System.Windows.Forms.Button btnChoiceTwo;
        private System.Windows.Forms.Button btnChoiceOne;
    }
}