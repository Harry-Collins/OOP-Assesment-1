using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        private static List<Card> pack2 = new List<Card>();
        public static List<Card> pack
        {
            get { return pack2; }
            set {}
        }



        static Pack()
        {
            //Initialise the card pack here
            for (int value = 1; value < 14; value++)
            {
                for(int suit = 1; suit < 5; suit++)
                {
                    Card card = new Card();
                    card.Value = value;
                    card.Suit = suit;
                    pack2.Add(card);
                }
            

            }
        }

        public static void shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            Random random = new Random();
            switch (typeOfShuffle)
            {
                case 0:
                    //riffle shuffle
                    
                    int Cut = (pack2.Count() / 2);
                    List<Card> PackLeft = new List<Card>();
                    List<Card> PackRight = new List<Card>();
                    for (int i = 0; i < Cut; i++)
                    {
                        PackLeft.Add(pack2.ElementAt(0));
                        pack2.RemoveAt(0);
                        Console.WriteLine(PackLeft.Count());
                    }

                    while (pack2.Count() > 0)
                    {
                        PackRight.Add(pack2.ElementAt(0));
                        pack2.RemoveAt(0);
                    }
                    while ((PackLeft.Count() > 0) || (PackRight.Count() > 0))
                    {
                        switch (random.Next(0,2)) 
                        {
                            case 0:
                                int smaller = Math.Min(0, PackLeft.Count()-1);
                                int bigger = Math.Max(0, PackLeft.Count() - 1);
                                int Merge = random.Next(smaller,bigger);
                                Console.WriteLine(Merge + "h");
                                pack2.Add(PackLeft.ElementAt(Merge));
                                PackLeft.RemoveAt(Merge);
                                break;
                            
                            case 1:
                                int smaller2 = Math.Min(0, PackLeft.Count() - 1);
                                int bigger2 = Math.Max(0, PackLeft.Count() - 1);
                                int _Merge = random.Next(smaller2, bigger2);
                                Console.WriteLine(_Merge + "h");
                                pack2.Add(PackRight.ElementAt(_Merge)); 
                                PackRight.RemoveAt(_Merge);
                                break;

                        }
                    }
                    showPack();
                    break;
                case 1:
                    //Fisher-Yates shuffle
                    List<Card> TempPack = new List<Card>();
                    while (pack2.Count() > 0)
                    {
                        int num = random.Next(0, pack2.Count());
                        TempPack.Add(pack2.ElementAt(num));
                        pack2.RemoveAt(num);
                    }
                    pack2 = TempPack;
                    showPack();
                    break;
                    
                case 2:
                    //no Shuffle
                    Console.WriteLine("No shuffle was carried out");
                    showPack();
                    break;

            }

            

       
        }
        public static Card deal()
        {
            //Deals one card
             Card TopCard = pack2.ElementAt(0);
            pack2.RemoveAt(0);
            return TopCard;

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> Dealt = new List<Card>();
            for(int i = 0; i < amount; i++)
            {
                Dealt.Add(pack2.ElementAt(pack2.Count()-1));
                pack2.RemoveAt(pack2.Count() - 1);   
            }
            return Dealt;
        }

        public static void showPack()
        {
            Console.WriteLine("\nPack");
            for (int i = 0; i < pack2.Count(); i++)
            {
                Console.WriteLine("test");
                pack2.ElementAt(i).showCard();
            }
        }
    }
}
