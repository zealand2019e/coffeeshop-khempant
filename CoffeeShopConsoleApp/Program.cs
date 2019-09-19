using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Cortado(),
                new Latte(),
                new BlackCoffee(),

            };

            Console.WriteLine("Here you Know the type of coffee," +
               "its strength and price. ");
            foreach (var coffeeItem in orderList)
            {
                Console.WriteLine(coffeeItem.ToString());
            }
            Console.WriteLine("press any key to see the orderListMilk");
            Console.ReadLine();

            // List contaning objects that implements IMilk interface.
            var OrderListMilk = new List<IMilk>()
            {
                new Cortado(),
                new Latte(),
            };
            foreach (var coffeeItem in OrderListMilk)
            {
                Console.WriteLine($"The amount of Milk used is : {coffeeItem.MLMilk()}");
            }
            Console.WriteLine("press a key to see the typecast");
            Console.ReadLine();

            foreach (var coffeeItem in orderList)
            {
                if (coffeeItem is IMilk)
                {
                    // the item emplements the IMilk so i casted to this

                    IMilk cItem = coffeeItem as IMilk;
                    Console.WriteLine("Iam an IMilk object");

                    // the only method in IMilk is MLMilk so i print it out
                    Console.WriteLine($" Milk used is {cItem.MLMilk()}");
                }
                else
                    Console.WriteLine("Iam not IMilk");





            }
        }
    }
}
