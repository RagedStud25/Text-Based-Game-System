namespace Text_Based_Game_System
{
    partial class newGame_2_
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
            this.txtChar = new System.Windows.Forms.TextBox();
            this.btnBeginStory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxChar2 = new System.Windows.Forms.PictureBox();
            this.picboxChar1 = new System.Windows.Forms.PictureBox();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.radBtnMale = new System.Windows.Forms.RadioButton();
            this.radBtnFemale = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picboxChar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxChar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChar
            // 
            this.txtChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChar.Location = new System.Drawing.Point(77, 339);
            this.txtChar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChar.Multiline = true;
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(359, 52);
            this.txtChar.TabIndex = 2;
            // 
            // btnBeginStory
            // 
            this.btnBeginStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginStory.Location = new System.Drawing.Point(151, 414);
            this.btnBeginStory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBeginStory.Name = "btnBeginStory";
            this.btnBeginStory.Size = new System.Drawing.Size(196, 48);
            this.btnBeginStory.TabIndex = 3;
            this.btnBeginStory.Text = "Begin Story";
            this.btnBeginStory.UseVisualStyleBackColor = true;
            this.btnBeginStory.Click += new System.EventHandler(this.btnBeginStory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Character";
            // 
            // picboxChar2
            // 
            this.picboxChar2.Image = global::Text_Based_Game_System.Properties.Resources.female1;
            this.picboxChar2.Location = new System.Drawing.Point(283, 81);
            this.picboxChar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxChar2.Name = "picboxChar2";
            this.picboxChar2.Size = new System.Drawing.Size(200, 199);
            this.picboxChar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxChar2.TabIndex = 1;
            this.picboxChar2.TabStop = false;
            // 
            // picboxChar1
            // 
            this.picboxChar1.Image = global::Text_Based_Game_System.Properties.Resources.male1;
            this.picboxChar1.Location = new System.Drawing.Point(40, 81);
            this.picboxChar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxChar1.Name = "picboxChar1";
            this.picboxChar1.Size = new System.Drawing.Size(200, 199);
            this.picboxChar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxChar1.TabIndex = 0;
            this.picboxChar1.TabStop = false;
            // 
            // btnBack1
            // 
            this.btnBack1.BackColor = System.Drawing.Color.Transparent;
            this.btnBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack1.FlatAppearance.BorderSize = 0;
            this.btnBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.Location = new System.Drawing.Point(12, 12);
            this.btnBack1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(65, 48);
            this.btnBack1.TabIndex = 30;
            this.btnBack1.Text = "⬅";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // radBtnMale
            // 
            this.radBtnMale.AutoSize = true;
            this.radBtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnMale.Location = new System.Drawing.Point(104, 296);
            this.radBtnMale.Name = "radBtnMale";
            this.radBtnMale.Size = new System.Drawing.Size(66, 24);
            this.radBtnMale.TabIndex = 33;
            this.radBtnMale.TabStop = true;
            this.radBtnMale.Text = "Male";
            this.radBtnMale.UseVisualStyleBackColor = true;
            // 
            // radBtnFemale
            // 
            this.radBtnFemale.AutoSize = true;
            this.radBtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnFemale.Location = new System.Drawing.Point(337, 296);
            this.radBtnFemale.Name = "radBtnFemale";
            this.radBtnFemale.Size = new System.Drawing.Size(85, 24);
            this.radBtnFemale.TabIndex = 34;
            this.radBtnFemale.TabStop = true;
            this.radBtnFemale.Text = "Female";
            this.radBtnFemale.UseVisualStyleBackColor = true;
            // 
            // newGame_2_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 491);
            this.Controls.Add(this.radBtnFemale);
            this.Controls.Add(this.radBtnMale);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBeginStory);
            this.Controls.Add(this.txtChar);
            this.Controls.Add(this.picboxChar2);
            this.Controls.Add(this.picboxChar1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "newGame_2_";
            this.Text = "newGame_2_";
            ((System.ComponentModel.ISupportInitialize)(this.picboxChar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxChar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxChar1;
        private System.Windows.Forms.PictureBox picboxChar2;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.Button btnBeginStory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.RadioButton radBtnMale;
        private System.Windows.Forms.RadioButton radBtnFemale;
    }
}