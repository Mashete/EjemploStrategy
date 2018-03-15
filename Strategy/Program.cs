using Strategy.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var concentradorPaquetes = new Concentrador();
            concentradorPaquetes.ObtenerPaquetesDeProvedor();

            concentradorPaquetes.ObtenerInfoDePaquetesInternacionales();

            concentradorPaquetes.ObtenerInfoDePaquetesNacionales();

            Console.ReadKey();

        }
    }
}
