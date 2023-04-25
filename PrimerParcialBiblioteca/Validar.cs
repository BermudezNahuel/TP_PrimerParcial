using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public class Validar
    {
        static public int ValidarDniOrThrow(int dni)
        {
            if (dni < 0)
            {
                throw new ArgumentException("El numero de DNI no es valido");
            }
            return dni;
        }
    }
}
