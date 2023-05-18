using PrimerParcialBiblioteca;
using System;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Text.Json.Nodes;
using System.Collections.Generic;

namespace PrimerParcial
{
    public class Program
    {
        static void Main(string[] args)
        {


            //foreach (var dni in listaAlumnos)
            //{
            //    Type t = dni.GetType();
            //    Console.WriteLine(t);
            //    Console.WriteLine(dni);
            //}


            //var datos = Datos.Abrir("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datos_1.json");

            ////Instancio un nuevo alumno

            //Alumno alumnoCuatro = new Alumno("Carlos", "Martinez", 43123412, "34124312", 4, 3, Notas.AsignarMaterias(3));

            ////alumnoCuatro.notas(Notas.AsignarMaterias(3));

            //var alumnos = datos.Alumnos;

            //datos.AgregarUsuario(alumnoCuatro);


            AdministrarUsuario.AgregarUsuario("Carlos", "Martinez", 43123412, "34124312", 4);

            //foreach (var alumno in alumnos)
            //{
            //    //alumno.notas(Notas.AsignarMaterias(alumno.Anio));
            //    Console.WriteLine(alumno.MostrarInfo());
            //}


            //Datos.Guardar(datos, "C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datos_1.json");
















        }

        
    }

}