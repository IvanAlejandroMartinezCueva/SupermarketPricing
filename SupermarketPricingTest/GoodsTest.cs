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
    public class GoodsTest
    {
        private Goods _goods;
        private Good _good;

        [Test]
        public void ShouldHaveAnEmptyList()
        {
            _goods = new Goods();

            Assert.That(_goods.Count,Is.EqualTo(0));
        }

        [Test]
        public void ShouldHaveAnItemWhenAGoodIsAdded()
        {
            _good = new Good("Soap",0.65m,"SimplePricing");
            
            _goods = new Goods();
            _goods.Add(_good);

            Assert.That(_goods.Count,Is.EqualTo(1));
        }

        [Test]
        public void ShouldHaveMoreThanOneItemWhenGoodsAreAdded()
        {
            _goods = new Goods();
            _goods.Add(new Good("Soap", 0.65m, "SimplePricing"));
            _goods.Add(new Good("Soup", 1.8m, "SimplePricing"));

            Assert.That(_goods.Count,Is.GreaterThan(1));
        }

        [Test]
        public void ShouldHaveNoItemsWhenListIsCleared()
        {
            _goods = new Goods();
            _goods.Add(new Good("Soap", 0.65m, "SimplePricing"));
            _goods.Add(new Good("Soup", 1.8m, "SimplePricing"));

            _goods.Clear();

            Assert.That(_goods.Count,Is.EqualTo(0));
        }

        [Test]
        public void ShouldFindAGood()
        {
            _goods = new Goods();
            _goods.Add(new Good("Soap", 0.65m, "SimplePricing"));
            _goods.Add(new Good("Soup", 1.8m, "SimplePricing"));

            Good good = _goods.Find("Soap");

            Assert.That(good,Is.Not.Null);
            Assert.That(good.Name,Is.EqualTo("Soap"));
        }
    }
}
