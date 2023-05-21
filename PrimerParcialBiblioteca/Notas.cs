using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBiblioteca
{
    public enum Año
    {
        primerAño = 1,
        segundoAño,
        terceAño,
        cuartoAño,
        quintoAño,
        sextoAño

    }
    public static class Notas
    {
        

        public static Dictionary<string, List<int>> AsignarMaterias (int anio)
        {
            var materias = Datos.Abrir().Materias;

            var materiaAnio = materias[anio].Materias;

            var dicc = new Dictionary<string, List<int>>();

            var nota_inicial = new List<int>();
            nota_inicial.Add(0);
            nota_inicial.Add(0);
            nota_inicial.Add(0);

            foreach (var materia in materiaAnio)
            {
                dicc.Add(materia, nota_inicial);
            }

            return dicc;

        }
    }
}
