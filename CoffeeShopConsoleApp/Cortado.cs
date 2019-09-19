using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Cortado:Coffee,IMilk
    {
        public Cortado() : base()
        {

        }
        public override int Price()
        {
            return 25;
        }

        public override string Strength()
        {
            return "Medium";
        }

        public override string TypeOfCoffee()
        {
            return "Cortado";
        }


        public int MLMilk()
        {
            return 40;
        }
    }
}
