namespace Text_Based_Game_System
{
    partial class levelUpBoxUserForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.labelPointsSpendSTR = new System.Windows.Forms.Label();
            this.btnSubstractSTR = new System.Windows.Forms.Button();
            this.btnIncreaseSTR = new System.Windows.Forms.Button();
            this.labelDex = new System.Windows.Forms.Label();
            this.labelInt = new System.Windows.Forms.Label();
            this.labelStr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPointsToSpend = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(376, 366);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(131, 44);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // labelPointsSpendSTR
            // 
            this.labelPointsSpendSTR.AutoSize = true;
            this.labelPointsSpendSTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointsSpendSTR.Location = new System.Drawing.Point(370, 119);
            this.labelPointsSpendSTR.Name = "labelPointsSpendSTR";
            this.labelPointsSpendSTR.Size = new System.Drawing.Size(32, 36);
            this.labelPointsSpendSTR.TabIndex = 24;
            this.labelPointsSpendSTR.Text = "0";
            // 
            // btnSubstractSTR
            // 
            this.btnSubstractSTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstractSTR.Location = new System.Drawing.Point(302, 117);
            this.btnSubstractSTR.Name = "btnSubstractSTR";
            this.btnSubstractSTR.Size = new System.Drawing.Size(50, 38);
            this.btnSubstractSTR.TabIndex = 23;
            this.btnSubstractSTR.Text = "-";
            this.btnSubstractSTR.UseVisualStyleBackColor = true;
            this.btnSubstractSTR.Click += new System.EventHandler(this.btnSubstractSTR_Click);
            // 
            // btnIncreaseSTR
            // 
            this.btnIncreaseSTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseSTR.Location = new System.Drawing.Point(419, 117);
            this.btnIncreaseSTR.Name = "btnIncreaseSTR";
            this.btnIncreaseSTR.Size = new System.Drawing.Size(50, 38);
            this.btnIncreaseSTR.TabIndex = 22;
            this.btnIncreaseSTR.Text = "+";
            this.btnIncreaseSTR.UseVisualStyleBackColor = true;
            this.btnIncreaseSTR.Click += new System.EventHandler(this.btnIncreaseSTR_Click);
            // 
            // labelDex
            // 
            this.labelDex.AutoSize = true;
            this.labelDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDex.Location = new System.Drawing.Point(141, 185);
            this.labelDex.Name = "labelDex";
            this.labelDex.Size = new System.Drawing.Size(32, 36);
            this.labelDex.TabIndex = 21;
            this.labelDex.Text = "0";
            // 
            // labelInt
            // 
            this.labelInt.AutoSize = true;
            this.labelInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInt.Location = new System.Drawing.Point(141, 119);
            this.labelInt.Name = "labelInt";
            this.labelInt.Size = new System.Drawing.Size(32, 36);
            this.labelInt.TabIndex = 20;
            this.labelInt.Text = "0";
            // 
            // labelStr
            // 
            this.labelStr.AutoSize = true;
            this.labelStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStr.Location = new System.Drawing.Point(141, 244);
            this.labelStr.Name = "labelStr";
            this.labelStr.Size = new System.Drawing.Size(32, 36);
            this.labelStr.TabIndex = 19;
            this.labelStr.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 36);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "Int:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Str:";
            // 
            // labelPointsToSpend
            // 
            this.labelPointsToSpend.AutoSize = true;
            this.labelPointsToSpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointsToSpend.Location = new System.Drawing.Point(296, 318);
            this.labelPointsToSpend.Name = "labelPointsToSpend";
            this.labelPointsToSpend.Size = new System.Drawing.Size(32, 36);
            this.labelPointsToSpend.TabIndex = 15;
            this.labelPointsToSpend.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Points to spend:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 58);
            this.label1.TabIndex = 13;
            this.label1.Text = "You just leveled up!";
            // 
            // levelUpBoxUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labelPointsSpendSTR);
            this.Controls.Add(this.btnSubstractSTR);
            this.Controls.Add(this.btnIncreaseSTR);
            this.Controls.Add(this.labelDex);
            this.Controls.Add(this.labelInt);
            this.Controls.Add(this.labelStr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPointsToSpend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "levelUpBoxUserForm";
            this.Text = "levelUpBoxUserForm";
            this.Load += new System.EventHandler(this.frmloadLevelUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label labelPointsSpendSTR;
        private System.Windows.Forms.Button btnSubstractSTR;
        private System.Windows.Forms.Button btnIncreaseSTR;
        private System.Windows.Forms.Label labelDex;
        private System.Windows.Forms.Label labelInt;
        private System.Windows.Forms.Label labelStr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPointsToSpend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}