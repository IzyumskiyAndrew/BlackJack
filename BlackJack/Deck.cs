using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        private Card[] _card;

        public Deck()
        {
            int i = 0;
            _card = new Card[52];
            foreach (var s in Enum.GetValues(typeof(Suits)))
            {
                foreach (var r in Enum.GetValues(typeof(Ranks)))
                {
                    _card[i] = new Card((Suits)s, (Ranks)r);
                    i++;
                }
            }
        }

        public void ShowAllDeck()
        {
            for (int i = 0; i < _card.Length; i++)
            {
                _card[i].ShowCard();
            }
            
        }

        public void 
    }
}
