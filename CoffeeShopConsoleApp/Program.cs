using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\n     COFFEE LIST\n");


            Console.ForegroundColor = ConsoleColor.DarkRed; // adding a Color for better visual

            Console.WriteLine("COFFEE:        STRENGTH: \n");
            List<Coffee> orderList = new List<Coffee>()
            {
                new BlackCoffee(),
                new Cortado(),
                new Latte(),
                new FlatWhite()
            };

            foreach (var coffee in orderList)
            {
                Console.WriteLine($"{coffee}:  {coffee.Strength()}  - PRICE  {coffee.Price()}");
            }

            Console.ForegroundColor = ConsoleColor.Blue; // adding a Color for better visual

            Console.WriteLine($"\n COFFEE:           MlMILK\n");
            List<IMilk> coffeeWithMilkList = new List<IMilk>()
            {
                new Latte(),
                new Cortado(),
                new FlatWhite()
            };

            foreach (var coffeeList in coffeeWithMilkList)
            {
                Console.WriteLine($"{coffeeList} ---------- {coffeeList.MlMilk()}");
            }

            Console.ForegroundColor = ConsoleColor.White; // adding a Color for better visual

        }
        
    }

}

