using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace PrimerParcialBiblioteca
{
    public class Alumno : Persona
    {
        private int _legajo;
        private Dictionary<string, int> _dicMaterias = new Dictionary<string, int>();
        public int Legajo 
        {   
            get => _legajo; 
            set => _legajo = value; 
        }

        public Alumno(string nombre, string apellido, int dni, string telefono, int legajo) : base(nombre,apellido,dni,telefono)
        { 
            _legajo = legajo;
        }

        public void CargarNotasAlumno (string materia, int nota)
        {
            //_dicMaterias = new Dictionary<string, int> ();
            _dicMaterias.Add(materia, nota);
        }

        public string MostrarNotaMaterias()
        {
            StringBuilder sb = new StringBuilder ();
            //string mensaje = "";
                foreach (KeyValuePair<string, int> entry in _dicMaterias)
                {
                    sb.AppendLine ($"Materia: {entry.Key} | Nota: {entry.Value}" );
                    
                    
                }
            return sb.ToString();
        }
    }

    








    

}
