using System;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int Price()
        {
            return 20 - Discount;
        }

                                         // I didnt understand much the last part of question 7
        private int _discount;

        public int Discount
        {
            get { return _discount; }
            set
            {
                if (value > 5)
                    _discount = value;
                {
                    throw new ArgumentException($"Nobody gets such a big discount!");
                }
            }
        }

        public Coffee()
        {

        }
        // Abstract Method do not use body - it means that it has to be implemented and overided in other classes
        public abstract string Strength();

    }
}
