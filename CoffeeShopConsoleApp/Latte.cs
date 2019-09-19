using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Latte:Coffee,IMilk
    {
        public Latte() : base()
        {

        }
        public override int Price()
        {
            return 40;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public override string TypeOfCoffee()
        {
            return "Latte";
        }


        int IMilk.MLMilk()
        {
            return 200;
        }

    }
}
