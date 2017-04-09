using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        private Card[] _cards;

        public Card this[int i]
        {
            get
            {
                return _cards[i];
            }
        }
        public Deck()
        {
            int i = 0;
            _cards = new Card[52];
            foreach (var s in Enum.GetValues(typeof(Suits)))
            {
                foreach (var r in Enum.GetValues(typeof(Ranks)))
                {
                    _cards[i] = new Card((Suits)s, (Ranks)r);
                    i++;
                }
            }
        }

        public void ShowAllDeck()
        {
            for (int i = 0; i < _cards.Length; i++)
            {
                _cards[i].ShowCard();
            }
            
        }

        public void Mix()
        {
            Random rnd = new Random();
            Card temp;
            int tIndex = 0;
            for (int i = 0; i < _cards.Length; i++)
            {
                tIndex = rnd.Next(0, _cards.Length);
                temp = _cards[i];
                _cards[i] = _cards[tIndex];
                _cards[tIndex] = temp;
            }
        }

        public Card GetCard()
        {
            Card card = _cards[0];
            Card[] newCards = new Card[_cards.Length - 1];
            for (int i = 0; i < newCards.Length; i++)
            {
                newCards[i] = _cards[i+1];
            }
            newCards[newCards.Length - 1] = card;
            _cards = newCards;

            return card;
        }

    }
}
