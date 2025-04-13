using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using card_game.BL;

namespace card_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("Enter 1 to Play :");
                Console.WriteLine("Enter 2 to Exit:");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    bool gamerunning = true;
                    int score = 0;

                    Deck deck = new Deck();

                    deck.shuffle();

                    Card card = deck.dealCard();

                    while (gamerunning)
                    {
                        int remain_check = deck.cardsLeft();

                        Card card1 = deck.dealCard();

                        Console.WriteLine("*******************************");
                        Console.WriteLine(card.toString());
                        Console.WriteLine(" ");
                        Console.WriteLine("*** Remainig Cards ***      " + remain_check);
                        Console.WriteLine("Enter 1 if next card is higher");
                        Console.WriteLine("Enter 2 if next card is lower");

                        int card_check = int.Parse(Console.ReadLine());

                        Console.Clear();

                        if (card_check == 1)
                        {
                            if (card1.getValue() >= card.getValue())
                            {
                                score++;
                                card = card1;
                            }
                            else
                            {
                                gamerunning = false;
                                Console.WriteLine("Soory You Lose! Press Any Key TO Continue :");
                                Console.WriteLine("The Card was : " + card1.toString());
                                Console.WriteLine("Your score is : "+ score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        if (card_check == 2)
                        {
                            if (card1.getValue() >= card.getValue()) { score++; card = card1; }
                            else
                            {
                                gamerunning = false;
                                gamerunning = false;
                                Console.WriteLine("Soory You Lose! Press Any Key TO Continue :");
                                Console.WriteLine("The Card was : " + card1.toString());
                                Console.WriteLine("Your score is : " + score);
                                Console.ReadKey();
                                Console.Clear();

                            }
                        }
                        if (deck.cardsLeft() == 0 && card1 == null)
                        {
                            gamerunning = false;
                            Console.WriteLine("Congrats You Have scored maximum: " + card1.toString());
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    }

                    

                }
             
            } while (option != 0);
        }
    }
}
