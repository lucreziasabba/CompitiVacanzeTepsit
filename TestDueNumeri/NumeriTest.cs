using Microsoft.VisualStudio.TestTools.UnitTesting;
using DueNumeri;

namespace TestDueNumeri
{
    [TestClass]
    public class NumeriTest
    {
        [TestMethod]
        public void Massimo1()
        {
            double x = Numeri.Massimo(3, 1);
            Assert.AreEqual(x, 3);
        }
        [TestMethod]
        public void Massimo2()
        {
            double x = Numeri.Massimo(1, 3);
            Assert.AreEqual(x, 3);
        }
        [TestMethod]
        public void Massimo3()
        {
            double x = Numeri.Massimo(1, 1);
            Assert.AreEqual(x, 1);
        }
        [TestMethod]
        public void Minimo1()
        {
            double x = Numeri.Minimo(1, 3);
            Assert.AreEqual(x, 1);
        }
        [TestMethod]
        public void Minimo2()
        {
            double x = Numeri.Minimo(3, 1);
            Assert.AreEqual(x, 1);
        }
        [TestMethod]
        public void Minimo3()
        {
            double x = Numeri.Minimo(3, 3);
            Assert.AreEqual(x, 3);
        }
        [TestMethod]
        public void Media1()
        {
            double x = Numeri.Media(3, 1);
            Assert.AreEqual(x, 2);
        }
        [TestMethod]
        public void Media2()
        {
            double x = Numeri.Media(1, 6);
            Assert.AreEqual(x, 3.5);
        }
        [TestMethod]
        public void Media3()
        {
            double x = Numeri.Media(3, 3);
            Assert.AreEqual(x, 3);
        }
    }
}
