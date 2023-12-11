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
            this.picboxChar1 = new System.Windows.Forms.PictureBox();
            this.picboxChar2 = new System.Windows.Forms.PictureBox();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.btnBeginStory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxChar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxChar2)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxChar1
            // 
            this.picboxChar1.Location = new System.Drawing.Point(40, 81);
            this.picboxChar1.Name = "picboxChar1";
            this.picboxChar1.Size = new System.Drawing.Size(200, 200);
            this.picboxChar1.TabIndex = 0;
            this.picboxChar1.TabStop = false;
            // 
            // picboxChar2
            // 
            this.picboxChar2.Location = new System.Drawing.Point(282, 81);
            this.picboxChar2.Name = "picboxChar2";
            this.picboxChar2.Size = new System.Drawing.Size(200, 200);
            this.picboxChar2.TabIndex = 1;
            this.picboxChar2.TabStop = false;
            // 
            // txtChar
            // 
            this.txtChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChar.Location = new System.Drawing.Point(81, 307);
            this.txtChar.Multiline = true;
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(359, 52);
            this.txtChar.TabIndex = 2;
            // 
            // btnBeginStory
            // 
            this.btnBeginStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginStory.Location = new System.Drawing.Point(163, 382);
            this.btnBeginStory.Name = "btnBeginStory";
            this.btnBeginStory.Size = new System.Drawing.Size(196, 48);
            this.btnBeginStory.TabIndex = 3;
            this.btnBeginStory.Text = "Begin Story";
            this.btnBeginStory.UseVisualStyleBackColor = true;
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
            // newGame_2_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBeginStory);
            this.Controls.Add(this.txtChar);
            this.Controls.Add(this.picboxChar2);
            this.Controls.Add(this.picboxChar1);
            this.Name = "newGame_2_";
            this.Text = "newGame_2_";
            ((System.ComponentModel.ISupportInitialize)(this.picboxChar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxChar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxChar1;
        private System.Windows.Forms.PictureBox picboxChar2;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.Button btnBeginStory;
        private System.Windows.Forms.Label label1;
    }
}