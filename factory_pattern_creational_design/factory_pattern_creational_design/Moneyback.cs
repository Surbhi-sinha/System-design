using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern_creational_design
{
    public class Moneyback : ICreditCard
    {
        public int GetCardId()
        {
            Console.WriteLine("Money back Card Id : ");
            return 230;
        }

        public int GetCardLimit()
        {
            return 50000;
        }

        public int GetCardNumber()
        {
            return 230;
        }

        public string GetCardType()
        {
            return "Money Back";
        }
    }
}
