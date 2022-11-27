namespace AltaSocios.Models
{
    public interface IMetodos
    {

        public Socio obtenerSocio(int codigo);


        public List<Socio> obtenerSocios();

        public void crearSocio(Socio socio);


        public void borrarSocio(int codigo);
    }
}
