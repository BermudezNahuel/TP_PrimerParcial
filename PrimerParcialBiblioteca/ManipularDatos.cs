using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public static class ManipularDatos
    {

        public static string AbrirJson(string ruta)
        {
            string jsonString = File.ReadAllText(ruta);
            return jsonString;
        }


        #region Alumno
        public static void GuardarAlumno(List<Alumno> lista, string ruta)
        {
            string archivoJson = JsonConvert.SerializeObject(lista.ToArray(), Formatting.Indented);
            File.WriteAllText(ruta, archivoJson);
        }
        public static List<Alumno> AbrirJsonAlumnos(string ruta )
        {
            string jsonString = AbrirJson(ruta);
            var stringJson = JsonConvert.DeserializeObject<List<Alumno>>(jsonString);
            return stringJson;
        }

        public static List<int> TraerDnisAlumnos(List<Alumno> listaAlumnos)
        {
            var listaDnis = new List<int>();
            
            foreach (var alumno in listaAlumnos)
            {
                listaDnis.Add(alumno.Dni);
            }

            return listaDnis;

        }
       
        #endregion Alumno


        #region Profesor
        public static void GuardarProfesores(List<Profesor> lista)
        {
            string archivoJson = JsonConvert.SerializeObject(lista.ToArray(), Formatting.Indented);
            File.WriteAllText("datosProfesores.json", archivoJson);
        }
        public static List<Profesor> ConvertirJsonProfesores(string jsonString)
        {
            var stringJson = JsonConvert.DeserializeObject<List<Profesor>>(jsonString);
            return stringJson;
        }

        #endregion Profesor

    }
}
