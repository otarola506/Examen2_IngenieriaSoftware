using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examen2_Pizza.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost()
        {
            string Tamanio = Request.Form["Tamanio"];
            string Masa = Request.Form["Masa"];
            string Ingredientes = Request.Form["Ingredientes"];
            string Direccion = Request.Form["Direccion"];



        }
    }
}
