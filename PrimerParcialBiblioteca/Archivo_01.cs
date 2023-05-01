using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public static class Archivo_01
    {
       public static void Archivo(string datos)
        {
            var sb = new StringBuilder();
            sb.AppendLine(datos);
            sb.AppendLine("asdasd");

            File.WriteAllText("./mi_archivo.txt", sb.ToString());

        }

        public static void LeerMaterias() 
        {
           var materiasPrimero = new List<string>();

            

        }


    }
}
