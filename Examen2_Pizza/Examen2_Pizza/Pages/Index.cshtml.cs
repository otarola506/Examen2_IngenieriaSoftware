using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Examen2_Pizza.Controller;

namespace Examen2_Pizza.Pages
{
    public class IndexModel : PageModel
    {
        public OrdenController Order;
        public string Mensaje;
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            Order = new OrdenController();
            string Tamanio = Request.Form["Tamanio"];
            string Masa = Request.Form["Masa"];
            string Ingredientes = Request.Form["Ingredientes"];
            string Direccion = Request.Form["Direccion"];
            if (Order.ValidarDireccionIngredientes(Direccion, Ingredientes))
            {
                HttpContext.Session.SetString("TamanioPizza", Tamanio);
                HttpContext.Session.SetString("MasaPizza", Masa);
                HttpContext.Session.SetString("IngredientesPizza", Ingredientes);
                HttpContext.Session.SetString("DireccionPizza", Direccion);
                return RedirectToPage("/Desglose/DesgloseOrden");
            }
            else {
                Mensaje = "Por favor llene todos los campos";
                return Page();
            }
            

          


        }
    }
}
