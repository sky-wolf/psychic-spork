using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter
{

    public class Battle
    {
        List<string> kills = new List<string>(); 

        Character player = new Character();
        
        int omgong = 1;

        public void Initializer()
        {
            Console.Clear();

            string? temp = null;
            int choice = 0;

            do
            {
                Console.WriteLine("To create a Player");
                Console.WriteLine("Enter a name");
                Console.WriteLine("Player stat will be generated");
                Console.WriteLine("\n\n");

                temp = Convert.ToString(Console.ReadLine());
                if (int.TryParse(temp, out choice))
                {
                    temp = null;
                    Console.Clear();
                    Console.WriteLine("Felaktig inmatnig försök igen!");
                }


            } while (string.IsNullOrEmpty(temp));

            this.player.Create("Job", 1);
            
        }

        public void Run()
        {
            int score = 0;
            bool fight = true;


            while (fight)
            {
                Console.Clear();

                Round round = new Round();
                Shop shop = new Shop(this.player);

                Console.WriteLine("Is the odds in your favor");
                Console.WriteLine("\n\n");
                Console.WriteLine("\tf: Fight");
                Console.WriteLine("\tr: Retire");
                Console.WriteLine("\ts: Shop");
                Console.WriteLine("\n\n");
                Console.WriteLine("\tCurrency: " + this.player.Currency + ":-");
                Console.WriteLine("\n\n");


                var choice = Console.ReadKey();

                switch (choice.Key)
                {
                    case ConsoleKey.F:
                        {
                            Console.Clear();
                            
                            round.Run(player, this.omgong);
                            if (!this.player.IsAlive())
                            {
                                Console.Clear();
                                Console.WriteLine($"You is carried out of arena killd by {round.Namn()}");
                                Console.WriteLine($"Score: {score}");
                                this.getLog();
                                fight = false;
                            }
                            else
                            {
                                score++;
                                kills.Add(round.Namn());
                                this.player.Currency += 500;
                            }

                        }
                        break;
                    case ConsoleKey.S:
                        {
                            Console.Clear();
                            shop.ShopMenu();

                        }
                        break;
                    case ConsoleKey.R:
                        {
                            Console.Clear();
                            Console.WriteLine("You left the arena");
                            Console.WriteLine($"Score: {score}");
                            this.getLog();
                            fight = false;

                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Only use assind latters");
                        }
                        break;

                }
                omgong++;
            }
 
        }
        

        public void getLog()
        {
            foreach (string kill in kills)
            {
                Console.WriteLine($" killed {kill}");
            }
        }
        
    }
}
