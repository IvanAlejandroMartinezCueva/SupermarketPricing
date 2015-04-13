using System;
using NUnit.Framework;
using SupermarketPricing;

namespace SupermarketPricingTest
{
    [TestFixture]
    public class PricingTest
    {
        private Goods _goods;
        [Test]
        public void TestSimplePricing()
        {
            _goods = new Goods();
            _goods.Add(new Good("Soap", 0.65m, "SimplePricing"));

            var pricing = new Pricing("Soap", 1, _goods);
            var price = pricing.GetPrice();
            Assert.That(price, Is.EqualTo(0.65m));
        }
    }
}
