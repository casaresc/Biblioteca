using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Clase derivada DVD
    public class DVD : Publicacion
    {
        public int Duracion { get; set; } // Duración en minutos

        public DVD(string titulo, string autor, int añoPublicacion, int duracion)
            : base(titulo, autor, añoPublicacion)
        {
            Duracion = duracion;
        }

        // Sobrescribir el método para mostrar información específica del DVD
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Duración: {Duracion} minutos");
        }
    }
}
