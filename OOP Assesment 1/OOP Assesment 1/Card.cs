using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {

        
        private string[] Suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
        private string[] Values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "Ten" };
        public Card() 
        {
        }

        private int _value;
        private int _suit;
        public int Value 
        {
            get { return _value; }
            set { if (value < 14 && value > 0) { _value = value; } }
        }
        public int Suit 
        { 
            get { return _suit; }
            set { if (value < 5 && value > 0) { _suit = value; } }
        }
        public void showCard()
        {
            Console.WriteLine(Values[Value - 1] + "of" + Suits[Suit - 1]);
        }
    }
}
