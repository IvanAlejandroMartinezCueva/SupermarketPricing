using System.Collections.Generic;

namespace SupermarketPricing
{
    public class Goods// : IPrice
    {
        private List<Good> PricesList;

        public int Count
        {
            get { return PricesList.Count; }
        }

        public Goods()
        {
            PricesList = new List<Good>();
        }

        public void Add(Good good)
        {
            PricesList.Add(good);
        }

        public void Clear()
        {
            PricesList.Clear();
        }

        public Good Find(string name)
        {
            return PricesList.Find(good => good.Name == name);
        }
    }
}
