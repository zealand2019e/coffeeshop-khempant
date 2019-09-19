using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class BlackCoffee:Coffee
    {
        public override int Price()
        {
            return 20;
        }

        public override string Strength()
        {
            return "Strong";
        }

        public override string TypeOfCoffee()
        {
            return "Blackcoffee";
        }
    }
}
