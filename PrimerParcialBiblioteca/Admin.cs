using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public class Administrador
    {
        private string usuario;
        private int password;
        public Administrador(string usuario, int password) 
        {
            this.usuario = usuario;
            this.password = password;

        }
    }
}
