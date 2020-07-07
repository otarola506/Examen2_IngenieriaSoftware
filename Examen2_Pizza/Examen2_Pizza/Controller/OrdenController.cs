using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen2_Pizza.Models;

namespace Examen2_Pizza.Controller
{
    public class OrdenController
    {
        public OrdenModel Orden;

        public string[] ProcesarIngredientes(string Ingredientes)
        {
            Orden = new OrdenModel();
            return Orden.ProcesarStringIngredientes(Ingredientes);

        }

        public (double,double,double) CalculoPrecioTotalOrden(int CantidadIngredientes,string Tamanio)
        {
            Orden = new OrdenModel();
            return Orden.CalculoPrecioTotalOrden(CantidadIngredientes, Tamanio);

        }
    }
}
