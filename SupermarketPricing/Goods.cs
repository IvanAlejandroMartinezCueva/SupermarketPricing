using System;
using System.Collections.Generic;

namespace SupermarketPricing
{
    public class Goods : IComparable<List<Good>>
    // : IPrice
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

        public List<Good> GetList()
        {
            return PricesList;
        }

        public int CompareTo(List<Good> other)
        {
            if (PricesList.Count != other.Count)
            {
                return -1;
            }
            for (int i = 0; i < PricesList.Count; i++)
            {
                if (PricesList[i].CompareTo(other[i]) == -1)
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
