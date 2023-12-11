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
            this.charPic1 = new System.Windows.Forms.PictureBox();
            this.charPic2 = new System.Windows.Forms.PictureBox();
            this.charTb = new System.Windows.Forms.TextBox();
            this.beginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.charPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPic2)).BeginInit();
            this.SuspendLayout();
            // 
            // charPic1
            // 
            this.charPic1.Location = new System.Drawing.Point(40, 81);
            this.charPic1.Name = "charPic1";
            this.charPic1.Size = new System.Drawing.Size(200, 200);
            this.charPic1.TabIndex = 0;
            this.charPic1.TabStop = false;
            // 
            // charPic2
            // 
            this.charPic2.Location = new System.Drawing.Point(282, 81);
            this.charPic2.Name = "charPic2";
            this.charPic2.Size = new System.Drawing.Size(200, 200);
            this.charPic2.TabIndex = 1;
            this.charPic2.TabStop = false;
            // 
            // charTb
            // 
            this.charTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charTb.Location = new System.Drawing.Point(81, 307);
            this.charTb.Multiline = true;
            this.charTb.Name = "charTb";
            this.charTb.Size = new System.Drawing.Size(359, 52);
            this.charTb.TabIndex = 2;
            // 
            // beginBtn
            // 
            this.beginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginBtn.Location = new System.Drawing.Point(163, 382);
            this.beginBtn.Name = "beginBtn";
            this.beginBtn.Size = new System.Drawing.Size(196, 48);
            this.beginBtn.TabIndex = 3;
            this.beginBtn.Text = "Begin Story";
            this.beginBtn.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.beginBtn);
            this.Controls.Add(this.charTb);
            this.Controls.Add(this.charPic2);
            this.Controls.Add(this.charPic1);
            this.Name = "newGame_2_";
            this.Text = "newGame_2_";
            ((System.ComponentModel.ISupportInitialize)(this.charPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox charPic1;
        private System.Windows.Forms.PictureBox charPic2;
        private System.Windows.Forms.TextBox charTb;
        private System.Windows.Forms.Button beginBtn;
        private System.Windows.Forms.Label label1;
    }
}