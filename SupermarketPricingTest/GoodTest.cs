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
        private string _name;
        private decimal _price;
        private int _quantity;
        private string _type;

        [Test]
        public void ShouldHaveNamePriceQuantityAndType()
        {
            _name = "Soap";
            _price = 0.65m;
            _quantity = 1;
            _type = "SimplePricing";

            _good = new Good(_name, _price, _quantity, _type);

            Assert.That(_good.Name, Is.EqualTo(_name));
            Assert.That(_good.Price, Is.EqualTo(_price));
            Assert.That(_good.Quantity, Is.EqualTo(1));
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
        public void ShouldThrowAnExceptionWhenQuantityIsGreaterThan1IfTypeIsSimplePricing()
        {
            try
            {
                _name = "Soap";
                _price = 0.65m;
                _type = "SimplePricing";
                _quantity = 2;

                _good = new Good(_name, _price, _quantity, _type);
            }
            catch (Exception ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Quantity should be 1"));
            }
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
        public void ShouldReturnAnExceptionWhenQuantityIs1IfTypeIsGroupPricing()
        {
            try
            {
                _name = "Soap";
                _price = 1m;
                _type = "GroupPricing";
                _quantity = 1;

                _good = new Good(_name, _price, _quantity, _type);
            }
            catch (Exception ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Quantity should be greater than 1"));
            }
        }
    }
}
