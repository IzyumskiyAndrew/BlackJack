using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        private Suits _suit;
        private Ranks _rank;

        public Suits Suit
        {
            get { return _suit; } 
        }

        public Ranks Rank
        {
            get { return _rank; }
        }

        public int Value
        {
            get { return (int)_rank; }
        }

        private Card()
        { }

        public Card(Suits suit, Ranks rank)
        {
            _suit = suit;
            _rank = rank;
        }

        public void ShowCard()
        {
            string msg = "";
            if ((int)_rank != 11)
            {
                msg = ((int)_rank).ToString();
            }
            else
            {
                msg = ((int)_rank).ToString() + " or 1";
            }
             
            Console.WriteLine($"#{ _suit.ToString()} _ { _rank.ToString()}#  Value: " + msg);
        }

        
    }
}
