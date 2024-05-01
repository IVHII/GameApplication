using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class PlayingCard
    {
        /// <summary>
        /// a) Assigns a suit and face to each card
        /// b) Gets each suit face and value
        /// c) Gets each playing card and assigns it a value based on its face
        /// </summary>
        static public string[] Suits = { "Spades", "Clubs", "Diamonds", "Hearts" };
        static public string[] Faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" }; //a



        public String Suit { get; set; } //b

        public String Face { get; set; }

        public int Value { get; set; }

        public PlayingCard(String inSuit, String inFace) //c
        {
            Suit = inSuit;
            Face = inFace;
            switch (inFace)
            {
                case "Two": Value = 2; break;
                case "Three": Value = 3; break;
                case "Four": Value = 4; break;
                case "Five": Value = 5; break;
                case "Six": Value = 6; break;
                case "Seven": Value = 7; break;
                case "Eight": Value = 8; break;
                case "Nine": Value = 9; break;
                case "Ten": Value = 10; break;
                case "Jack": Value = 11; break;
                case "Queen": Value = 12; break;
                case "King": Value = 13; break;
                case "Ace": Value = 14; break;

                default:
                    Value = 10; break;
            }
        }   //end of PlayingCard Constructor method

        public override string ToString()
        {
            return $"Suit {Suit} Face {Face} Value {Value}";
        }

    }   // end PlayingCard

    
}
