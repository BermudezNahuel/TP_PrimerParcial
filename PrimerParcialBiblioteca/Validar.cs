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

        static public int ValidarDniOrThrow(int dni, List<int> listaDni)
        {
            foreach (int i in listaDni) 
            {
                if (dni == i)
                {
                    throw new ArgumentException("El numero de DNI ya fue ingresado");
                }
            }
            return dni;
        }

        static public bool ValidarUsuario(int dni, int password)
        {
            if (dni == password)
            {
                return true;

            }
            return false;
        }




    }
}
