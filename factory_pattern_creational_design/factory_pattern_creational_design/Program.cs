using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern_creational_design
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cardType = "MoneyBack";

            ICreditCard creditCard = null;

            if(cardType == "MoneyBack")
            {
                creditCard = new Moneyback();
            }else if(cardType == "Titanium")
            {
                creditCard = new Titanium();
            }else if( cardType == "Platinum")
            {
                creditCard = new PlatinumCard();
            }

            Console.WriteLine(creditCard.GetCardType());

        }
    }
}
