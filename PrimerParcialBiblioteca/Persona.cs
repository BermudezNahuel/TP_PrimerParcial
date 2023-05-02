namespace PrimerParcialBiblioteca
{
    public class Persona

    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private int _password;
        private string _telefono;
        private bool _activo = false;

        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public bool Activo { get => _activo; set => _activo = value; }

        public int Dni 
        { 
            get => _dni;
            private set 
            {
                _dni = Validar.ValidarDniOrThrow(Convert.ToInt32(value));
            } 
        }
        public Persona(string nombre, string apellido,int dni, string telefono)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = Validar.ValidarDniOrThrow(dni);
            _telefono = telefono;
            _password = dni;
        }

      


        public int Password { get => _password; set => _password = value; }
    }
}