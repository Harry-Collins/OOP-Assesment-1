using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing
    {
        public static Pack pack = new Pack();
        
        public static void clientTesting()
        {
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("\nWelcome to the card shuffler.\nPlease enter a number:\n1: Riffle Shuffle\n2: Fisher-Yates Shuffle\n3: No shuffle\n4: Deal a card\n5: Deal multiple cards\n6: End program\n");
                string userSelection = (string)Console.ReadLine();
                switch (userSelection)
                {
                    case "1":
                        Pack.shuffleCardPack(0);
                        break;
                    case "2":
                        Pack.shuffleCardPack(1);
                        break;
                    case "3":
                        Pack.shuffleCardPack(2);
                        break;
                    case "4":
                        Pack.deal();
                        break;
                    case "5":
                        bool check = false;
                        int cardsToDeal = 0;
                        while(check == false)
                        {
                            Console.WriteLine("How many cards would you like to deal?");
                            try
                            {
                                int numOfCards = Convert.ToInt32(Console.ReadLine());
                                if (numOfCards >= Pack.pack.Count())
                                {
                                    Console.WriteLine("Not enough cards left in the deck!");
                                }
                                else if (numOfCards <= 0)
                                {
                                    Console.WriteLine("Invalid input: input below 0");
                                }
                                else
                                {
                                    check = true;
                                    cardsToDeal = numOfCards;
                                }
                            }
                            catch(FormatException)
                            {
                                Console.WriteLine("Invalid entry: Try again");
                            }
                        }
                        List<Card> Dealt = new List<Card>();
                        for (int i = 0; i < cardsToDeal; i++)
                        {
                            Dealt.ElementAt(i).showCard();
                        }
                        break;
                    case "6":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}

