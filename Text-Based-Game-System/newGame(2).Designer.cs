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
            this.MaleBTN = new System.Windows.Forms.Button();
            this.FemaleBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxChar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxChar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChar
            // 
            this.txtChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChar.Location = new System.Drawing.Point(62, 294);
            this.txtChar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChar.Multiline = true;
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(270, 43);
            this.txtChar.TabIndex = 2;
            // 
            // btnBeginStory
            // 
            this.btnBeginStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginStory.Location = new System.Drawing.Point(125, 366);
            this.btnBeginStory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBeginStory.Name = "btnBeginStory";
            this.btnBeginStory.Size = new System.Drawing.Size(147, 39);
            this.btnBeginStory.TabIndex = 3;
            this.btnBeginStory.Text = "Begin Story";
            this.btnBeginStory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Character";
            // 
            // picboxChar2
            // 
            this.picboxChar2.Image = global::Text_Based_Game_System.Properties.Resources.female1;
            this.picboxChar2.Location = new System.Drawing.Point(212, 66);
            this.picboxChar2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picboxChar2.Name = "picboxChar2";
            this.picboxChar2.Size = new System.Drawing.Size(150, 162);
            this.picboxChar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxChar2.TabIndex = 1;
            this.picboxChar2.TabStop = false;
            // 
            // picboxChar1
            // 
            this.picboxChar1.Image = global::Text_Based_Game_System.Properties.Resources.male1;
            this.picboxChar1.Location = new System.Drawing.Point(30, 66);
            this.picboxChar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picboxChar1.Name = "picboxChar1";
            this.picboxChar1.Size = new System.Drawing.Size(150, 162);
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
            this.btnBack1.Location = new System.Drawing.Point(9, 10);
            this.btnBack1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(49, 39);
            this.btnBack1.TabIndex = 30;
            this.btnBack1.Text = "⬅";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // MaleBTN
            // 
            this.MaleBTN.Location = new System.Drawing.Point(47, 233);
            this.MaleBTN.Name = "MaleBTN";
            this.MaleBTN.Size = new System.Drawing.Size(118, 31);
            this.MaleBTN.TabIndex = 31;
            this.MaleBTN.Text = "Male";
            this.MaleBTN.UseVisualStyleBackColor = true;
            // 
            // FemaleBTN
            // 
            this.FemaleBTN.Location = new System.Drawing.Point(228, 233);
            this.FemaleBTN.Name = "FemaleBTN";
            this.FemaleBTN.Size = new System.Drawing.Size(118, 31);
            this.FemaleBTN.TabIndex = 32;
            this.FemaleBTN.Text = "Female";
            this.FemaleBTN.UseVisualStyleBackColor = true;
            // 
            // newGame_2_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 433);
            this.Controls.Add(this.FemaleBTN);
            this.Controls.Add(this.MaleBTN);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBeginStory);
            this.Controls.Add(this.txtChar);
            this.Controls.Add(this.picboxChar2);
            this.Controls.Add(this.picboxChar1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "newGame_2_";
            this.Text = "newGame_2_";
            this.Load += new System.EventHandler(this.newGame_2__Load);
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
        private System.Windows.Forms.Button MaleBTN;
        private System.Windows.Forms.Button FemaleBTN;
    }
}