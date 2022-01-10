using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaCalculadora;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

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
        public void producteVectorial()
        {
            int resultat;
            int[] array1 = { 0, 1, 2, 3 };
            int[] array2 = { 3, 2, 1, 0 };
            ClCalculadora kal = new ClCalculadora();
            resultat = kal.ProducteVectorial(array1, array2);
            Assert.AreEqual(4, resultat);
            Console.WriteLine("resultat: " + resultat);

        }
            
        [TestMethod]
        public void invertirVector()
        {
            int[] resultat = { };
            int[] array1 = {0,1,2,3};
            int[] array2 = {3,2,1,0};
            ClCalculadora kal = new ClCalculadora();
            resultat = kal.invertirVector(array1);
            CollectionAssert.AreEqual(array2, resultat);
            Console.WriteLine("resultatt: " + resultat);
        }

        [TestMethod]
        public void ordenarVector()
        {
            char[] resultat = { };
            char[] array1 = { 'd', 'c', 'b', 'a' };
            char[] vectorOrdenat = { 'a', 'b', 'c', 'd' };
            ClCalculadora kal = new ClCalculadora();
            resultat = kal.OrdenarVector(array1);
            CollectionAssert.AreEqual(vectorOrdenat, resultat);
            Console.WriteLine("resultatt: " + resultat);
        }

        [TestMethod]
        public void buscarMaximo()
        {
            int resultat;
            int[] array1 = {1, 2, 3, 5};
            int max = array1.Max();
            ClCalculadora kal = new ClCalculadora();
            resultat = kal.buscarMaximo(array1);
            Assert.AreEqual(max, resultat);
            Console.WriteLine("resultatt: " + resultat);
        }
        [TestMethod]
        public void buscarMaximo2()
        {
            int resultat;
            int[] array1 = { 1, 2, 3, 8 };
            int max = array1.Max();
            ClCalculadora kal = new ClCalculadora();
            resultat = kal.buscarMaximo2(array1);
            Assert.AreEqual(max, resultat);
            Console.WriteLine("resultatt: " + resultat);
        }
        [TestMethod]
        public void buscarMinimo()
        {
            int resultat;
            int[] array1 = { 1, 5, 4, 8 };
            int min = array1.Min();
            ClCalculadora kal = new ClCalculadora();
            resultat = kal.buscarMinimo(array1);
            Assert.AreEqual(min, resultat);
            Console.WriteLine("resultatt: " + resultat);
        }
        [TestMethod]
        public void QuantesVegades()
        {
            int resultat;
            String cadena = "hola tonto";
            char lletra = 'o';
            int countLletra = 3;

            ClCalculadora kal = new ClCalculadora();
            resultat = kal.QuantesVegades(cadena, lletra);
            Assert.AreEqual(countLletra, resultat);
            Console.WriteLine("resultatt: " + resultat);
        }
        
        [TestMethod]
        public void OnEs()
        {
            int[] resultat = { };
            String cadena = "hola tonto";
            char lletra = 'o';
            int[] pos = {1,6,9};

            ClCalculadora kal = new ClCalculadora();
            resultat = kal.OnEs(cadena, lletra);
            CollectionAssert.AreEqual(pos, resultat);
            Console.WriteLine("resultatt: " + resultat);
        }
        
        [TestMethod]
        public void QuantesVocals()
        {
            int resultat;
            String cadena = "hola tonto";

            int numV = 4;

            ClCalculadora kal = new ClCalculadora();
            resultat = kal.QuantesVocals(cadena);
            Assert.AreEqual(numV, resultat);
            Console.WriteLine("resultatt: " + resultat);
        }

        [TestMethod]
        public void QuantesConsonants()
        {
            int resultat;
            String cadena = "hola tonto";
            int numConsonants = 4;

            ClCalculadora kal = new ClCalculadora();
            resultat = kal.QuantesConsonants(cadena);
            Assert.AreEqual(numConsonants, resultat);
            Console.WriteLine("resultatt: " + resultat);
        }
    }
}
