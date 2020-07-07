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
            string [] Ingredientes = order.ProcesarStringIngredientes("Jam�n,Hongos,Jalape�os");
            string[] Esperado = { "Jam�n", "Hongos", "Jalape�os" };
            CollectionAssert.AreEqual(Esperado, Ingredientes);
        }
    }
}
