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


            using var sr = new StreamReader("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datos_1.json");
            string json = sr.ReadToEnd();

            ////convierto un string en un JsonNode
            //JsonNode nodoAlumnos = JsonNode.Parse(json)!;
            ////Obtengo el nodo que busco
            //JsonNode datosDisponibles = nodoAlumnos!["alumnos"]!;

            ////Instancio un nuevo alumno
            //Alumno alumnoCuatro = new Alumno("carlor", "martinez", 43123412, "34124312", 4, 3);
            ////Lo serializo
            //JsonNode alumnoJson = JsonConvert.SerializeObject(alumnoCuatro, Formatting.Indented);


            //Console.WriteLine(alumnoJson);
            //JsonNode alumnoCuatroJsonNode = alumnoJson;


            var datosDeserializado = JsonConvert.DeserializeObject<ClaseMaestra>(json);

            var alumnos = datosDeserializado.Alumnos;
            
            foreach (var alumno in alumnos)
            {
                Console.WriteLine(alumno.MostrarInfo());
            }

           


        }

        
    }

}