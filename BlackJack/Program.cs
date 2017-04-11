using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            deck.ShowAllDeck();

            Console.WriteLine("===================================");
            deck.Mix();
            deck.ShowAllDeck();
            Console.WriteLine("===================================");
            Console.WriteLine();

            Casino casino = new Casino();
            Player player = new Player();

            casino.AddCard(deck.GetCard());
            player.AddCard(deck.GetCard());
            casino.AddCard(deck.GetCard());
            player.AddCard(deck.GetCard());

            casino.ShowFirstCard();

            Console.WriteLine("Your cards:");
            int playerAmount = player.CalculateAmount();
            player.ShowCards();
            player.AskPlayer();
            while (player.Hit)
            {
                Console.WriteLine("Your cards:");
                player.AddCard(deck.GetCard());
                playerAmount = player.CalculateAmount();               
                player.ShowCards();
                player.AskPlayer();
            }
            Console.WriteLine("===================================");
            Console.WriteLine("Casino's cards:");
            int casinoAmount = casino.CalculateAmount();
            while (casino.Hit)
            {
                casino.AddCard(deck.GetCard());
                casinoAmount = casino.CalculateAmount();
            }
                casino.ShowCards();
            if (playerAmount > 21 && casinoAmount > 21)
            {
                Console.WriteLine("Dead heat.");
            }
            else if (playerAmount > 21 )
            {
                Console.WriteLine("LOOSER!!! You have more than 21 points.");
            }
            else if (casinoAmount > 21)
            {
                Console.WriteLine("You are win!!! Casino has more 21 poits");
            }
            else
            {
                if (playerAmount > casinoAmount)
                {
                    Console.WriteLine("You are win!!!");
                }
                else if (playerAmount == casinoAmount)
                {
                    Console.WriteLine("Dead heat.");
                }
                else
                {
                    Console.WriteLine("Casino is win.");
                }
            }
            Console.ReadKey();
        }
    }
}
