using PrimerParcialBiblioteca;
using System;
using System.Text.Json;
using Newtonsoft.Json;

namespace PrimerParcial
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var materiaPrimeroList = new List<string>() { "Ciencias Naturales", "Ciencias Sociales", "Construcción Ciudadana", "Educación Artístistica", "Educación Fisica", "Matemáticas", "Prácticas de Lenguaje", "Inglés"};

            //foreach( var materia in materiaPrimeroList)
            //{
            //    Console.WriteLine(materia);
            //}

            string archivoJson = File.ReadAllText("datos_1.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(archivoJson);

            var materia1 = jsonObject["materias"]["primerAnio"];

            foreach (var materia in materia1)
            {
            Console.WriteLine(materia);

            }

            

            //Console.WriteLine("Hello, World!");
            //var alumnoUno = new Alumno("Roberto", "Gomez",123,"asdas",1);
            //Console.WriteLine(alumnoUno.Dni);
            //alumnoUno.CargarNotasAlumno("Matematica", 7);
            //alumnoUno.CargarNotasAlumno("Practicas del Lenguaje", 7);
            //alumnoUno.CargarNotasAlumno("Geografia", 7);
            //Console.WriteLine(alumnoUno.MostrarNotaMaterias());

            //Archivo_01.Archivo(alumnoUno.MostrarNotaMaterias());
        }
    }
}