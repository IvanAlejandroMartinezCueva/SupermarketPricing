namespace SupermarketPricing
{
    public class Pricing
    {
        public string Good { get; set; }
        public int Quantity { get; set; }
        public IPrice Goods { get; set; }
        public decimal ContinuousQuantity { get; set; }

        public Pricing(string good, int quantity)
        {
            Good = good;
            Quantity = quantity;
        }

        public Pricing(string good, int quantity, IPrice goods)
        {
            Good = good;
            Quantity = quantity;
            Goods = goods;
        }

        public Pricing(string good, decimal continuousQuantity, IPrice goods)
        {
            Good = good;
            ContinuousQuantity = continuousQuantity;
            Goods = goods;
        }

        public decimal GetPrice()
        {
            decimal totalPrice = 0;
            if (Goods == null)
            {
                return 1;
            }

            var product = Goods.Stock.FindAll(x => x.Name == Good);

            var restQuantity = Quantity;

            foreach (var item in product)
            {
                if (item.Group > 1)
                {
                    totalPrice += item.Price * (Quantity / item.Group);
                    restQuantity = Quantity - (Quantity / item.Group) * item.Group;
                }
            }

            foreach (var item in product)
            {
                if (item.Group == 1)
                {
                    totalPrice += restQuantity*item.Price;
                }
            }

            return totalPrice;
        }

        public decimal GetContinuousPrice()
        {
            var product = Goods.Stock.Find(x => x.Name == Good);
            return ContinuousQuantity*product.Price;
        }
    }
}
