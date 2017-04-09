using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    interface IPlayer
    {
        bool Hit { get; }

        int CalculateAmount();

        Card GetCards();

        void ShowCards();

        void AddCard(Card card);


    }
}
