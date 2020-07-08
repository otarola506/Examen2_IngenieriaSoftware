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
            string Provincia = Request.Form["Provincia"];
            string Canton = Request.Form["Canton"];
            string Distrito = Request.Form["Distrito"];
            string DireccionEspecifica = Request.Form["Direccion"];
            if (Order.ValidarInputsVacios(Ingredientes,Provincia,Canton,Distrito,DireccionEspecifica))
            {
                HttpContext.Session.SetString("TamanioPizza", Tamanio);
                HttpContext.Session.SetString("MasaPizza", Masa);
                HttpContext.Session.SetString("IngredientesPizza", Ingredientes);
                HttpContext.Session.SetString("ProvinciaPizza", Provincia);
                HttpContext.Session.SetString("CantonPizza", Canton);
                HttpContext.Session.SetString("DistritoPizza", Distrito);
                HttpContext.Session.SetString("DireccionPizza", DireccionEspecifica);
                return RedirectToPage("/Desglose/DesgloseOrden");
            }
            else {
                Mensaje = "Por favor llene todos los campos";
                return Page();
            }
            

          


        }
    }
}
