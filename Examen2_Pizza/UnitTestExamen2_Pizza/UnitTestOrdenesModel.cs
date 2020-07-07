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
            OrdenModel order = new OrdenModel();
            string [] Ingredientes = order.ProcesarStringIngredientes("Jamón,Hongos,Jalapeños");
            string[] Esperado = { "Jamón", "Hongos", "Jalapeños" };
            CollectionAssert.AreEqual(Esperado, Ingredientes);
        }
    }
}
