using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Arena_Fighter
{
    public class Shop
    {
        private Character player;
        public Shop(Character player)
        {
            this.player = player;
        }

        public void ShopMenu()
        {
            bool chop = true;

            while (chop)
            {
                Console.Clear();
                Round round = new Round();

                Console.WriteLine("In game Shop");
                Console.WriteLine("\tCurrency: " + this.player.Currency + ":-");
                Console.WriteLine("\n\n");
                Console.WriteLine("\ts: Heal 500");
                Console.WriteLine("\td: Light armor 1500");
                Console.WriteLine("\tf: Medium armor 2000");
                Console.WriteLine("\tg: Hard armor 3000");
                Console.WriteLine("\th: Medium sword 3000");
                Console.WriteLine("\tj: Hard sword 5000");
                Console.WriteLine("\tq: Quit");
                Console.WriteLine("\t");



                var choice = Console.ReadKey();

                switch (choice.Key)
                {
                    case ConsoleKey.S:
                        {
                            if (this.player.Currency > 500)
                            {
                                this.player.Healt = this.player.Maxhealt;
                                this.player.Currency -= 500;
                                Console.WriteLine(" Add's to healt");
                            }
                            else
                            {
                                Console.WriteLine(" Need more");
                                Console.ReadKey();
                            }

                        }
                        break;
                    case ConsoleKey.D:
                        {
                            if (this.player.Currency > 1500)
                            {
                                this.player.Armor = 2;
                                this.player.Currency -= 1500;
                                Console.WriteLine(" Add's 2 point to armor");
                            }
                            else
                            {
                                Console.WriteLine(" Need more");
                                Console.ReadKey();
                            }

                        }
                        break;
                    case ConsoleKey.F:
                        {
                            if (this.player.Currency > 2000)
                            {
                                this.player.Armor = 3;
                                this.player.Currency -= 2000;
                                Console.WriteLine(" Add's 3 point to armor");
                            }
                            else
                            {
                                Console.WriteLine(" Need more");
                                Console.ReadKey();
                            }

                        }
                        break;
                    case ConsoleKey.G:
                        {
                            if (this.player.Currency > 3000)
                            {
                                this.player.Armor = 4;
                                this.player.Currency -= 3000;
                                Console.WriteLine(" Add's 4 point to armor");
                            }
                            else
                            {
                                Console.WriteLine(" Need more");
                                Console.ReadKey();
                            }

                        }
                        break;
                    case ConsoleKey.H:
                        {
                            if (this.player.Currency > 3000)
                            {
                                this.player.Weapon += 3;
                                this.player.Currency -= 3000;
                                Console.WriteLine(" Add's 3 point to weapon");
                            }
                            else
                            {
                                Console.WriteLine(" Need more");
                                Console.ReadKey();
                            }

                        }
                        break;
                    case ConsoleKey.J:
                        {
                            if (this.player.Currency > 5000)
                            {
                                this.player.Weapon += 5;
                                this.player.Currency -= 5000;
                                Console.WriteLine(" Add's 4 point to weapon");
                            }
                            else
                            {
                                Console.WriteLine(" Need more");
                                Console.ReadKey();

                            }
                        }
                        break;
                    case ConsoleKey.Q:
                        {
                            Console.Clear();
                            chop = false;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine(" Only use assind latters");
                        }
                        break;

                }
            }
        }
    }
}
