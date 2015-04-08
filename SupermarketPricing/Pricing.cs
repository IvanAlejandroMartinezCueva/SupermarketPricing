namespace SupermarketPricing
{
    public class Pricing
    {
        public string Good { get; set; }
        public int Quantity { get; set; }
        public Goods Goods { get; set; }

        public Pricing(string good, int quantity)
        {
            Good = good;
            Quantity = quantity;
        }

        public Pricing(string good, int quantity, Goods goods)
        {
            Good = good;
            Quantity = quantity;
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

            int restQuantity = Quantity;

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
    }
}
