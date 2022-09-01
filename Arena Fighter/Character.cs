using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter
{
    public class Character
    {
        Dic dic = new Dic();

        private string name = "";
        private int strength = 0;
        private int healt = 0;
        private int maxhealt = 0;
        private int armor = 0;
        private int weapon = 1;
        private int currency = 0;


        public bool IsAlive()
        {
            return (healt > 0);
        }

        public void Create(string name, int multi = 1)
        {
            this.name = name;
            this.strength = (int)dic.RollDice(6);
            maxhealt = this.Healt = (int)dic.RollDice(6) * multi;
        }

        public int Attack(int dice)
        {
            return this.strength + dice;
        }

        public int Defense(int dice)
        {
            return this.strength + dice;
        }

        public string Name 
        {
            get { return this.name; }
        }
        public int Healt 
        { 
            get { return this.healt; }
            set { this.healt = value; }
        }

        public int Armor { get => armor; set => armor = value; }
        public int Currency { get => currency; set => currency = value; }
        public int Maxhealt { get => maxhealt; }
        public int Strength { get => strength; set => strength = value; }
        public int Weapon { get => weapon; set => weapon = value; }

        public void charecterSpec()
        {
            Console.WriteLine($"{this.name} HP: '{this.healt}' Strength: '{this.strength}' Armor: '{this.armor}' Weapon: '{this.weapon}'");
        }
    }
}
