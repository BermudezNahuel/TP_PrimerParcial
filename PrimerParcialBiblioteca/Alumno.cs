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
        public static int _anio;
        //private Dictionary<string, int> _dicMaterias = new Dictionary<string, int>();

        public int Legajo { get => _legajo; set => _legajo = value;}

        public int Anio { get => _anio; set => _anio = value;}

        public Alumno(string nombre, string apellido, int dni, string telefono, int anio, int lengthLista) : base(nombre,apellido,dni,telefono)
        { 
            _anio = anio;
            _legajo = lengthLista + 1;
        }  
       

        //public void CargarNotasAlumno (string materia, int nota)
        //{
        //    //_dicMaterias = new Dictionary<string, int> ();
        //    _dicMaterias.Add(materia, nota);
        //}

        //public string MostrarNotaMaterias()
        //{
        //    StringBuilder sb = new StringBuilder ();
        //    //string mensaje = "";
        //        foreach (KeyValuePair<string, int> entry in _dicMaterias)
        //        {
        //            sb.AppendLine ($"Materia: {entry.Key} | Nota: {entry.Value}" );
                    
                    
        //        }
        //    return sb.ToString();
        //}

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder ();
            sb.AppendLine($"Nombre: {base.Nombre}");
            sb.AppendLine($"Apellido: {base.Apellido}");
            sb.AppendLine($"DNI: {base.Dni}");
            sb.AppendLine($"Telefono: {base.Telefono}");
            sb.AppendLine($"Legajo: {_legajo}");
            sb.AppendLine($"Año: {_anio}");
            sb.AppendLine($"Activo: {base.Activo}");
            return sb.ToString();
        }
    }

    








    

}
