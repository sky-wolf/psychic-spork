using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter
{
    public class Program
    {
        
        static void Main(string[] arg)
        {
            Battle battle = new Battle();

            do
            {
                Console.Write("   _____                               ___________.__       .__     __                \r\n  /  _  \\_______  ____   ____ _____    \\_   _____/|__| ____ |  |___/  |_  ___________ \r\n /  /_\\  \\_  __ \\/ __ \\ /    \\\\__  \\    |    __)  |  |/ ___\\|  |  \\   __\\/ __ \\_  __ \\\r\n/    |    \\  | \\|  ___/|   |  \\/ __ \\_  |     \\   |  / /_/  >   Y  \\  | \\  ___/|  | \\/\r\n\\____|__  /__|   \\___  >___|  (____  /  \\___  /   |__\\___  /|___|  /__|  \\___  >__|   \r\n        \\/           \\/     \\/     \\/       \\/      /_____/      \\/          \\/       \r\n");

                Console.WriteLine("\t\t\tThis is a fight to de death or retires");
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t\t\tGMAE MENU");
                Console.WriteLine("\t\t\t\t\tn: New Game");
                Console.WriteLine("\t\t\t\t\tq: Quit");
                var choice = Console.ReadKey();

                switch (choice.Key)
                {
                    case ConsoleKey.N:
                        {
                            Console.Clear();
                            battle.Initializer();
                            battle.Run();

                        }
                        break;
                    case ConsoleKey.Q:
                        {
                            Console.Clear();
                            Console.WriteLine("Hej då");
                            System.Environment.Exit(0);

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Only use 1 or 2");
                        }
                        break;

                }
                Console.Clear();
            } while (true);




        }
        
    }
}
