using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Arena_Fighter
{
    public class Round
    {
        Character enemy;
        Dic dic = new Dic();
        public Round(){}

        

        public void Run(Character player, int omgong)
        {
            enemy = new Character();

            enemy.Create(dic.GenerateName());
            int toggle = 10;
           
            while (player.IsAlive() && enemy.IsAlive())
            {
                toggle = (int)dic.RollDice(2);
                //Console.WriteLine(toggle);//for test
                switch (toggle)
                {
                    case 1:
                        {
                            this.Attack(player, enemy);
                            Console.WriteLine("player attacks enimy");
                        }break;

                    case 2:
                        {
                            this.Defense(player, enemy);
                            Console.WriteLine("enemy attacks player");
                        }
                        break;
                }


                Console.Read();
                Console.Clear();

            }
        }

        public string Namn()
        {
            return this.enemy.Name;
        }

        public void Attack(Character playerOne, Character playerTwo)
        {
            int p_dic = (int)dic.RollDice(6);
            int e_dic = (int)dic.RollDice(6);

            int attack = playerOne.Attack(p_dic);
            int deffense = playerTwo.Defense(e_dic);

            Console.WriteLine($" {playerOne.Name} HP: {playerOne.Healt} rolls a {p_dic}");
            Console.WriteLine($" {playerTwo.Name} HP: {playerTwo.Healt} rolls a {e_dic}");

            if (attack > deffense)
            {
                Console.WriteLine($"{playerOne.Name} lands a blow on {playerTwo.Name}");

                int strike = playerOne.Weapon - playerTwo.Armor;
                if (strike <= 0)
                {
                    Console.WriteLine($"{playerTwo.Name}  armor proteckten from admige");
                    strike = 0;
                }

                Console.WriteLine($"and givs {strike} in damages ");

                playerTwo.Healt = playerTwo.Healt - strike;
            }
            else
            {
                Console.WriteLine($"{playerTwo.Name} stops {playerOne.Name} attack");
            }
        }

        public void Defense(Character playerOne, Character playerTwo)
        {
            int p_dic = (int)dic.RollDice(6);
            int e_dic = (int)dic.RollDice(6);

            int attack = playerTwo.Attack(e_dic);
            int deffense = playerOne.Defense(p_dic);

            Console.WriteLine($" {playerOne.Name} HP: {playerOne.Healt} rolls a {p_dic}");
            Console.WriteLine($" {playerTwo.Name} HP: {playerTwo.Healt} rolls a {e_dic}");

            if (attack > deffense)
            {
                Console.WriteLine($"{playerTwo.Name} lands a blow on {playerOne.Name}");
                Console.WriteLine($"and givs {attack - deffense} in damages ");

                int strike = playerTwo.Weapon - playerOne.Armor;
                if (strike <= 0)
                {
                    Console.WriteLine($"{playerOne.Name}  armor proteckten from admige");
                    strike = 0;
                }

                playerOne.Healt = playerOne.Healt - strike;
            }
            else
            {
                Console.WriteLine($"{playerOne.Name} stops {playerTwo.Name} attack");
            }
        }
    }
}
