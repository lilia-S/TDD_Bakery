using System;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {   
            Bread bread = new Bread(1, 5);
            var breadPrice = bread.calculatePrice();
            Pastry pastry = new Pastry(1, 2);
            Console.WriteLine("Hi, Here is your order --------------------------------------->");
            Console.WriteLine("You choose Bread: {0}", bread.Amount);
            Console.WriteLine("You choose Pastry: {0}", pastry.Amount);
            var pastryPrice = pastry.calculatePrice();
            var totalCost = breadPrice + pastryPrice;
            Console.WriteLine("The total cost of order is: {0}", totalCost);
        }
    }
}
