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
            var pricing = new Pricing("Soap", 1);
            var price = pricing.GetPrice();
            Assert.IsTrue(price == 1);
        }

        [Test]
        public void TestCreateGoodsAndGetSimplePricing()
        {
            var goods = new Goods();
            goods.AddPrice("Soap", 1, new decimal(0.65));

            var pricing = new Pricing("Soap", 10, goods);
            var price = pricing.GetPrice();
            Assert.IsTrue(price == new decimal(6.5));
        }

        [Test]
        public void TestCreateGoodsAndGetGroupPricing()
        {
            var goods = new Goods();
            goods.AddPrice("Soap", 3, 1);

            var pricing = new Pricing("Soap", 3, goods);
            var price = pricing.GetPrice();
            Assert.IsTrue(price == 1);
        }

        [Test]
        public void TestCreateGoodsAndGetSimpleAndGroupPricing()
        {
            var goods = new Goods();
            goods.AddPrice("Soap", 1, new decimal(0.5));
            goods.AddPrice("Soap", 3, 1);
            //goods.AddPrice("Soap", 2, new decimal(0.5));

            var pricing = new Pricing("Soap", 4, goods);
            var price = pricing.GetPrice();
            Assert.IsTrue(price == new decimal(1.5));
        }
    }
}
