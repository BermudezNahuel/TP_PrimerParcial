using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public static class CrearUsuario
    {
        
        public static void CrearAlumno(string nombre, string apellido, int dni, string telefono, int anio)
        {
            var listaAlumnos = Datos<List<Alumno>>.Abrir("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datosAlumnos.json");

            var listaDnis = Buscar<Alumno>.ListarDni(listaAlumnos);

            int lenghtLista = listaAlumnos[listaAlumnos.Count - 1].Legajo;

            var alumno = new Alumno(nombre, apellido, dni, telefono, anio, lenghtLista);
            Validar.ValidarDniOrThrow(alumno.Dni, listaDnis);

            listaAlumnos.Add(alumno);

            Datos<Alumno>.Guardar(listaAlumnos, "C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datosAlumnos.json");
        }
    }
}
