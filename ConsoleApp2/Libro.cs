using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Clase derivada Libro
    public class Libro : Publicacion, IPrestable
    {
        public int NumeroPaginas { get; set; }
        private bool estaPrestado;

        public Libro(string titulo, string autor, int añoPublicacion, int numeroPaginas)
            : base(titulo, autor, añoPublicacion)
        {
            NumeroPaginas = numeroPaginas;
            estaPrestado = false;
        }

        // Sobrescribir el método para mostrar información específica del libro
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
        }

        // Implementar métodos de la interfaz IPrestable
        public void Prestar()
        {
            if (estaPrestado)
            {
                Console.WriteLine($"{Titulo} ya está prestado.");
            }
            else
            {
                estaPrestado = true;
                Console.WriteLine($"{Titulo} ha sido prestado.");
            }
        }

        public void Devolver()
        {
            if (estaPrestado)
            {
                estaPrestado = false;
                Console.WriteLine($"{Titulo} ha sido devuelto.");
            }
            else
            {
                Console.WriteLine($"{Titulo} no está prestado.");
            }
        }
    }
}
