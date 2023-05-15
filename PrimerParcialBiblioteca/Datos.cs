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
    public static class Datos<T>
    {
        public static T Abrir(string path)
        {
            using var sr = new StreamReader(path);
            string json = sr.ReadToEnd();
            var lista = JsonConvert.DeserializeObject<T>(json);
            return lista;
        }

        public static void Guardar(List<T> lista, string ruta)
        {
            string archivoJson = JsonConvert.SerializeObject(lista.ToArray(), Formatting.Indented);
            File.WriteAllText(ruta, archivoJson);
        }

        

       
    }
}
