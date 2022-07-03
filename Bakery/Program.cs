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

            var pastryPrice = pastry.calculatePrice();
        }
    }
}
