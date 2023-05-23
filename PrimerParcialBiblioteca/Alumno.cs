using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace PrimerParcialBiblioteca
{
    public class Alumno : User
    {
        private int _legajo;
        private int _anio;
        private Dictionary<string, List<int>> _notas;

        public int Legajo { get => _legajo; set => _legajo = value;}

        public int Anio { get => _anio; set => _anio = value;}

        public Dictionary<string, List<int>> Notas
        {
            get => _notas; set => _notas = value;
        }

  
        public Alumno(string nombre, string apellido, int dni, string telefono, int anio, int lengthLista, Dictionary<string, List<int>> dicc) : base(nombre,apellido,dni,telefono)
        { 
            _anio = anio;
            _legajo = lengthLista + 1;
            _notas = dicc;
            
        }  
       

        /// <summary>
        /// Toma los atributos del alumno y los devuelve en formato string
        /// </summary>
        /// <returns>Retorna un string</returns>
        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder ();
            sb.AppendLine($"Nombre: {base.Nombre}");
            sb.AppendLine($"Apellido: {base.Apellido}");
            sb.AppendLine($"DNI: {base.Dni}");
            sb.AppendLine($"Telefono: {base.Telefono}");
            sb.AppendLine($"Legajo: {_legajo}");
            sb.AppendLine($"Año: {_anio}");
            sb.AppendLine($"Activo: {base.Activo}");
            sb.AppendLine("#### NOTAS ####");

            foreach (var (key, value) in _notas)
            {

                sb.AppendLine($"{key.PadRight(22)}\t : {value[0]}\t {value[1]}\t {value[2]}\t");
            }

            return sb.ToString();
        }
    }

    








    

}
