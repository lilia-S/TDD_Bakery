using NUnit.Framework;

namespace Bakery.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BreadChoose_GetOneCost5_true()
        {
            Bread bread = new Bread(1, 5);
            var breadPrice = bread.calculatePrice();

            Assert.AreEqual(5, breadPrice);
        }

        [Test]
        public void BreadChoose_GetTwoCost10_true()
        {
            Bread bread = new Bread(2, 5);
            var breadPrice = bread.calculatePrice();

            Assert.AreEqual(10, breadPrice);
        }

        [Test]
        public void BreadChoose_GetThreeCost10_true()
        {
            Bread bread = new Bread(3, 5);
            var breadPrice = bread.calculatePrice();

            Assert.AreEqual(10, breadPrice);
        }

        [Test]
        public void BreadChoose_GetFourCost15_true()
        {
            Bread bread = new Bread(4, 5);
            var breadPrice = bread.calculatePrice();

            Assert.AreEqual(15, breadPrice);
        }
    }
}