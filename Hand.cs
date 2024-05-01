using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Hand
    {
        /// <summary>
        /// a) Stores list of playing cards
        /// b) Provides access to the private list
        /// c) Exposes number of cards in the list
        /// d) Creates new list of playing card objects
        /// e) Adds a card to the _Cards list
        /// </summary>
        private List<PlayingCard> _Cards; //a

        public List<PlayingCard> Cards //b
        {
            get { return _Cards; }
        }

        public int Count //c
        {
            get { return _Cards.Count; }
        }

        public Hand() //d
        {
            _Cards = new List<PlayingCard>();
        }

        public void AddCardToHand(PlayingCard cardToAdd) //e
        {
            _Cards.Add(cardToAdd);
        }//End Add

        /// <summary>
        /// 1) Check if value > 10 and aces and adjust card value
        /// 2) Reduces card value and number of aces
        /// </summary>
        /// <returns></returns>
        public int Value() //f
        {
            int cardValue = 0;
            int handValue = 0;
            int aces = 0;

            for (int ptr = 0; ptr < _Cards.Count; ptr++) //1
            {
                if (_Cards[ptr].Face == "Ace")
                {
                    cardValue = 11;
                    aces = aces + 1;
                }
                else if (_Cards[ptr].Value > 10)
                    cardValue = 10;
                else
                    cardValue = _Cards[ptr].Value;

                handValue += cardValue;
            } //end foreach

            while ((handValue > 21) && (aces > 0)) //2
            {
                handValue = handValue - 10;
                aces = aces - 1;
            } //end while

            return handValue;
        }
    } 
}
