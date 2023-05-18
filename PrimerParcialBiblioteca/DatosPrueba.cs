using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace PrimerParcialBiblioteca
{
    public class DatosPrueba<T>
    {
        string _path;

        public DatosPrueba(string path)
        {
            _path = path;
        }


        public List<T> ObtenerDatos() 
        {
            using var sr = new StreamReader(_path);
            string json = sr.ReadToEnd();
            var lista = JsonSerializer.Deserialize<List<T>>(json);
            return lista;
        }

    }
}
