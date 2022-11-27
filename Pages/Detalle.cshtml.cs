using AltaSocios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AltaSocios.Pages
{
    public class DetalleModel : PageModel
    {

        public ListadoSocios lista = new ListadoSocios();
        public Socio? actual = new Socio();

        public DetalleModel(ListadoSocios list)
        {
            lista = list;
        }
        public void OnGet()
        {
            actual = lista.obtenerSocio(Convert.ToInt32(Request.Query["codigo"]));

        }
    }
}
