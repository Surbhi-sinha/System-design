using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern_creational_design
{
    internal class PlatinumCard : ICreditCard
    {
        public int GetCardId()
        {
            Console.WriteLine("Platinum card Id :");
            return 10;
        }

        public int GetCardLimit()
        {
            return 2000000;
        }

        public int GetCardNumber()
        {
            return 10;
        }

        public string GetCardType()
        {
            return "Platinum Card";
        }
    }
}
