using AltaSocios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AltaSocios.Pages
{
    public class BorrarModel : PageModel
    {
        public ListadoSocios lista = new ListadoSocios();
        

        public BorrarModel(ListadoSocios list)
        {
            lista = list;
        }
        public void OnGet()
        {
            lista.borrarSocio(Convert.ToInt32(Request.Query["codigo"]));
            Response.Redirect("/");


        }
    }
}
