namespace PrimerParcialBiblioteca
{
    public class Persona

    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private int _contraseña;
        private string _telefono;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni 
        { 
            get => _dni;
            private set 
            {
                _dni = Validar.ValidarDniOrThrow(value);
            } 
        }
        public Persona(string nombre, string apellido,int dni, string telefono)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = Validar.ValidarDniOrThrow(dni);
            _telefono = telefono;
        }

      


        public int Contraseña { get => _contraseña; set => _contraseña = value; }
    }
}