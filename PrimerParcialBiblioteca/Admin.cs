using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public class Administrador
    {
        private int _dni;
        private int _password;

        public int Dni { get => _dni; set => _dni = value; }
        public int Password { get => _dni; set => _password = value; }

        public Administrador(int usuario, int password) 
        {
            _dni = usuario;
            _password = password;

        }
    }
}
