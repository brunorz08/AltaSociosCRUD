using AltaSocios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AltaSocios.Pages
{
    public class EditarModel : PageModel
    {
        public Socio? socio = new Socio();
        public ListadoSocios listado = new ListadoSocios();

        public EditarModel(ListadoSocios list)
        {
            listado = list;
        }
        public void OnGet()
        {
            socio = listado.obtenerSocio(Convert.ToInt32(Request.Query["codigo"]));

        }

        public void OnPost()
        {

            listado.editarSocio(new Socio()
            {
                nombre = Request.Form["nombre"],
                apellido = Request.Form["apellido"],
                Documento = Convert.ToInt32(Request.Form["documento"]),
                Celular = Convert.ToInt32(Request.Form["celular"]),
                Email = Request.Form["email"],
            });


            Response.Redirect("/");
        }


    }
}
