using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern_creational_design
{
    internal class Titanium : ICreditCard
    {
        public int GetCardId()
        {
            Console.WriteLine("Titanium Card id : ");
            return 130;
        }

        public int GetCardLimit()
        {
            return 100000;
        }

        public int GetCardNumber()
        {
            return 130;
        }

        public string GetCardType()
        {
            return "Titanium Card ";
        }
    }
}
