using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public static class Buscar
    {
        public static List<int> ListarDni(List<Alumno> listaAlumnos)
        {
            var listaDnis = new List<int>();

            foreach (var alumno in listaAlumnos)
            {
                listaDnis.Add(alumno.Dni);
            }

            return listaDnis;

        }
    }
}
