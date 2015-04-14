using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using SupermarketPricing;

namespace SupermarketPricingTest
{
    [TestFixture]
    public class GoodTest
    {
        private Good _good;
        private string _name = "Soap";
        private decimal _price = 0.65m;
        private int _quantity = 1;
        private string _type = "SimplePricing";

        [SetUp]
        public void SetUp()
        {
            _good = new Good(_name, _price, _quantity, _type);
        }

        [Test]
        public void ShouldHaveName()
        {
            Assert.That(_good.Name, Is.EqualTo(_name));
        }

        [Test]
        public void ShouldHavePrice()
        {
            Assert.That(_good.Price, Is.EqualTo(_price));
        }

        [Test]
        public void ShouldHaveQuantity()
        {
            Assert.That(_good.Quantity, Is.EqualTo(1));
        }

        [Test]
        public void ShouldHaveType()
        {
            Assert.That(_good.Type, Is.EqualTo(_type));
        }

        [Test]
        public void ShouldHaveQuantityEqualTo1IfTypeIsSimplePricing()
        {
            _name = "Soap";
            _price = 0.65m;
            _type = "SimplePricing";

            _good = new Good(_name, _price, _type);

            Assert.That(_good.Type, Is.EqualTo(_type));
            Assert.That(_good.Quantity, Is.EqualTo(1));
        }

        [Test]
        [ExpectedException(typeof(QuantityException))]
        public void ShouldThrowAnExceptionWhenQuantityIsGreaterThan1IfTypeIsSimplePricing()
        {
            _name = "Soap";
            _price = 0.65m;
            _type = "SimplePricing";
            _quantity = 2;

            _good = new Good(_name, _price, _quantity, _type);
        }

        [Test]
        public void ShouldHaveQuantityGreaterThan1IfTypeIsGroupPricing()
        {
            _name = "Soap";
            _price = 1m;
            _type = "GroupPricing";
            _quantity = 2;

            _good = new Good(_name, _price, _quantity, _type);

            Assert.That(_good.Type, Is.EqualTo("GroupPricing"));
            Assert.That(_good.Quantity, Is.GreaterThan(1));
        }

        [Test]
        [ExpectedException(typeof(QuantityException))]
        public void ShouldReturnAnExceptionWhenQuantityIs1IfTypeIsGroupPricing()
        {
            _name = "Soap";
            _price = 1m;
            _type = "GroupPricing";
            _quantity = 1;

            _good = new Good(_name, _price, _quantity, _type);
        }
    }
}
