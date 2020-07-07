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
            string [] Ingredientes = Order.ProcesarStringIngredientes("Jamón,Hongos,Jalapeños");
            string[] Esperado = { "Jamón", "Hongos", "Jalapeños" };
            CollectionAssert.AreEqual(Esperado, Ingredientes);
        }

        [TestMethod]
        public void CalculoPrecioSinImpuestoCorrectoPequena()
        {
            OrdenModel Order = new OrdenModel();
            double precio =Order.CalculoPrecioSinImpuesto(4, "Pequeña");
            Assert.AreEqual(4700,precio);

        }

        [TestMethod]
        public void CalculoPrecioSinImpuestoCorrectoMediana()
        {
            OrdenModel Order = new OrdenModel();
            double precio = Order.CalculoPrecioSinImpuesto(3, "Mediana");
            Assert.AreEqual(5050, precio);

        }

        [TestMethod]
        public void CalculoPrecioSinImpuestoCorrectoGrande()
        {
            OrdenModel Order = new OrdenModel();
            double precio = Order.CalculoPrecioSinImpuesto(5, "Grande");
            Assert.AreEqual(8350, precio);

        }

        [TestMethod]
        public void CalculoImpuestoCorrecto()
        {
            OrdenModel Order = new OrdenModel();
            double Impuesto = Order.CalculoImpuesto(8500);
            Assert.AreEqual(1105, Impuesto);
        }

       

    }
}
