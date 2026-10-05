using AppParcial1;

namespace Parcial1.Tests
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Sumar1()
        {
            Sumador sumador = new Sumador();
            int suma = sumador.Sumar(1, 3);
            Assert.AreEqual(4, suma);
        }

        [TestMethod]
        public void Sumar2()
        {
            Sumador sumador = new Sumador();
            int suma = sumador.Sumar(0, 0);
            Assert.AreEqual(0, suma);
        }
    }
}
