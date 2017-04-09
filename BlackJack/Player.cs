using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player : IPlayer
    {
        private bool _hit;
        private Card[] _cards;
        public bool Hit
        {
            
            get
            {
                return _hit;
            }

            set
            {
                _hit = value;
            }
        }

        public Player()
        {
            _cards = new Card[0];
            _hit = true;
        }

        public int CalculateAmount()
        {
            int amount = 0;
            for (int i = 0; i < _cards.Length; i++)
            {
                amount += _cards[i].Value;
            }
            
            if(amount > 21)
            {

            }
            
                       
            return amount;
        }

        public Card GetCards()
        {
            return (Card)_cards.Clone();
        }

        public void ShowCards()
        {
            for (int i = 0; i < _cards.Length; i++)
            {
                _cards[i].ShowCard();
            }

        }

        public void AddCard(Card card)
        {
            Card[] newCards = new Card[_cards.Length + 1];
            for (int i = 0; i < _cards.Length; i++)
            {
                newCards[i] = _cards[i];
            }
            newCards[newCards.Length - 1] = card;
            _cards = newCards;

        }

        public void AskPlayer()
        {
            int amount = CalculateAmount();
            if (amount >= 21)
            {
                _hit = false;
            }
            else
            {
                string answer = "";
                do
                {
                    Console.WriteLine($"Your amount: {amount}");
                    Console.WriteLine("Do you need one more card(yes(y)/no(n)");
                    answer = Console.ReadLine();

                } while (!(answer == "y" || answer == "n"));

                if (answer == "y")
                {
                    _hit = true;
                }
                if (answer == "n")
                {
                    _hit = false;
                }
            }
        }
    }
}
