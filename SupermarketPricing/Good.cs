namespace SupermarketPricing
{
    public class Good
    {
        public string Name { get; set; }
        public int Group { get; set; }
        public decimal Price { get; set; }

        public Good(string name, int group, decimal price)
        {
            Name = name;
            Group = group;
            Price = price;
        }
    }
}
