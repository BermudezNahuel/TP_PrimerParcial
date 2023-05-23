using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace PrimerParcialBiblioteca
{
    public static class Datos
    {   

        /// <summary>
        /// Se encarga de abrir un archivo json y deserializar la info dentro del json
        /// </summary>
        /// <returns>Devuelve un objeto de la ClaseMaestra</returns>
        public static ClaseMaestra Abrir()
        {
            using var sr = new StreamReader("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datos_1.json");
            string json = sr.ReadToEnd();
            var datos = JsonConvert.DeserializeObject<ClaseMaestra>(json);
            return datos;
        }


        /// <summary>
        /// Toma un objeto del tipo ClaseMaestra, lo seraliza y lo guarda en la direccion indicada
        /// </summary>
        /// <param name="datos"></param>
        public static void Guardar(ClaseMaestra datos)
        {
            string archivoJson = JsonConvert.SerializeObject(datos, Formatting.Indented);
            File.WriteAllText("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datos_1.json", archivoJson);
        }


        /// <summary>
        /// Toma los datos de un alumno y los actualiza y los guarda en el archivo Json
        /// </summary>
        /// <param name="alumno"></param>
        public static void ActualizarDatosAlumno(Alumno alumno)
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
