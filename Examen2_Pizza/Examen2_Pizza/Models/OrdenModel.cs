using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2_Pizza.Models
{
    public class OrdenModel
    {
        public string[] ProcesarStringIngredientes(string Ingredientes)
        {
            return Ingredientes.Split(",");

        }

        public double CalculoPrecioSinImpuesto(int CantidadIngredientes, string Tamanio)
        {
            double PrecioBasePizzaPequena = 3500;
            double PrecioBasePizzaMediana = 4500;
            double PrecioBasePizzaGrande = 6500;
            double PrecioBaseIngrediente = 850;
            double PrecioTotal = 0;
            switch (Tamanio)
            {
                case "Pequeña":
                    PrecioTotal = PrecioBasePizzaPequena + PrecioBaseIngrediente * CantidadIngredientes;
                    break;
                case "Mediana":
                    PrecioTotal = PrecioBasePizzaMediana + PrecioBaseIngrediente * CantidadIngredientes;
                    break;
                case "Grande":
                    PrecioTotal = PrecioBasePizzaGrande + PrecioBaseIngrediente * CantidadIngredientes;
                    break;
                default:
                    PrecioTotal = 0;
                    break;
            }
            return PrecioTotal;

        }
    }
}
