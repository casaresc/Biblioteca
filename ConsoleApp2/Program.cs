using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de cada tipo de publicación
            Libro libro = new Libro("Cien Años de Soledad", "Gabriel García Márquez", 1967, 471);
            Revista revista = new Revista("National Geographic", "Varios", 2023, 12);
            DVD dvd = new DVD("El Señor de los Anillos: La Comunidad del Anillo", "Peter Jackson", 2001, 178);

            // Mostrar información de cada publicación
            Console.WriteLine("Información de las Publicaciones:");
            libro.MostrarInformacion();
            Console.WriteLine();
            revista.MostrarInformacion();
            Console.WriteLine();
            dvd.MostrarInformacion();
            Console.WriteLine();

            // Demostrar los métodos de la interfaz IPrestable
            libro.Prestar();
            libro.Prestar(); // Intentar prestar nuevamente
            libro.Devolver();
            libro.Devolver(); // Intentar devolver nuevamente
        }
    }
}
