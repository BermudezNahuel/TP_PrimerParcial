using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public class Profesor : User
    {
        private List<string> _cursos;
        private List<string> _materias;

        public List<string> Cursos { get => _cursos; set => _cursos = value; }
        public List<string> Materias { get => _materias; set => _materias = value; }

        public Profesor(string nombre, string apellido,int dni, string telefono) : base (nombre, apellido, dni, telefono)
        {
            _cursos = new List<string>();
            _materias = new List<string>();
        }
    }
}
