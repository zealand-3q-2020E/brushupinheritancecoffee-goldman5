namespace CoffeeShopConsoleApp
{
    class FlatWhite : Coffee, IMilk
    {
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
            return 35;
        }


        public override string ToString()
        {
            return $"Flat White";
        }
    }
}
