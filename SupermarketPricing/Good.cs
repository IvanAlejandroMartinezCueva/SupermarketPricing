using System.Security.AccessControl;

namespace SupermarketPricing
{
    public class Good
    {
        public string Name { get; set; }
        public int Group { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }

        public Good(string name, int group, string unit, decimal price)
        {
            Name = name;
            Group = group;
            Unit = unit;
            Price = price;
        }
    }
}
