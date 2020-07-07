using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen2_Pizza.Models;

namespace UnitTestExamen2_Pizza
{
    [TestClass]
    public class UnitTestOrdenesModel
    {
        [TestMethod]
        public void ProcesarIngredientes()
        {
            OrdenModel Order = new OrdenModel();
            string [] Ingredientes = Order.ProcesarStringIngredientes("Jam�n,Hongos,Jalape�os");
            string[] Esperado = { "Jam�n", "Hongos", "Jalape�os" };
            CollectionAssert.AreEqual(Esperado, Ingredientes);
        }

        [TestMethod]
        public void CalculoPrecioSinImpuestoCorrecto()
        {
            OrdenModel Order = new OrdenModel();
            double precio =Order.CalculoPrecioSinImpuesto(4, "Mediana");
            Assert.AreEqual(7900,precio);

        }
    }
}
