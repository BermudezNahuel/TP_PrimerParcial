namespace PrimerParcialBiblioteca
{
    public class Persona

    {
        private string _nombre;
        private string _apellido;
        private string _dni;
        private string _contraseña;

        public Persona(string nombre, string apellido, string dni)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _contraseña = dni;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Dni { get => _dni; set => _dni = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
    }
}