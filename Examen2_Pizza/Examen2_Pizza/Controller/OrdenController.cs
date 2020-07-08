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

        public bool ValidarInputsVacios(string Ingredientes, string Provincia, string Canton, string Distrito, string Direccion)
        { 
            Orden = new OrdenModel();
            return Orden.ValidarInputsVacios(Ingredientes,Provincia,Canton,Distrito,Direccion);

        }

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
