namespace AltaSocios.Models
{
    public class ListadoSocios : IMetodos
    {

        public List<Socio> ListaSocios = new List<Socio>();


       
        public Socio obtenerSocio(int codigo)
        {
            return ListaSocios[codigo];
        }

        public List<Socio> obtenerSocios()
        {
            return ListaSocios;
        }

        public void crearSocio(Socio socio)
        {
            ListaSocios.Add(socio);
            socio.codigo = ListaSocios.IndexOf(socio);

        }

        public void borrarSocio(int codigo)
        {

            Socio socioaborrar = ListaSocios[codigo];
            ListaSocios.Remove(socioaborrar);
            Refresh();
        }



        public void editarSocio(Socio socio)
        {
            ListaSocios[socio.codigo].nombre = socio.nombre;
            ListaSocios[socio.codigo].apellido = socio.apellido;
            ListaSocios[socio.codigo].Documento = socio.Documento;
            ListaSocios[socio.codigo].Celular = socio.Celular;
            ListaSocios[socio.codigo].Email = socio.Email;


        }

        public void Refresh()
        {
            foreach (var item in ListaSocios)
            {
                item.codigo = ListaSocios.IndexOf(item);
            }
        }
    }

}