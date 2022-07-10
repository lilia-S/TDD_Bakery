using System;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Hi, our bread costs 5$ for each. Enter you the amount you want to order.");
            var breadAmount = Int32.Parse(Console.ReadLine());
            Bread bread = new Bread(breadAmount, 5);
            var breadPrice = bread.calculatePrice();
            
            
            Console.WriteLine("Hi, our pastry costs 2$ for each. Enter you the amount you want to order.");
            var pastryAmount = Int32.Parse(Console.ReadLine());
            Pastry pastry = new Pastry(pastryAmount, 2);
            Console.WriteLine("Hi, Here is your order --------------------------------------->");
            Console.WriteLine("You choose Bread: {0}", bread.Amount);
            Console.WriteLine("You choose Pastry: {0}", pastry.Amount);
            var pastryPrice = pastry.calculatePrice();
            var totalCost = breadPrice + pastryPrice;
            Console.WriteLine("The total cost of order is: {0}", totalCost);
        }
    }
}
