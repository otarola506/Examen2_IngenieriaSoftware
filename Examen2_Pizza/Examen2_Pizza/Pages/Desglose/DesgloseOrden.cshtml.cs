using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Examen2_Pizza.Controller;

namespace Examen2_Pizza.Pages.Desglose
{
    public class DesgloseOrdenModel : PageModel
    {
        const string SessionKeyTamanio = "TamanioPizza";
        const string SessionKeyMasa = "MasaPizza";
        const string SessionKeyIngredientes = "IngredientesPizza";
        const string SessionKeyProvincia = "ProvinciaPizza";
        const string SessionKeyCanton = "CantonPizza";
        const string SessionKeyDistrito = "DistritoPizza";
        const string SessionKeyDireccion = "DireccionPizza";

        public string Tamanio;
        public string Masa;
        public string[] Ingredientes;
        public string Provincia;
        public string Canton;
        public string Distrito;
        public string Direccion;
        public double PrecioSinImpuesto;
        public double Impuesto;
        public double PrecioFinal;
        public OrdenController Orden;

        public void OnGet()
        {
            Orden = new OrdenController();
            Tamanio = HttpContext.Session.GetString(SessionKeyTamanio);
            Masa = HttpContext.Session.GetString(SessionKeyMasa);
            Provincia = HttpContext.Session.GetString(SessionKeyProvincia);
            Canton = HttpContext.Session.GetString(SessionKeyCanton);
            Distrito = HttpContext.Session.GetString(SessionKeyDistrito);
            Direccion = HttpContext.Session.GetString(SessionKeyDireccion);
            string IngredientesString = HttpContext.Session.GetString(SessionKeyIngredientes);
            Ingredientes = Orden.ProcesarIngredientes(IngredientesString);
            // Tripleta con el precio sin impuesto, el impuesto y el precio total.
            var TripletaPrecio = Orden.CalculoPrecioTotalOrden(Ingredientes.Length, Tamanio);
            PrecioSinImpuesto = TripletaPrecio.Item1;
            Impuesto = TripletaPrecio.Item2;
            PrecioFinal = TripletaPrecio.Item3;
           
           

        }
        
    }
}