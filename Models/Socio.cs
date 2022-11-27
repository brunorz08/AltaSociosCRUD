namespace AltaSocios.Models
{
    public class Socio
    {
        public string? nombre;
        public string? apellido;
        public int codigo;
        private int celular;
        private int documento;
        private string? email;


        public int Documento { get => documento; set => documento = value; }
        public int Celular { get => celular; set => celular = value; }
        public string? Email { get => email; set => email = value; }
    }
}
