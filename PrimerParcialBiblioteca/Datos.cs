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
        public static ClaseMaestra Abrir(string path)
        {
            using var sr = new StreamReader(path);
            string json = sr.ReadToEnd();
            var datos = JsonConvert.DeserializeObject<ClaseMaestra>(json);
            return datos;
        }

        public static void Guardar(ClaseMaestra datos, string ruta)
        {
            string archivoJson = JsonConvert.SerializeObject(datos, Formatting.Indented);
            File.WriteAllText(ruta, archivoJson);
        }

        

       
    }
}
