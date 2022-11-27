using AltaSocios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AltaSocios.Pages
{
    public class IndexModel : PageModel
    {

        public ListadoSocios lista = new ListadoSocios();

        public IndexModel(ListadoSocios list)
        {
            lista = list;
        }

        public void OnGet()
        {
        }
    }
}
