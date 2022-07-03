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

        [Test]
        public void BreadChoose_GetZeroCost0_true()
        {
            Bread bread = new Bread(0, 5);
            var breadPrice = bread.calculatePrice();

            Assert.AreEqual(0, breadPrice);
        }

        [Test]
        public void BreadChoose_GetElevenCost40_true()
        {
            Bread bread = new Bread(11, 5);
            var breadPrice = bread.calculatePrice();

            Assert.AreEqual(40, breadPrice);
        }

        [Test]
        public void BreadChoose_Get100Cost335_true()
        {
            Bread bread = new Bread(100, 5);
            var breadPrice = bread.calculatePrice();

            Assert.AreEqual(335, breadPrice);
        }

        [Test]
        public void PastryChoose_Get1Cost2_true()
        {
            Pastry pastry = new Pastry(1, 2);
            var pastryPrice = pastry.calculatePrice();

            Assert.AreEqual(2, pastryPrice);
        }

        [Test]
        public void PastryChoose_Get3Cost5_true()
        {
            Pastry pastry = new Pastry(3, 2);
            var pastryPrice = pastry.calculatePrice();

            Assert.AreEqual(5, pastryPrice);
        }

        [Test]
        public void PastryChoose_Get2Cost4_true()
        {
            Pastry pastry = new Pastry(2, 2);
            var pastryPrice = pastry.calculatePrice();

            Assert.AreEqual(4, pastryPrice);
        }

        [Test]
        public void PastryChoose_Get3Cost5_true()
        {
            Pastry pastry = new Pastry(2, 2);
            var pastryPrice = pastry.calculatePrice();

            Assert.AreEqual(4, pastryPrice);
        }
    }
}