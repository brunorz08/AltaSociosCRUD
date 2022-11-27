using AltaSocios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AltaSocios.Pages
{
    public class NuevoModel : PageModel
    {
        public ListadoSocios lista = new ListadoSocios();

        public NuevoModel(ListadoSocios list)
        {
            lista = list;
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            lista.crearSocio(new Socio()
            {
                nombre = Request.Form["nombre"],
                apellido = Request.Form["apellido"],
                Documento = Convert.ToInt32(Request.Form["documento"]),
                Celular = Convert.ToInt32(Request.Form["celular"]),
                Email = Request.Form["email"]
            });
            Response.Redirect("/");
        }
    }
}
