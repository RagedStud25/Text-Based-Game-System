namespace Text_Based_Game_System
{
    partial class frmSave
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
            this.lblFirstSaveSlot = new System.Windows.Forms.Label();
            this.lblSecondSaveSlot = new System.Windows.Forms.Label();
            this.lblThirdSaveSlot = new System.Windows.Forms.Label();
            this.btnSaveYourGame = new System.Windows.Forms.Button();
            this.tbSlotOne = new System.Windows.Forms.TextBox();
            this.tbSlotTwo = new System.Windows.Forms.TextBox();
            this.tbSlotThree = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstSaveSlot
            // 
            this.lblFirstSaveSlot.AutoSize = true;
            this.lblFirstSaveSlot.Location = new System.Drawing.Point(12, 9);
            this.lblFirstSaveSlot.MaximumSize = new System.Drawing.Size(200, 400);
            this.lblFirstSaveSlot.MinimumSize = new System.Drawing.Size(200, 400);
            this.lblFirstSaveSlot.Name = "lblFirstSaveSlot";
            this.lblFirstSaveSlot.Size = new System.Drawing.Size(200, 400);
            this.lblFirstSaveSlot.TabIndex = 0;
            this.lblFirstSaveSlot.Text = "1";
            // 
            // lblSecondSaveSlot
            // 
            this.lblSecondSaveSlot.AutoSize = true;
            this.lblSecondSaveSlot.Location = new System.Drawing.Point(218, 9);
            this.lblSecondSaveSlot.MaximumSize = new System.Drawing.Size(200, 400);
            this.lblSecondSaveSlot.MinimumSize = new System.Drawing.Size(200, 400);
            this.lblSecondSaveSlot.Name = "lblSecondSaveSlot";
            this.lblSecondSaveSlot.Size = new System.Drawing.Size(200, 400);
            this.lblSecondSaveSlot.TabIndex = 1;
            this.lblSecondSaveSlot.Text = "2";
            // 
            // lblThirdSaveSlot
            // 
            this.lblThirdSaveSlot.AutoSize = true;
            this.lblThirdSaveSlot.Location = new System.Drawing.Point(424, 9);
            this.lblThirdSaveSlot.MaximumSize = new System.Drawing.Size(200, 400);
            this.lblThirdSaveSlot.MinimumSize = new System.Drawing.Size(200, 400);
            this.lblThirdSaveSlot.Name = "lblThirdSaveSlot";
            this.lblThirdSaveSlot.Size = new System.Drawing.Size(200, 400);
            this.lblThirdSaveSlot.TabIndex = 2;
            this.lblThirdSaveSlot.Text = "3";
            // 
            // btnSaveYourGame
            // 
            this.btnSaveYourGame.Location = new System.Drawing.Point(222, 422);
            this.btnSaveYourGame.Name = "btnSaveYourGame";
            this.btnSaveYourGame.Size = new System.Drawing.Size(196, 48);
            this.btnSaveYourGame.TabIndex = 3;
            this.btnSaveYourGame.Text = "SAVE YOUR GAME";
            this.btnSaveYourGame.UseVisualStyleBackColor = true;
            this.btnSaveYourGame.Click += new System.EventHandler(this.btnSaveYourGame_Click);
            // 
            // tbSlotOne
            // 
            this.tbSlotOne.Location = new System.Drawing.Point(12, 383);
            this.tbSlotOne.Name = "tbSlotOne";
            this.tbSlotOne.Size = new System.Drawing.Size(200, 26);
            this.tbSlotOne.TabIndex = 4;
            this.tbSlotOne.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxForInput_KeyDown);
            // 
            // tbSlotTwo
            // 
            this.tbSlotTwo.Location = new System.Drawing.Point(218, 383);
            this.tbSlotTwo.Name = "tbSlotTwo";
            this.tbSlotTwo.Size = new System.Drawing.Size(200, 26);
            this.tbSlotTwo.TabIndex = 5;
            // 
            // tbSlotThree
            // 
            this.tbSlotThree.Location = new System.Drawing.Point(424, 383);
            this.tbSlotThree.Name = "tbSlotThree";
            this.tbSlotThree.Size = new System.Drawing.Size(200, 26);
            this.tbSlotThree.TabIndex = 6;
            // 
            // frmSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 482);
            this.Controls.Add(this.tbSlotThree);
            this.Controls.Add(this.tbSlotTwo);
            this.Controls.Add(this.tbSlotOne);
            this.Controls.Add(this.btnSaveYourGame);
            this.Controls.Add(this.lblThirdSaveSlot);
            this.Controls.Add(this.lblSecondSaveSlot);
            this.Controls.Add(this.lblFirstSaveSlot);
            this.Name = "frmSave";
            this.Text = "SAVE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstSaveSlot;
        private System.Windows.Forms.Label lblSecondSaveSlot;
        private System.Windows.Forms.Label lblThirdSaveSlot;
        private System.Windows.Forms.Button btnSaveYourGame;
        private System.Windows.Forms.TextBox tbSlotOne;
        private System.Windows.Forms.TextBox tbSlotTwo;
        private System.Windows.Forms.TextBox tbSlotThree;
    }
}