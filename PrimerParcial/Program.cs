using PrimerParcialBiblioteca;

namespace PrimerParcial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var alumnoUno = new Alumno("nahuel", "Bermudez",123,"asdas",1);
            Console.WriteLine(alumnoUno.Dni);
            alumnoUno.CargarNotasAlumno("Matematica", 7);
            alumnoUno.CargarNotasAlumno("Practicas del Lenguaje", 7);
            alumnoUno.CargarNotasAlumno("Geografia", 7);
            Console.WriteLine(alumnoUno.MostrarNotaMaterias());

        }
    }
}