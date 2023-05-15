using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        //_____________________________________________________________________________________________________________

        public static bool ValidarIngresoUsuario(List<Alumno> listaAlumno, int usuario, int password)
        {
            var listaAlumnos = Datos<List<Alumno>>.Abrir("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datosAlumnos.json");

            foreach (var alumno in listaAlumnos)
            {
                if (alumno.Dni == usuario && alumno.Password == password)
                {
                    alumno.Activo = true;
                    Datos<Alumno>.Guardar(listaAlumnos, "C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datosAlumnos.json");

                    return true;
                }
            }

            return false;
        }


        //public static string ValidarTipo()
        //{
        //    Type tipo = dni.GetType();
        //    return tipo;
        //}



    }
}
