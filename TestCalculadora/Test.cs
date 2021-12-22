using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaCalculadora;
using System;

namespace TestCalculadora
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void ProvaSumar()
        {
            int resultat = 0;

            ClCalculadora kal = new ClCalculadora();
            resultat = kal.Sumar(10, 24);
            Assert.AreEqual(34, resultat);
            resultat = kal.Sumar(23, 42);
            Assert.AreEqual(65, resultat);
        }

        [TestMethod]
        public void ProvaMultiplicar()
        {
            int resultat = 0;

            ClCalculadora kal = new ClCalculadora();
            resultat = kal.Multiplicar(100000,100000);
            Assert.AreEqual(1000000000, resultat);

        }
        [TestMethod]
        public void ProvaSumaVector()
        {
            int[] v1 = { 0, 13, 45, 37, 12 };

            int[] v2 = { 0, 13, 45, 37, 12 };


        }
    }
}
