using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Clase derivada Revista
    public class Revista : Publicacion
    {
        public int NumeroVolumenes { get; set; }

        public Revista(string titulo, string autor, int añoPublicacion, int numeroVolumenes)
            : base(titulo, autor, añoPublicacion)
        {
            NumeroVolumenes = numeroVolumenes;
        }

        // Sobrescribir el método para mostrar información específica de la revista
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de Volúmenes: {NumeroVolumenes}");
        }
    }
}
