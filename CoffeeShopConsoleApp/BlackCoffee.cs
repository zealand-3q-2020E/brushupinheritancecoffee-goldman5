using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee: Coffee
    {
        public override string Strength()
        {
            return $"Strong";
        }

        public override string ToString()
        {
            return $"BlackCoffee";
        }
    }
}
