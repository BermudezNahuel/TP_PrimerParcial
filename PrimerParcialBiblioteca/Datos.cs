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
        public static ClaseMaestra Abrir()
        {
            using var sr = new StreamReader("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datos_1.json");
            string json = sr.ReadToEnd();
            var datos = JsonConvert.DeserializeObject<ClaseMaestra>(json);
            return datos;
        }

        public static void Guardar(ClaseMaestra datos)
        {
            string archivoJson = JsonConvert.SerializeObject(datos, Formatting.Indented);
            File.WriteAllText("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datos_1.json", archivoJson);
        }

        

       
    }
}
