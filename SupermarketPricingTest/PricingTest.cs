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

        //[Test]
        //public void TestCreateGoodsAndGetSimplePricing()
        //{
        //    var goods = new Goods();
        //    goods.AddPrice("Soap", 1, new decimal(0.65));

        //    var pricing = new Pricing("Soap", 10, goods);
        //    var price = pricing.GetPrice();
        //    Assert.IsTrue(price == new decimal(6.5));
        //}

        //[Test]
        //public void TestCreateGoodsAndGetGroupPricing()
        //{
        //    var goods = new Goods();
        //    goods.AddPrice("Soap", 3, 1);

        //    var pricing = new Pricing("Soap", 3, goods);
        //    var price = pricing.GetPrice();
        //    Assert.IsTrue(price == 1);
        //}

        //[Test]
        //public void TestCreateGoodsAndGetSimpleAndGroupPricing()
        //{
        //    var goods = new Goods();
        //    goods.AddPrice("Soap", 1, new decimal(0.5));
        //    goods.AddPrice("Soap", 3, 1);
        //    //goods.AddPrice("Soap", 2, new decimal(0.5));

        //    var pricing = new Pricing("Soap", 4, goods);
        //    var price = pricing.GetPrice();
        //    Assert.IsTrue(price == new decimal(1.5));
        //}

        //[Test]
        //public void TestCreateContinueGoodsAndGetPrice()
        //{
        //    var goods = new Goods();
        //    goods.AddPriceContinue("Meat", 1, "pound", new decimal(1.80));

        //    var pricing = new Pricing("Meat", new Decimal(0.5), goods);
        //    var price = pricing.GetContinuousPrice();
        //    Assert.IsTrue(price == new decimal(0.9));
        //}
    }
}
