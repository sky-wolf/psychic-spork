using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Arena_Fighter
{
    public class Dic
    {
        public byte RollDice(byte numberSides)
        {
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[1];
                               do
                {
                    rngCsp.GetBytes(randomNumber);
                }
                while (!IsFairRoll(randomNumber[0], numberSides));
                return (byte)((randomNumber[0] % numberSides) + 1);
            }
        }

        private bool IsFairRoll(byte roll, byte numSides)
        {

            int fullSetsOfValues = Byte.MaxValue / numSides;

            return roll < numSides * fullSetsOfValues;
        }

        public string GenerateName()
        {
            string resultat = "";
            string[] fName = new string[] {"Theni", "Nirarg", "Hjalgodril", "Burkur", "Thugar", "Santhe", "Gorrarg", "Gordu", "Guddur", "Maarg", "Dugrak", "Zaglinthud", "Lirom", "Hudi", "Hrimthral", "Rida", "Hlifto", "Glidar", "Hlifkhargrak", "Brand"};
            string[] eName = new string[] { "the Doughty", "the Discerning", "the Baneful", "the Scourge", "the Dictator", "the Immolated", "the Unforgiving", "the Queen", "the Druid", "the Elder", "the Shrewd", "the Fallen", "the Menace", "the Breaker", "the Mysterious", "the Voluminous", "the Spiritual", "the Faithless", "the Audacious", "the Daring" };

            resultat += fName[this.RollDice(20) - 1];
            resultat += " ";
            resultat += eName[this.RollDice(20) - 1]; 
            return resultat;
        }
    }
}
