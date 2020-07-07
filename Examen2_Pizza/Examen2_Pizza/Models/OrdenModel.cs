﻿using System;
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
            double PrecioBasePizzaPequena = 2100;
            double PrecioBasePizzaMediana = 3100;
            double PrecioBasePizzaGrande = 5100;
            double PrecioBaseIngrediente = 650;
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

        public double CalculoImpuesto(double PrecioSinImpuesto)
        {
            // Se calcula precio con un impuesto del 13%.
            return (PrecioSinImpuesto * 13) / 100; 
        }

        public double PrecioFinal(double PrecioSinImpuesto)
        {
            //Envío de 700 colones.
            return PrecioSinImpuesto + CalculoImpuesto(PrecioSinImpuesto) + 700;
        }

        public double CalculoPrecioFinal(string Ingredientes, string Tamanio)
        {
            string[] ListaIngredientes = ProcesarStringIngredientes(Ingredientes); 
            double PrecioSinImpuesto = CalculoPrecioSinImpuesto(ListaIngredientes.Length, Tamanio);
            return PrecioFinal(PrecioSinImpuesto);
        }


    }
}
