namespace FirstApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.TbxFirstName = new System.Windows.Forms.TextBox();
            this.TbxLastName = new System.Windows.Forms.TextBox();
            this.TbxTemp = new System.Windows.Forms.TextBox();
            this.TbxMark = new System.Windows.Forms.TextBox();
            this.CbxGuess = new System.Windows.Forms.ComboBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnGradeBasedOnMark = new System.Windows.Forms.Button();
            this.BtnPlayGuessingGame = new System.Windows.Forms.Button();
            this.BtnGuessingGame_P = new System.Windows.Forms.Button();
            this.BtnPlayBadDice = new System.Windows.Forms.Button();
            this.BtnPlayBetterDice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(24, 49);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(177, 26);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Enter First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(24, 95);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(176, 26);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Enter Last Name";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTemperature.Location = new System.Drawing.Point(24, 138);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(193, 26);
            this.lblTemperature.TabIndex = 2;
            this.lblTemperature.Text = "Enter Temperature";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMark.Location = new System.Drawing.Point(24, 182);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(118, 26);
            this.lblMark.TabIndex = 3;
            this.lblMark.Text = "Enter Mark";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGuess.Location = new System.Drawing.Point(24, 225);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(133, 26);
            this.lblGuess.TabIndex = 4;
            this.lblGuess.Text = "Enter Guess";
            // 
            // TbxFirstName
            // 
            this.TbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbxFirstName.Location = new System.Drawing.Point(220, 46);
            this.TbxFirstName.Name = "TbxFirstName";
            this.TbxFirstName.Size = new System.Drawing.Size(191, 32);
            this.TbxFirstName.TabIndex = 5;
            // 
            // TbxLastName
            // 
            this.TbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbxLastName.Location = new System.Drawing.Point(220, 92);
            this.TbxLastName.Name = "TbxLastName";
            this.TbxLastName.Size = new System.Drawing.Size(191, 32);
            this.TbxLastName.TabIndex = 6;
            // 
            // TbxTemp
            // 
            this.TbxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbxTemp.Location = new System.Drawing.Point(220, 137);
            this.TbxTemp.Name = "TbxTemp";
            this.TbxTemp.Size = new System.Drawing.Size(191, 32);
            this.TbxTemp.TabIndex = 7;
            // 
            // TbxMark
            // 
            this.TbxMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbxMark.Location = new System.Drawing.Point(220, 181);
            this.TbxMark.Name = "TbxMark";
            this.TbxMark.Size = new System.Drawing.Size(191, 32);
            this.TbxMark.TabIndex = 8;
            // 
            // CbxGuess
            // 
            this.CbxGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxGuess.FormattingEnabled = true;
            this.CbxGuess.Location = new System.Drawing.Point(220, 222);
            this.CbxGuess.Name = "CbxGuess";
            this.CbxGuess.Size = new System.Drawing.Size(191, 33);
            this.CbxGuess.TabIndex = 9;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPlay.Location = new System.Drawing.Point(446, 135);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(263, 40);
            this.BtnPlay.TabIndex = 10;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnGradeBasedOnMark
            // 
            this.BtnGradeBasedOnMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGradeBasedOnMark.Location = new System.Drawing.Point(446, 181);
            this.BtnGradeBasedOnMark.Name = "BtnGradeBasedOnMark";
            this.BtnGradeBasedOnMark.Size = new System.Drawing.Size(263, 38);
            this.BtnGradeBasedOnMark.TabIndex = 11;
            this.BtnGradeBasedOnMark.Text = "Grade based on Mark";
            this.BtnGradeBasedOnMark.UseVisualStyleBackColor = true;
            this.BtnGradeBasedOnMark.Click += new System.EventHandler(this.BtnGradeBasedOnMark_Click);
            // 
            // BtnPlayGuessingGame
            // 
            this.BtnPlayGuessingGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPlayGuessingGame.Location = new System.Drawing.Point(446, 222);
            this.BtnPlayGuessingGame.Name = "BtnPlayGuessingGame";
            this.BtnPlayGuessingGame.Size = new System.Drawing.Size(263, 38);
            this.BtnPlayGuessingGame.TabIndex = 12;
            this.BtnPlayGuessingGame.Text = "Play Guessing Game V1";
            this.BtnPlayGuessingGame.UseVisualStyleBackColor = true;
            this.BtnPlayGuessingGame.Click += new System.EventHandler(this.BtnPlayGuessingGame_Click);
            // 
            // BtnGuessingGame_P
            // 
            this.BtnGuessingGame_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGuessingGame_P.Location = new System.Drawing.Point(100, 293);
            this.BtnGuessingGame_P.Name = "BtnGuessingGame_P";
            this.BtnGuessingGame_P.Size = new System.Drawing.Size(278, 34);
            this.BtnGuessingGame_P.TabIndex = 13;
            this.BtnGuessingGame_P.Text = "Play Guessing Game P";
            this.BtnGuessingGame_P.UseVisualStyleBackColor = true;
            this.BtnGuessingGame_P.Click += new System.EventHandler(this.BtnGuessingGame_P_Click);
            // 
            // BtnPlayBadDice
            // 
            this.BtnPlayBadDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPlayBadDice.Location = new System.Drawing.Point(100, 333);
            this.BtnPlayBadDice.Name = "BtnPlayBadDice";
            this.BtnPlayBadDice.Size = new System.Drawing.Size(278, 34);
            this.BtnPlayBadDice.TabIndex = 14;
            this.BtnPlayBadDice.Text = "Play Bad Dice Game";
            this.BtnPlayBadDice.UseVisualStyleBackColor = true;
            // 
            // BtnPlayBetterDice
            // 
            this.BtnPlayBetterDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPlayBetterDice.Location = new System.Drawing.Point(100, 373);
            this.BtnPlayBetterDice.Name = "BtnPlayBetterDice";
            this.BtnPlayBetterDice.Size = new System.Drawing.Size(278, 34);
            this.BtnPlayBetterDice.TabIndex = 15;
            this.BtnPlayBetterDice.Text = "Play 6 Sided Dice Game";
            this.BtnPlayBetterDice.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPlayBetterDice);
            this.Controls.Add(this.BtnPlayBadDice);
            this.Controls.Add(this.BtnGuessingGame_P);
            this.Controls.Add(this.BtnPlayGuessingGame);
            this.Controls.Add(this.BtnGradeBasedOnMark);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.CbxGuess);
            this.Controls.Add(this.TbxMark);
            this.Controls.Add(this.TbxTemp);
            this.Controls.Add(this.TbxLastName);
            this.Controls.Add(this.TbxFirstName);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblTemperature;
        private Label lblMark;
        private Label lblGuess;
        private TextBox TbxFirstName;
        private TextBox TbxLastName;
        private TextBox TbxTemp;
        private TextBox TbxMark;
        private ComboBox CbxGuess;
        private Button BtnPlay;
        private Button BtnGradeBasedOnMark;
        private Button BtnPlayGuessingGame;
        private Button BtnGuessingGame_P;
        private Button BtnPlayBadDice;
        private Button BtnPlayBetterDice;
    }
}