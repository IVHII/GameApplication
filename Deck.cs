using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    /// <summary>
    /// Creates a deck of 52 Playing Cards in order by suit and then shuffles them
    /// a) Defines Attribute _Cards to hold cards
    /// b) Defines Property Cards to give access to _Cards
    /// c) Defines Public Property that returns number of cards in Deck
    /// d) Public Method to add a Playing Card to Deck
    /// e) Public constructor to make Deck of 52 Cards and then shuffle them into random order
    /// f) Deals a Playing Card from the top of the deck by returning it and then removing it from Deck
    /// g) Creates a random object
    /// h) Shuffles the cards 1 at a time into a new order by randomly transferring cards to a new temporary deck
    /// </summary>
    internal class Deck
    {
        private List<PlayingCard> _Cards; //a

        public List<PlayingCard> Cards //b
        {
            get { return _Cards; }
        }

        public int Count
        {
            get { return _Cards.Count; } //c
        }

        public void Add(PlayingCard cardToAdd) //d
        {
            _Cards.Add(cardToAdd);
        } //End Add

        public Deck() //e
        {
            _Cards = new List<PlayingCard>(); //1
            foreach (String suit in PlayingCard.Suits)
                foreach (String face in PlayingCard.Faces)
                    _Cards.Add(new PlayingCard(suit, face)); //2

            Shuffle(); //3
        }// End Deck Constructor
        /// <summary>
        /// Shuffles deck 1 card at time into a new order then shuffles them
        /// 1) Creates new deck object containing blank list of playing cards
        /// 2) While cards exist in the it it will
        /// 3) Randomly selcting a card from old deck
        /// 4) Moving it to new deck
        /// 5) Removes it from old deck
        /// 6) Swaps cards from newDeck object to _Cards object
        /// </summary>
        /// <returns></returns>
        public void Shuffle() //4 used in h
        {
            List<PlayingCard> newDeck = new List<PlayingCard>(); //1
            while (_Cards.Count > 0)                            //2
            {
                int cardToMove =rndNum.Next(_Cards.Count); //3
                newDeck.Add(_Cards[cardToMove]);          //4
                _Cards.RemoveAt(cardToMove);             //5
            }
            _Cards = newDeck;//6
        } //End Shuffle
       
        public PlayingCard Deal()
        {
            PlayingCard cardToDeal = _Cards[0]; //1
            _Cards.RemoveAt(0); //2
            return cardToDeal;
        }

        private Random rndNum = new Random(Guid.NewGuid().GetHashCode()); //g
        
    }// End of Deck Class
}
