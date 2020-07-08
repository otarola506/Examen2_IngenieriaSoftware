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
        public void CalculoImpuestoCorrectoPrecioGrande()
        {
            OrdenModel Order = new OrdenModel();
            double Impuesto = Order.CalculoImpuesto(16500);
            Assert.AreEqual(2145, Impuesto);
        }

        [TestMethod]
        public void CalculoImpuestoPrecioPequeno()
        {
            OrdenModel Order = new OrdenModel();
            double Impuesto = Order.CalculoImpuesto(4200);
            Assert.AreEqual(546, Impuesto);
        }

        [TestMethod]
        public void CalculoPrecioTotalOrdenPequena()
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
        public void ValidarInputsQuePuedenEstarVaciosCorrecta()
        {
            OrdenModel Order = new OrdenModel();
            bool resultado = Order.ValidarInputsVacios("Jam�n,Hongos","San Jos�","Escaz�","San Rafael","150 mts de la bomba delta, casa porton verde");

            Assert.IsTrue(resultado, "La prueba validando que los inputs que puede estar vac�os no lo est�n no pas�.");
            

        }

        [TestMethod]
        public void ValidarInputsQuePuedenEstarVaciosTodosVacios()
        {
            OrdenModel Order = new OrdenModel();
            bool resultado = Order.ValidarInputsVacios(null, "", "", "", "");

            Assert.IsFalse(resultado, "La prueba validando que los inputs que puede estar vac�os si lo est�n no pas�.");


        }

        [TestMethod]
        public void ValidarInputsIngredientesVacios()
        {
            OrdenModel Order = new OrdenModel();
            bool resultado = Order.ValidarInputsVacios(null, "San Jos�", "Escaz�", "San Rafael", "150 mts de la bomba delta, casa porton verde");

            Assert.IsFalse(resultado, "La prueba validando que los ingredientes est�n vac�os no pas�.");


        }

        [TestMethod]
        public void ValidarInputDireccionVacio()
        {
            OrdenModel Order = new OrdenModel();
            bool resultado = Order.ValidarInputsVacios("Jam�n,Hongos", "San Jos�", "Escaz�", "San Rafael", "");

            Assert.IsFalse(resultado, "La prueba validando que la direccion este vac�o no pas�.");

        }

        [TestMethod]
        public void ValidarInputProvinciaVacio()
        {
            OrdenModel Order = new OrdenModel();
            bool resultado = Order.ValidarInputsVacios("Jam�n,Hongos", "", "Escaz�", "San Rafael", "");

            Assert.IsFalse(resultado, "La prueba validando que la provincia este vac�o no pas�.");

        }


    }
}
