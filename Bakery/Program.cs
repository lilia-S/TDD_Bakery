using System;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {   

            Bread bread = new Bread(1, 5);

            var breadPrice = bread.calculatePrice();
        }
    }
}
