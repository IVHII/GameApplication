using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class FrmGameAppV2 : Form
    {
        public FrmGameAppV2()
        {
            InitializeComponent();
        }

        private void ResetInterface()
        {
            TbxPlayersName.Text = "";
            CbxGame.SelectedIndex = -1;
            CbxGame.Enabled = false;
            BtnPlayGame.Enabled = false;
            LsvGameStatistics.Items.Clear();

        }
        /// <summary>
        /// FillCbxGame combo-box with avaiable games from String array
        /// a. Declare Array of available Games,
        /// b. Clear existing CbxGame combobox Items
        /// c. Add each game in array to CbxGame Items
        /// </summary>

        private void FillCbxGame()
        {
            string[] availableGames = { "Dice", "Ten Sided Dice", "Twenty Sided Dice", "High Card Wins", "BlackJack" }; //a
            CbxGame.Items.Clear();                              //b
            foreach (string game in availableGames)             //c
                CbxGame.Items.Add(game);
        }
        /// <summary>
        /// Assigns each button, text change and index change an event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGameApp_Load(object sender, EventArgs e)
        {
            FillCbxGame();
            ResetInterface();

            this.BtnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click);
            this.BtnFindOverallWinner.Click += new System.EventHandler(this.BtnFindOverallWinner_click);
            this.TbxPlayersName.TextChanged += new System.EventHandler(this.TbxPlayersName_TextChanged);
            this.CbxGame.SelectedIndexChanged += new System.EventHandler(CbxGame_SelectedIndexChanged);
            this.BtnHit.Click += new System.EventHandler(BtnHit_Click);
            this.BtnStand.Click += new System.EventHandler(BtnStand_Click);
        }
        /// <summary>
        /// a) If the player has selected a game make unblank the playgame button.
        /// b) If the player name has a length more than 1 enable the selection of games.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxGame_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (CbxGame.SelectedIndex != -1)//a
                BtnPlayGame.Enabled = true;
        }

        private void TbxPlayersName_TextChanged(object? sender, EventArgs e)
        {
            if (TbxPlayersName.Text.Length > 1)//b
                CbxGame.Enabled = true;
        }

        private void BtnFindOverallWinner_click(object? sender, EventArgs e)
        {
            DisplayOverallGameResult();
        }
        // Global Variables
        public string GameName = "";
        public string PlayersName = "";
        public int PlayersScore0 = 0;
        public int ComputerScore0 = 0;
        public string Feedback = "";
        public string Winner = "";
        /// <summary>
        /// a) Whatever the player set their name as will be their name for the rest of the game in the Lsvs
        /// b) Selection for game, sets the rules of the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlayGame_Click(object? sender, EventArgs e)
        {
            PlayersName = TbxPlayersName.Text.TrimEnd(); //a
            GameName = CbxGame.SelectedItem.ToString();//b
            PlayGame(GameName);
            if (GameName != "BlackJack")
            {
                Feedback = FindGameWinner(); 
                DisplayGameResult();         
            }
            
            
        }// end of BtnPlayGame_click event


        /// <summary>
        /// a) If the message box result starts with the player name add a win to players overall score
        /// b) If the message box result starts with the computer name add a win to computer overall score
        /// c) Overall game result, if player has more overall wins player will win overall, same for computer.
        /// d) Displays messagebox for overall winner.
        /// </summary>
        private void DisplayOverallGameResult()
        {
            int playerWins = 0;
            int computerWins = 0;
            string result = "";

            int numOfGames = LsvGameStatistics.Items.Count;

            foreach (ListViewItem element in LsvGameStatistics.Items)
            {
                result = element.SubItems[3].Text;
                if (result.StartsWith(PlayersName))//a
                    playerWins += 1;
                else if (result.StartsWith("Computer"))//b
                    computerWins += 1;
            }//end for

            if (playerWins > computerWins)
                result = $"{PlayersName} wins as they have won {playerWins} games which is higher than {computerWins}";//c
            else if (playerWins < computerWins)
                result = $"Computer wins as they won {computerWins} games which is higher than {playerWins}";
            if (playerWins == computerWins)
                result = $"Draw as both won {computerWins} games";

            MessageBox.Show(result, "Overall Result");//d
        }
        /// <summary>
        /// a) Will show prompt whether to continue the game.
        /// b) If player types Y then game will continue.
        /// c) If player types N then game will close.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private char GetReply(string prompt)
        {
            string temp = InputBox.Show("Continue?", prompt); //a
            if (temp.ToUpper().StartsWith("Y"))
                return 'Y';               //b
            else
                return 'N';               //c
        }  // end of GetReply

        /// <summary>
        /// a) Fills in the Lsv with information on the game played, both scores and who won.
        /// b) Creates a new row when upper one is filled.
        /// c) Adds new Lsv Items.
        /// 
        /// </summary>
        private void DisplayGameResult()
        {
            MessageBox.Show(Feedback, "Game Result");

            string[] row = { GameName, PlayersScore0.ToString(), ComputerScore0.ToString(), Winner }; //a
            var listViewItem = new ListViewItem(row); //b
            LsvGameStatistics.Items.Add(listViewItem); //c
        }
        /// <summary>
        /// a) If player score and computer score are equal then the game will be a draw.
        /// b) If the playerscore is higher than computers then the player wins.
        /// c) If the computer score is higher than the players then the computer wins.
        /// d) Returns feedback messagebox.
        /// </summary>
        /// <returns></returns>
        public string FindGameWinner()
        {
            string feedback = "";
            if (PlayersScore0 == ComputerScore0)
            {
                feedback = $"Draw as {PlayersScore0} was equal to {ComputerScore0}"; //a
                Winner = "Draw";
            }
            else if (PlayersScore0 > ComputerScore0)
            {
                feedback = $"{PlayersName} wins as {PlayersScore0} is higher than {ComputerScore0}";//b
                Winner = PlayersName;
            }
            else if (ComputerScore0 > PlayersScore0)
            {
                feedback = $"{PlayersName} loses as {PlayersScore0} is lower than {ComputerScore0}";//c
                Winner = "Computer";
            }
            return feedback;//d
        }

        /// <summary>
        /// Changes the game and plays it depending on what the player chose from the dropdown.
        /// a) If theres an error showcases message box with "Exception error"
        /// </summary>
        /// <param name="gameName"></param>
        public void PlayGame(string gameName)
        {
            try
            {
                switch (gameName)    //b
                {
                    case "Dice":
                        PlayDiceGame(); break; //c

                    case "Ten Sided Dice": //4b
                        PlayTenSidedDiceGame(); break;

                    case "Twenty Sided Dice":
                        PlayTwentywsidedDiceGAme(); break; //e

                    case "High Card Wins":
                        PlayHighCardGame(); break; //

                    case "BlackJack":
                        PlayBlackJackGame(); break;  //new

                    default:
                        MessageBox.Show("Game not Implemented", "Error"); break; //f
                } //end switch
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented correctly" + ex.Message, "Exception Error"); // a
            }

        }// End of PlayGame
        /// <summary>
        /// 1) Player dice is set to blue
        /// 2) Computer dice is set to red
        /// 3) The player score is representative of the dice roll number.
        /// 4) The computer score is representative of the dice roll number.
        /// 5) If theres an error display messagebox.
        /// </summary>
        private void PlayTwentywsidedDiceGAme()
        {
            try
            {
                TwentySidedDice playerDice = new TwentySidedDice("Blue");  //1
                TwentySidedDice computerDice = new TwentySidedDice("Red"); //2
                PlayersScore0 = playerDice.Num;                      //3
                ComputerScore0 = computerDice.Num;                   //4
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented correctly" + ex.Message, "Exception Error"); //5
            }
        }
        /// <summary>
        /// 1) Player dice is set to blue
        /// 2) Computer dice is set to red
        /// 3) The player score is representative of the dice roll number.
        /// 4) The computer score is representative of the dice roll number.
        /// 5) If theres an error display messagebox.
        /// </summary>
        private void PlayTenSidedDiceGame()
        {
            try
            {
                TenSidedDice playerDice = new TenSidedDice("Blue");  //1
                TenSidedDice computerDice = new TenSidedDice("Red"); //2
                PlayersScore0 = playerDice.Num;                      //3
                ComputerScore0 = computerDice.Num;                   //4
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented correctly" + ex.Message, "Exception Error"); //5
            }
        } //end of PlayTenSidedDiceGame()
        /// <summary>
        /// 1) Player dice is set to blue
        /// 2) Computer dice is set to red
        /// 3) The player score is representative of the dice roll number.
        /// 4) The computer score is representative of the dice roll number.
        /// 5) If theres an error display messagebox.
        /// </summary>
        public void PlayDiceGame()
        {
            try
            {
                Dice playerDice = new Dice("Blue"); //1
                Dice dice = new Dice("Red");             //2
                PlayersScore0 = playerDice.Num;     //3
                ComputerScore0 = dice.Num;         //4

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented Correctly" + ex.Message, "Exception Error");//5
            }
        }// end of PlayDiceGame

        Deck mainDeck = null;
        /// <summary>
        /// 1) If the maindeck at the start of the game is null then creates a new deck.
        /// 2) Gives the player a random card from the deck.
        /// 3) The card value is representative of the players score.
        /// 4) Gives the computer a random card from the deck.
        /// 5)The card value is representative of the computers score.
        /// </summary>
        private void PlayHighCardGame()
        {
            if (mainDeck == null)
                mainDeck = new Deck(); //1

            PlayingCard playerCard = mainDeck.Deal(); //2
            PlayersScore0 = playerCard.Value; //3
            PlayingCard computerCard = mainDeck.Deal(); //4
            ComputerScore0 = playerCard.Value; //5
        }

        // blackjack
        /// <summary>
        /// 2a) Makes the computer hand null at the start of the game
        /// 2b) Makes the player hand null at the start of the game
        /// 2c) Deals the player a card.
        /// </summary>
        Hand ComputerHand = null; //2a
        Hand PlayerHand = null; //2b



        /// <summary>
        /// 1) If the maindeck at the start of the game is null then creates a new deck.
        /// 2) Makes the player hand null then gives the player a new hand from the shuffled deck.
        /// 3) Players card is dealt from the new shuffled deck.
        /// 4) Adds the card to the players hand
        /// 5) Shows the player card within the Lsv
        /// </summary>
        public void DealaPlayerCard() //2c
        {
            if (mainDeck == null)
                mainDeck = new Deck();//1
            if (PlayerHand == null)
                PlayerHand = new Hand(); //2

            PlayingCard playerCard = mainDeck.Deal(); //3
            PlayerHand.AddCardToHand(playerCard); //4
            DisplayPlayerCard(playerCard); //5
        }
        /// <summary>
        /// 1) If the maindeck at the start of the game is null then creates a new deck.
        /// 2) Makes the computer hand null then gives the player a new hand from the shuffled deck.
        /// 3) Computers card is dealt from the new shuffled deck.
        /// 4) Adds the card to the computers hand
        /// 5) Shows the computer card within the Lsv
        /// </summary>
        public void DealaComputerCard() //2c
        {
            if (mainDeck == null)
                mainDeck = new Deck();//1
            if (ComputerHand == null)
                ComputerHand = new Hand(); //2

            PlayingCard computerCard = mainDeck.Deal(); //3
            ComputerHand.AddCardToHand(computerCard); //4
            DisplayComputerCard(computerCard); //5
        }
        /// <summary>
        /// a)If the card value is larger than 10 i.e 11 sets the value back to 10.
        /// b) Adds the card to the players Lsv
        /// c) Display message box "Display Card Error"
        /// </summary>
        /// <param name="card"></param>
        private void DisplayPlayerCard(PlayingCard card) //moved
        {
            try
            {
                if (card.Value > 10) //a
                    card.Value = 10;
                LsvPlayersHand.Items.Add(new ListViewItem(new[] { card.Face.ToString(), card.Value.ToString() })); //b
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented Correctly" + ex.Message, "Display Card Error"); //c
            }
        }
        /// <summary>
        /// a)If the card value is larger than 10 i.e 11 sets the value back to 10.
        /// b) Adds the card to the computers Lsv.
        /// c) Display message box "Display Card Error".
        /// </summary>
        /// <param name="card"></param>
        private void DisplayComputerCard(PlayingCard card)
        {
            try
            {
                if (card.Value > 10)
                    card.Value = 10;
                LsvComputersHand.Items.Add(new ListViewItem(new[] { card.Face.ToString(), card.Value.ToString() }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented Correctly" + ex.Message, "Display Card Error");
            }
        }
        /// <summary>
        /// 2) When blackjack game is played it deals out two cards
        /// 3) Players score is the overall value of both cards in their hand.
        /// 4) Label text changes to show players score.
        /// </summary>
        public void PlayBlackJackGame() 
        {
            DealaPlayerCard();               //2
            DealaPlayerCard();

            PlayersScore0 = PlayerHand.Value();  //3
            LblPlayerScore0.Text = PlayersScore0.ToString();  //4
        }
        /// <summary>
        /// 1) When BtnHit is clicked it deals another card to the players hand.
        /// 2) Players score is representative of the value of their hand.
        /// 3) Label text changes to show players score.
        /// 4) Displays messagebox with "Display BtnHit Error".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHit_Click(object sender, EventArgs e)
        {
            try
            {
                DealaPlayerCard(); //1
                PlayersScore0 = PlayerHand.Value();  //2
                LblPlayerScore0.Text = PlayersScore0.ToString();  //3

                if (PlayersScore0 > 21)
                    BtnStand_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Display BtnHit Error"); //4
            }
        }
        /// <summary>
        /// 1) When BtnStand is clicked the computer is dealt 2 cards and then will automatically "hit" when the computers score is less than 17 and is lower than the players score.
        /// 2) Computers score is representative of the value of their hand.
        /// 3) Label text changes to show computers score.
        /// 4) Finds the winner of the current game.
        /// 5) Clears the players hand Lsv.
        /// 6) Clears the computers hand Lsv.
        /// 7) Displays error message box with "Stand Error"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStand_Click(object sender, EventArgs e)
        {
            try
            {
                DealaComputerCard();
                while ((ComputerHand.Value() < 17 && ComputerHand.Value() < PlayerHand.Value()))//1
                    DealaComputerCard();

                ComputerScore0 = ComputerHand.Value(); //2
                LblComputerScore0.Text = ComputerScore0.ToString(); //3
                Feedback = FindBlackJackGameWinner(); //4
                DisplayGameResult();

                PlayerHand = null;
                mainDeck = null;
                ComputerHand = null;
                LsvPlayersHand.Items.Clear(); //5
                LsvComputersHand.Items.Clear(); //6
                PlayersScore0 = 0;
                ComputerScore0 = 0;
                LblPlayerScore0.Text = "0";
                LblComputerScore0.Text = "0";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stand Error"); //7
            }
        } //end of BtnStand_Click
        /// <summary>
        /// 1) Deals 2 cards to the computers hand and removes them from deck
        /// 2) Transfers the hand value of the computer to the score
        /// 3) Transfers the score to the label to show in the GUI
        /// </summary>
        private void DealaComputerHand()  //2d
        {
            DealaComputerCard();          //1
            DealaComputerCard();

            ComputerScore0 = ComputerHand.Value();  //2
            LblComputerScore.Text = ComputerScore0.ToString();  //3
        }
        /// <summary>
        /// 1) If players score is over 21 and computers is smaller or equal to 21 then computer wins.
        /// 2) If players score is over 21 and computers is over 21 then both are bust and nobody wins.Edgecase.
        /// 3) If computers score is over 21 and players is smaller or equal to 21 then player wins.
        /// 4) If players score is larger than computers then player wins.
        /// 5) If computers score is larger than players then computer wins.
        /// 6) If the player has more cards in the hand than the computer then the player wins.
        /// 7) If the computer has more cards in the hand than the player then the computer wins.
        /// 8) If the players and computers score and cards in hand are equal then its a draw and nobody wins. Edgecase.
        /// 9) If no win condition and everything else fails then displays an error.
        /// 10) Display error messagebox "Display blackjack error".
        /// </summary>
        /// <returns></returns>
        private string FindBlackJackGameWinner()
        {
            string feedback = "";
            int playerHandCount = PlayerHand.Count;
            int computerHandCount = ComputerHand.Count;

            try
            {
                if ((PlayersScore0 > 21) && (ComputerScore0 <= 21)) //1
                {
                    feedback = "Player is bust! Computer wins!";
                    Winner = "Computer";
                }
                else if ((PlayersScore0 > 21) && (ComputerScore0 > 21)) //2
                {
                    feedback = "Both Bust! Nobody wins!";
                    Winner = "Nobody";
                }

                else if ((ComputerScore0 > 21) && (PlayersScore0 <= 21)) //3
                {
                    feedback = "Computer is bust! Player wins!"; 
                    Winner = (PlayersName);

                }
                
                else if (PlayersScore0 > ComputerScore0) //4
                {
                    feedback = "Player wins! Their hand value is larger.";
                    Winner = (PlayersName);
                }
                else if (ComputerScore0 > PlayersScore0) //5
                {
                    feedback = "Computer wins! Their hand value is larger.";
                    Winner = "Computer";
                }
                else if (playerHandCount > computerHandCount) //6 
                {
                    feedback = "Player wins! They have more cards in their hand.";
                }
                else if (computerHandCount > playerHandCount) //7
                {
                    feedback = "Computer wins! They have more cards in their hand.";
                    Winner = "Computer";
                }
                else if (playerHandCount == computerHandCount && PlayersScore0 == ComputerScore0) //8
                {
                    Feedback = "Draw! Nobody wins!";
                    Winner = "Nobody";
                }
                
                else //9
                {
                    feedback = "BlackJack Error!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Display BlackJack Error"); //10
            }
            return feedback;
        }// end FindBlackJackGameWinner
    } // end of class
}

