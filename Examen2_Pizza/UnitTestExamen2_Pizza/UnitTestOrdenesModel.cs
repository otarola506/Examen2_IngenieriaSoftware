using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen2_Pizza.Models;
using System;

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
        public void CalculoPrecioSinImpuestoCorrectoPequena()
        {
            OrdenModel Order = new OrdenModel();
            double precio =Order.CalculoPrecioSinImpuesto(4, "Peque�a");
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
        public void CalculoPrecioSinImpuestoCorrectoError()
        {
            OrdenModel Order = new OrdenModel();
            double precio = Order.CalculoPrecioSinImpuesto(5, "Personal");
            Assert.AreEqual(0, precio);

        }

        [TestMethod]
        public void CalculoImpuestoCorrecto()
        {
            OrdenModel Order = new OrdenModel();
            double Impuesto = Order.CalculoImpuesto(8500);
            Assert.AreEqual(1105, Impuesto);
        }

       

        [TestMethod]
        public void CalculoPrecioTotalOrden()
        {
            OrdenModel Order = new OrdenModel();
            var TripletaPrecio = Order.CalculoPrecioTotalOrden(7,"Peque�a");
            double PrecioSinImpuesto = TripletaPrecio.Item1;
            double Impuesto = TripletaPrecio.Item2;
            double PrecioFinal = TripletaPrecio.Item3;

            Assert.AreEqual(6650, Math.Round(PrecioSinImpuesto, 2));
            Assert.AreEqual(864.5, Math.Round(Impuesto, 2));
            Assert.AreEqual(8214.5, Math.Round(PrecioFinal, 2));


        }

        [TestMethod]
        public void ValidarDireccionIngredienteCorrecta()
        {
            OrdenModel Order = new OrdenModel();
            bool resultado = Order.ValidarDireccionIngredientes("150 mts de la Escuela de la ni�a pochita","Jam�n,Hongos");

            Assert.IsTrue(resultado, "La prueba validando que la direcci�n y los ingredientes ingresados correctamente no sean vacios no pas�.");
            


        }

        [TestMethod]
        public void ValidarDireccionIncorrectaIngredientesCorrectos()
        {
            OrdenModel Order = new OrdenModel();
            bool resultado = Order.ValidarDireccionIngredientes("", "Jam�n,Hongos");

            Assert.IsFalse(resultado, "La prueba validando que la direcci�n ingresada incorrectamente y los ingredientes ingresados correctamente no pas�");



        }

        [TestMethod]
        public void ValidarDireccionCorrectaIngredientesIncorrectos()
        {
            OrdenModel Order = new OrdenModel();
            string Ingredientes = null;
            bool resultado = Order.ValidarDireccionIngredientes("150 mts de la Escuela de la ni�a pochita", Ingredientes);

            Assert.IsFalse(resultado, "La prueba validando que la direcci�n ingresada correctamente y los ingredientes ingresados incorrectamente no pas�");



        }

        [TestMethod]
        public void ValidarDireccionIncorrectosIngredientesIncorrectos()
        {
            OrdenModel Order = new OrdenModel();
            string Ingredientes = null;
            bool resultado = Order.ValidarDireccionIngredientes("", Ingredientes);

            Assert.IsFalse(resultado, "La prueba validando que la direcci�n ingresada incorrectamente y los ingredientes ingresados incorrectamente no pas�");



        }


    }
}
