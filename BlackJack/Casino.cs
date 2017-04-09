using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Casino : IPlayer
    {
        private bool _hit;
        private Card[] _cards;
        public bool Hit
        {
            get
            {
                return _hit;
            }

            private set
            {
                _hit = value;
            }
        }

        public Casino()
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

            if(amount >= 17)
            {
                _hit = false;
            }
            return amount;
        }

        public Card GetCards()
        {
            return (Card)_cards.Clone();
        }

        public void ShowFirstCard()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Casino's first card is");
            if(_cards.Length > 0)
            {
                _cards[0].ShowCard();
            }
            Console.WriteLine("===========================");
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
    }
}
