﻿using System;
using System.Collections;
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

        public Profesor(string nombre, string apellido, int dni, string telefono) : base(nombre, apellido, dni, telefono)
        {
           
        }

        public override string MostrarInfo()
        {
            var cursos = string.Join(",", _cursos.ToArray());
            var materias = string.Join(",", _materias.ToArray());
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {base.Nombre}");
            sb.AppendLine($"Apellido: {base.Apellido}");
            sb.AppendLine($"DNI: {base.Dni}");
            sb.AppendLine($"Telefono: {base.Telefono}"); 
            sb.AppendLine($"Cursos: {cursos}"); 
            sb.AppendLine($"Enseña: {materias}");

            return sb.ToString();
        }
    }
}
