using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2_Pizza.Models
{
    public class OrdenesModel
    {
        public string[] ProcesarStringIngredientes(string Ingredientes)
        {
            return Ingredientes.Split(",");

        }
    }
}
