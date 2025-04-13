using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jack_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player player = new Player();
            Dealer dealer = new Dealer();

            deck.Shuffle();


            player.AddCard(deck.DrawCard());
            player.AddCard(deck.DrawCard());
            dealer.AddCard(deck.DrawCard());
            dealer.AddCard(deck.DrawCard());

            player.ShowHand("Player");
            dealer.ShowHand("Dealer");

            // Player turn
            while (true)
            {
                Console.Write("Hit or Stand? (h/s): ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "h")
                {
                    player.AddCard(deck.DrawCard());
                    player.ShowHand("Player");

                    if (player.CalculateScore() > 21)
                    {
                        Console.WriteLine("Player Busts! Dealer Wins.");
                        return;
                    }
                }
                else if (choice == "s")
                {
                    break;
                }
            }

            // Dealer turn
            dealer.ShowHand("Dealer");
            while (dealer.ShouldDraw())
            {
                dealer.AddCard(deck.DrawCard());
                dealer.ShowHand("Dealer");
            }

            int playerScore = player.CalculateScore();
            int dealerScore = dealer.CalculateScore();

            // Final Results
            Console.WriteLine($"Player Score: {playerScore}");
            Console.WriteLine($"Dealer Score: {dealerScore}");

            if (dealerScore > 21 || playerScore > dealerScore)
                Console.WriteLine("Player Wins!");
            else if (playerScore < dealerScore)
                Console.WriteLine("Dealer Wins!");
            else
                Console.WriteLine("It's a Tie!");

            Console.WriteLine("Game Over. Press any key to exit.");
            
        }
    }
}
