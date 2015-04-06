using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPricing
{
    public class Pricing
    {
        public string good { get; set; }
        public int quantity { get; set; }

        public Pricing(string good, int quantity)
        {
            this.good = good;
            this.quantity = quantity;
        }

        public int GetPrice()
        {
            var price = 0;
            if (good == "Beans" && quantity == 1)
            {
                price = 1;
            }
            return price;
        }
    }
}
