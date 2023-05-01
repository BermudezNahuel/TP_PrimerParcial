using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public class Materias
    {
        public List<string> primerAño;
        public List<string> segundoAño;

        public Materias(string archivo)
        {
            primerAño = new List<string>();
            segundoAño = new List<string>();
        }


        //public Dictionary<string, int> segundoAño;
        //public Dictionary<string, int> tercerAño;
        //public Dictionary<string, int> cuartoAño;
        //public Dictionary<string, int> quintoAño;
        //public Dictionary<string, int> sextoAño;


    }
}
