using System;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffee orders
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
            return 20;
        }

                    // I didn't understand much the last part of question 7

        private int _discount;
        public int Discount
        {
            get { return _discount; }
            set
            {
                if (value <= 5)
                {
                    _discount = value;
                }
                else
                {
                    throw new ArgumentException($"Nobody gets such a big discount!");
                }
            }
        }

        //CTORs
        public Coffee( int discount)
        {
            Discount = discount ;
        }

        public Coffee() { }


        // Abstract Method do not use body - it means that it has to be implemented and override in other classes
        public abstract string Strength();

    }
}
