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


            //AdministrarUsuario.AgregarUsuario("Martin", "Juarez", 45123412, "34124312", 4);

            //try
            //{

            //    int nue = 5 / x;
            //    Console.WriteLine("No entro al catch");

            //}
            //catch (LoginFallido ex)
            //{

            //    //Codigo que sucede cuando sucede la excepcion
            //    Console.WriteLine("Entro al catch");

            //}

            var list = Datos.Abrir().Profesores;

            foreach (var prof in list)
            {
                Console.WriteLine(prof.MostrarInfo());
                foreach (var item in prof.MateriasDictadas) 
                {
                    Console.WriteLine( item.MostrarInfo());
                }
            }

            var cursos = ClaseEnum.Curso.PrimerAño;
            

            string archivoJson = JsonConvert.SerializeObject(cursos, Formatting.Indented);
            File.WriteAllText("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\enum_01.json", archivoJson);

            var prfo1 = list[1];

            foreach (var item in prfo1.MateriasDictadas)
            {
                //cbo_anio.Items.Add((int)item.Curso);
                foreach (var materia in item.Materias)
                {
                    //cbo_materia.Items.Add(item.ToString());
                    Console.WriteLine(materia);
                }
            }


        }

        
    }

}