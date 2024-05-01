namespace FirstApp
{
    partial class FrmGameAppV2
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
            this.LsvGameStatistics = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.LblPlayerScore0 = new System.Windows.Forms.Label();
            this.LblComputerScore0 = new System.Windows.Forms.Label();
            this.LblPlayerScore = new System.Windows.Forms.Label();
            this.LblComputerScore = new System.Windows.Forms.Label();
            this.LblPickGame = new System.Windows.Forms.Label();
            this.LblEnterName = new System.Windows.Forms.Label();
            this.CbxGame = new System.Windows.Forms.ComboBox();
            this.TbxPlayersName = new System.Windows.Forms.TextBox();
            this.BtnFindOverallWinner = new System.Windows.Forms.Button();
            this.BtnPlayGame = new System.Windows.Forms.Button();
            this.MainDeck = new System.Windows.Forms.GroupBox();
            this.LblPlayersHand = new System.Windows.Forms.Label();
            this.LblComputersHand = new System.Windows.Forms.Label();
            this.LsvComputersHand = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.BtnStand = new System.Windows.Forms.Button();
            this.BtnHit = new System.Windows.Forms.Button();
            this.LsvPlayersHand = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.LvlOverallGameResults = new System.Windows.Forms.Label();
            this.MainDeck.SuspendLayout();
            this.SuspendLayout();
            // 
            // LsvGameStatistics
            // 
            this.LsvGameStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LsvGameStatistics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsvGameStatistics.GridLines = true;
            this.LsvGameStatistics.Location = new System.Drawing.Point(43, 434);
            this.LsvGameStatistics.Name = "LsvGameStatistics";
            this.LsvGameStatistics.Size = new System.Drawing.Size(662, 150);
            this.LsvGameStatistics.TabIndex = 21;
            this.LsvGameStatistics.UseCompatibleStateImageBehavior = false;
            this.LsvGameStatistics.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Game Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Players Score";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Computers Score";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Winner";
            this.columnHeader4.Width = 100;
            // 
            // LblPlayerScore0
            // 
            this.LblPlayerScore0.AutoSize = true;
            this.LblPlayerScore0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPlayerScore0.Location = new System.Drawing.Point(382, 116);
            this.LblPlayerScore0.Name = "LblPlayerScore0";
            this.LblPlayerScore0.Size = new System.Drawing.Size(19, 21);
            this.LblPlayerScore0.TabIndex = 20;
            this.LblPlayerScore0.Text = "0";
            // 
            // LblComputerScore0
            // 
            this.LblComputerScore0.AutoSize = true;
            this.LblComputerScore0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblComputerScore0.Location = new System.Drawing.Point(382, 95);
            this.LblComputerScore0.Name = "LblComputerScore0";
            this.LblComputerScore0.Size = new System.Drawing.Size(19, 21);
            this.LblComputerScore0.TabIndex = 19;
            this.LblComputerScore0.Text = "0";
            // 
            // LblPlayerScore
            // 
            this.LblPlayerScore.AutoSize = true;
            this.LblPlayerScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPlayerScore.Location = new System.Drawing.Point(253, 116);
            this.LblPlayerScore.Name = "LblPlayerScore";
            this.LblPlayerScore.Size = new System.Drawing.Size(96, 21);
            this.LblPlayerScore.TabIndex = 18;
            this.LblPlayerScore.Text = "Player Score";
            // 
            // LblComputerScore
            // 
            this.LblComputerScore.AutoSize = true;
            this.LblComputerScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblComputerScore.Location = new System.Drawing.Point(253, 95);
            this.LblComputerScore.Name = "LblComputerScore";
            this.LblComputerScore.Size = new System.Drawing.Size(123, 21);
            this.LblComputerScore.TabIndex = 17;
            this.LblComputerScore.Text = "Computer Score";
            // 
            // LblPickGame
            // 
            this.LblPickGame.AutoSize = true;
            this.LblPickGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPickGame.Location = new System.Drawing.Point(69, 72);
            this.LblPickGame.Name = "LblPickGame";
            this.LblPickGame.Size = new System.Drawing.Size(83, 21);
            this.LblPickGame.TabIndex = 16;
            this.LblPickGame.Text = "Pick Game";
            // 
            // LblEnterName
            // 
            this.LblEnterName.AutoSize = true;
            this.LblEnterName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEnterName.Location = new System.Drawing.Point(69, 30);
            this.LblEnterName.Name = "LblEnterName";
            this.LblEnterName.Size = new System.Drawing.Size(92, 21);
            this.LblEnterName.TabIndex = 15;
            this.LblEnterName.Text = "Enter Name";
            // 
            // CbxGame
            // 
            this.CbxGame.FormattingEnabled = true;
            this.CbxGame.Location = new System.Drawing.Point(165, 69);
            this.CbxGame.Name = "CbxGame";
            this.CbxGame.Size = new System.Drawing.Size(192, 23);
            this.CbxGame.TabIndex = 14;
            // 
            // TbxPlayersName
            // 
            this.TbxPlayersName.Location = new System.Drawing.Point(165, 27);
            this.TbxPlayersName.Name = "TbxPlayersName";
            this.TbxPlayersName.Size = new System.Drawing.Size(192, 23);
            this.TbxPlayersName.TabIndex = 13;
            // 
            // BtnFindOverallWinner
            // 
            this.BtnFindOverallWinner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFindOverallWinner.Location = new System.Drawing.Point(43, 590);
            this.BtnFindOverallWinner.Name = "BtnFindOverallWinner";
            this.BtnFindOverallWinner.Size = new System.Drawing.Size(211, 31);
            this.BtnFindOverallWinner.TabIndex = 12;
            this.BtnFindOverallWinner.Text = "Find Overall Winner";
            this.BtnFindOverallWinner.UseVisualStyleBackColor = true;
            // 
            // BtnPlayGame
            // 
            this.BtnPlayGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPlayGame.Location = new System.Drawing.Point(69, 116);
            this.BtnPlayGame.Name = "BtnPlayGame";
            this.BtnPlayGame.Size = new System.Drawing.Size(127, 36);
            this.BtnPlayGame.TabIndex = 11;
            this.BtnPlayGame.Text = "Play Game";
            this.BtnPlayGame.UseVisualStyleBackColor = true;
            // 
            // MainDeck
            // 
            this.MainDeck.Controls.Add(this.LblPlayersHand);
            this.MainDeck.Controls.Add(this.LblComputersHand);
            this.MainDeck.Controls.Add(this.LsvComputersHand);
            this.MainDeck.Controls.Add(this.BtnStand);
            this.MainDeck.Controls.Add(this.BtnHit);
            this.MainDeck.Controls.Add(this.LsvPlayersHand);
            this.MainDeck.Location = new System.Drawing.Point(69, 158);
            this.MainDeck.Name = "MainDeck";
            this.MainDeck.Size = new System.Drawing.Size(959, 223);
            this.MainDeck.TabIndex = 29;
            this.MainDeck.TabStop = false;
            this.MainDeck.Text = "BlackJack";
            // 
            // LblPlayersHand
            // 
            this.LblPlayersHand.AutoSize = true;
            this.LblPlayersHand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPlayersHand.Location = new System.Drawing.Point(283, 19);
            this.LblPlayersHand.Name = "LblPlayersHand";
            this.LblPlayersHand.Size = new System.Drawing.Size(105, 21);
            this.LblPlayersHand.TabIndex = 32;
            this.LblPlayersHand.Text = "Player\'s Hand";
            // 
            // LblComputersHand
            // 
            this.LblComputersHand.AutoSize = true;
            this.LblComputersHand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblComputersHand.Location = new System.Drawing.Point(688, 30);
            this.LblComputersHand.Name = "LblComputersHand";
            this.LblComputersHand.Size = new System.Drawing.Size(132, 21);
            this.LblComputersHand.TabIndex = 31;
            this.LblComputersHand.Text = "Computer\'s Hand";
            // 
            // LsvComputersHand
            // 
            this.LsvComputersHand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.LsvComputersHand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsvComputersHand.GridLines = true;
            this.LsvComputersHand.Location = new System.Drawing.Point(550, 54);
            this.LsvComputersHand.Name = "LsvComputersHand";
            this.LsvComputersHand.Size = new System.Drawing.Size(382, 150);
            this.LsvComputersHand.TabIndex = 30;
            this.LsvComputersHand.UseCompatibleStateImageBehavior = false;
            this.LsvComputersHand.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Face";
            this.columnHeader8.Width = 125;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Suit";
            this.columnHeader9.Width = 125;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Value";
            this.columnHeader10.Width = 125;
            // 
            // BtnStand
            // 
            this.BtnStand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStand.Location = new System.Drawing.Point(6, 107);
            this.BtnStand.Name = "BtnStand";
            this.BtnStand.Size = new System.Drawing.Size(127, 36);
            this.BtnStand.TabIndex = 29;
            this.BtnStand.Text = "Stand";
            this.BtnStand.UseVisualStyleBackColor = true;
            // 
            // BtnHit
            // 
            this.BtnHit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnHit.Location = new System.Drawing.Point(6, 54);
            this.BtnHit.Name = "BtnHit";
            this.BtnHit.Size = new System.Drawing.Size(127, 36);
            this.BtnHit.TabIndex = 28;
            this.BtnHit.Text = "Hit";
            this.BtnHit.UseVisualStyleBackColor = true;
            // 
            // LsvPlayersHand
            // 
            this.LsvPlayersHand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.LsvPlayersHand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsvPlayersHand.GridLines = true;
            this.LsvPlayersHand.Location = new System.Drawing.Point(149, 54);
            this.LsvPlayersHand.Name = "LsvPlayersHand";
            this.LsvPlayersHand.Size = new System.Drawing.Size(379, 150);
            this.LsvPlayersHand.TabIndex = 27;
            this.LsvPlayersHand.UseCompatibleStateImageBehavior = false;
            this.LsvPlayersHand.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Face";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Suit";
            this.columnHeader6.Width = 125;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Value";
            this.columnHeader7.Width = 125;
            // 
            // LvlOverallGameResults
            // 
            this.LvlOverallGameResults.AutoSize = true;
            this.LvlOverallGameResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlOverallGameResults.Location = new System.Drawing.Point(43, 410);
            this.LvlOverallGameResults.Name = "LvlOverallGameResults";
            this.LvlOverallGameResults.Size = new System.Drawing.Size(159, 21);
            this.LvlOverallGameResults.TabIndex = 30;
            this.LvlOverallGameResults.Text = "Overall Game Results";
            // 
            // FrmGameAppV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1358, 652);
            this.Controls.Add(this.LvlOverallGameResults);
            this.Controls.Add(this.MainDeck);
            this.Controls.Add(this.LsvGameStatistics);
            this.Controls.Add(this.LblPlayerScore0);
            this.Controls.Add(this.LblComputerScore0);
            this.Controls.Add(this.LblPlayerScore);
            this.Controls.Add(this.LblComputerScore);
            this.Controls.Add(this.LblPickGame);
            this.Controls.Add(this.LblEnterName);
            this.Controls.Add(this.CbxGame);
            this.Controls.Add(this.TbxPlayersName);
            this.Controls.Add(this.BtnFindOverallWinner);
            this.Controls.Add(this.BtnPlayGame);
            this.Name = "FrmGameAppV2";
            this.Text = "FrmGameAppV2";
            this.Load += new System.EventHandler(this.FrmGameApp_Load);
            this.MainDeck.ResumeLayout(false);
            this.MainDeck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView LsvGameStatistics;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label LblPlayerScore0;
        private Label LblComputerScore0;
        private Label LblPlayerScore;
        private Label LblComputerScore;
        private Label LblPickGame;
        private Label LblEnterName;
        private ComboBox CbxGame;
        private TextBox TbxPlayersName;
        private Button BtnFindOverallWinner;
        private Button BtnPlayGame;
        private GroupBox MainDeck;
        private ListView LsvPlayersHand;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button BtnStand;
        private Button BtnHit;
        private Label LblPlayersHand;
        private Label LblComputersHand;
        private ListView LsvComputersHand;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label LvlOverallGameResults;
    }
}