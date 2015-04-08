using System.Collections.Generic;

namespace SupermarketPricing
{
    public class Goods
    {
        public List<Good> Stock { get; set; }
        public Goods()
        {
            Stock = new List<Good>();
        }

        public void AddPrice(string good, int group, decimal price)
        {
            Stock.Add(new Good(good, group, price));
        }
    }
}
