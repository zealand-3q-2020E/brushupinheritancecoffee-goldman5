using System.Threading;

namespace CoffeeShopConsoleApp
{
    class FlatWhite : Coffee, IMilk
    {
        public FlatWhite(int discount) : base(0)
        {
            Discount = discount;
        }

        public FlatWhite()
        {
        }

        public override string Strength()
        {
            return $"So so!";
        }
        public int MlMilk()
        {
            return 100;
        }

        public override int Price()
        {
            return 50 - base.Discount;
        }

        public override string ToString()
        {
            return $"Flat White";
        }
    }
}
