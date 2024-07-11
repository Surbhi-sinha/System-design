using System;
namespace factory_pattern_creational_design
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCardNumber();
        int GetCardId();
        int GetCardLimit();

    }
}
