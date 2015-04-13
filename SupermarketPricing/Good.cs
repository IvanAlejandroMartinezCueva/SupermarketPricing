﻿using System;
using System.Security.AccessControl;

namespace SupermarketPricing
{
    public class Good
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public string Type { get; private set; }

        public Good(string name, decimal price, int quantity, string type)
        {
            ValidateQuantity(quantity, type);

            Name = name;
            Price = price;
            Quantity = quantity;
            Type = type;
        }

        public Good(string name, decimal price, string type)
            : this(name, price, 1, type)
        {
        }

        private static void ValidateQuantity(int quantity, string type)
        {
            if (type == "SimplePricing" && quantity > 1)
            {
                throw new Exception("Quantity should be 1");
            }
            if (type == "GroupPricing" && quantity == 1)
            {
                throw new Exception("Quantity should be greater than 1");
            }
        }
    }
}
