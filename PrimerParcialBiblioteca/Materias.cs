using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public class Materia
    {
        private ClaseEnum.Curso _curso;
        private List<string> _materias;
   

        public ClaseEnum.Curso Curso { get => _curso; set => _curso = value; }
        public List<string> Materias { get => _materias; set => _materias = value; }
     
        

        /// <summary>
        /// Convierte la lista de materias y las convierte en un string
        /// </summary>
        /// <returns></returns>
        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            
            var materias = string.Join(",", _materias.ToArray());

            sb.AppendLine($"Materias {_curso}: {materias}");
            
            return sb.ToString();
        }

    }

}
