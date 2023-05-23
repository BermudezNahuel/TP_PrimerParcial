using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public static class AdministrarUsuario
    {
        
        /// <summary>
        /// Crea un nuevo alumno, con los parametros introducidos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="telefono"></param>
        /// <param name="anio"></param>
        public static void AgregarUsuario(string path,string nombre, string apellido, int dni, string telefono, int anio)
        {
            var datos = Datos.Abrir();

            var listaAlumnos = datos.Alumnos;

            int lenghtLista = listaAlumnos.Last().Legajo;

            var alumno = new Alumno(nombre, apellido, dni, telefono, anio, lenghtLista, Notas.AsignarMaterias((anio-1)));

            listaAlumnos.Add(alumno);

            Datos.Guardar(datos);
        }


        /// <summary>
        /// Buscar al usuario en la lista y lo elimina de la misma, 
        /// y actuliza la info del archivo json
        /// </summary>
        /// <param name="alumno">Se le debe para el usuario a eliminar</param>
        public static void EliminarUsuario(Alumno usuario)
        {
            var datos = Datos.Abrir();

            var listaAlumnos = datos.Alumnos;

            foreach (var item in listaAlumnos)
            {
                if(item.Dni == usuario.Dni)
                {
                    int indice = listaAlumnos.IndexOf(item);
                    listaAlumnos.RemoveAt(indice);
                    break;
                }
            }

            Datos.Guardar(datos);
        }


        /// <summary>
        /// Buscar al usuario en la lista y lo elimina de la misma, 
        /// y actuliza la info del archivo json
        /// </summary>
        /// <param name="usuario">Se le debe para el usuario a eliminar</param>
        public static void EliminarUsuario(Profesor usuario)
        {
            var datos = Datos.Abrir();

            var listaProfesores = datos.Profesores;

            foreach (var item in listaProfesores)
            {
                if (item.Dni == usuario.Dni)
                {
                    int indice = listaProfesores.IndexOf(item);
                    listaProfesores.RemoveAt(indice);
                    break;
                }
            }

            Datos.Guardar(datos);
        }



        /// <summary>
        /// Recorre la informacion de un alumno y la reemplaza por una nueva. 
        /// Abre el archivo Json y guarda esta nueva informacion del alumno, 
        /// pero actualizada.
        /// </summary>
        /// <param name="alumno">Alumno sus datos que se va a actualizar</param>
        public static void ActualizarDatosUsuario(Alumno alumno)
        {
            var datos = Datos.Abrir();
            var listaAlumnos = datos.Alumnos;

            foreach (var item in listaAlumnos)
            {
                if (item.Dni == alumno.Dni)
                {
                    item.Notas = alumno.Notas;
                    item.Nombre = alumno.Nombre;
                    item.Apellido = alumno.Apellido;
                    item.Telefono = alumno.Telefono;
                    item.Anio = alumno.Anio;
                }
            }

            Datos.Guardar(datos);

        }

    }
}
