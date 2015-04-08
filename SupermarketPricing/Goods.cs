using System.Collections.Generic;

namespace SupermarketPricing
{
    public class Goods : IPrice
    {
        public List<Good> Stock { get; set; }
        public Goods()
        {
            Stock = new List<Good>();
        }

        public void AddPrice(string good, int group, decimal price)
        {
            Stock.Add(new Good(good, group, "unidad", price));
        }

        public void AddPriceContinue(string good, int group, string unit, decimal price)
        {
            Stock.Add(new Good(good, group, unit, price));
        }
    }
}
