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


            //AdministrarUsuario.AgregarUsuario("Maria", "Gutierrez", 12445663, "42226783", 4);
            //AdministrarUsuario.AgregarUsuario("Laura", "Gonzalez", 12490873, "42225423", 4);
            //AdministrarUsuario.AgregarUsuario("Yesica", "Cortazar", 1243118941, "42226761", 4);

            //var lista = Buscar.ListarAlumnoPorCurso(1);

            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item.MostrarInfo());
            //}

            var lista = Datos.Abrir().Alumnos;

            foreach (var item in lista)
            {
                Console.WriteLine(item.MostrarInfo());
            }




        }

        
    }

}