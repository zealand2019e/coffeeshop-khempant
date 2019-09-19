using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        /// <summary>
        public Coffee()
        {

        }
        public virtual int Price()
        {
            return 20;
        }
        public abstract string Strength();
        public abstract string TypeOfCoffee();
        public override string ToString()
        {
            return $"Iam a {this.TypeOfCoffee()}, and my price is {this.Price()}, and the strength of me is {this.Strength()} ";
        }

    }
}
