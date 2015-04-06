using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SupermarketPricing;

namespace SupermarketPricingTest
{
    [TestFixture]
    public class TestSupermarketPricing
    {
        [Test]
        public void TestSimplePricing()
        {
            var pricing = new Pricing("Beans", 1);
            var price = pricing.GetPrice();
            Assert.IsTrue(price == 1);
        }

    }
}
