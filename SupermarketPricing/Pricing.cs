namespace SupermarketPricing
{
    public class Pricing
    {
        private readonly string _name;
        private readonly int _quantity;
        private readonly Goods _goods;

        public Pricing(string name, int quantity, Goods goods)
        {
            _name = name;
            _quantity = quantity;
            _goods = goods;
        }

        public decimal GetPrice()
        {
            Good good = _goods.Find(_name);
            return good.Price * _quantity;
        }
    }
}
