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
        
        public static void AgregarUsuario(string nombre, string apellido, int dni, string telefono, int anio)
        {
            var datos = Datos.Abrir();

            var listaAlumnos = datos.Alumnos;

            var listaMaterias = datos.Materias;

            var listaDnis = Buscar.ListarDni(listaAlumnos);

            int lenghtLista = listaAlumnos[listaAlumnos.Count - 1].Legajo;

            var alumno = new Alumno(nombre, apellido, dni, telefono, anio, lenghtLista, Notas.AsignarMaterias((anio-1)));
            
            Validar.ValidarDniOrThrow(alumno.Dni, listaDnis);

            listaAlumnos.Add(alumno);

            Datos.Guardar(datos);
        }
    }
}
