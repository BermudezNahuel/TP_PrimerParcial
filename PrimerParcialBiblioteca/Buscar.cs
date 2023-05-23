using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public static class Buscar
    {
        /// <summary>
        /// Busca en una lista de alumnos y retorna todos sus numeros de 
        /// documentos en una lista
        /// </summary>
        /// <param name="listaAlumnos"></param>
        /// <returns>Retorna una lista de int</returns>
        public static List<int> ListarDni(List<Alumno> listaAlumnos)
        {
            var listaDnis = new List<int>();

            foreach (var alumno in listaAlumnos)
            {
                listaDnis.Add(alumno.Dni);
            }

            return listaDnis;

        }

        /// <summary>
        /// Busca en la lista de alumnos y los agrupa por curso.
        /// </summary>
        /// <param name="curso">Curso</param>
        /// <returns>Retorna una lista de Alumnos que pertenecen al mismo curso</returns>
        public static List<Alumno> ListarAlumnoPorCurso(int curso)
        {
            var lista = new List<Alumno>();
            var listaAlumnos = Datos.Abrir().Alumnos;
            curso++;

            foreach (var alumno in listaAlumnos)
            {
                if(alumno.Anio == curso)
                {
                    lista.Add(alumno);
                }
            }

            return lista;
        }

        
    }
}
