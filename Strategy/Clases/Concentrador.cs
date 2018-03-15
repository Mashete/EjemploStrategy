using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Clases
{
    public class Concentrador
    {
        private IList<Paquete> paquetes;

        public Concentrador()
        {
            paquetes = new List<Paquete>();
        }

        public void ObtenerPaquetesDeProvedor()
        {
            for (int i = 0; i < 10; i++)
            {
                paquetes.Add(new Paquete { Nombre = "Paquete" + i, Monto = (i + 1) * 100, Impuestos = 10 });
            }
            Console.WriteLine(string.Concat("se obtubieron ", paquetes.Count, " paquetes"));
        }

        public void ObtenerInfoDePaquetesInternacionales()
        {
            foreach (Paquete paquete in paquetes)
            {
                paquete.ConfiguracionInternacional();
                Console.WriteLine(paquete.ObtenerInformacionDelProducto());
            }
        }

        public void ObtenerInfoDePaquetesNacionales()
        {
            foreach (Paquete paquete in paquetes)
            {
                paquete.ConfiguracionNacional();
                Console.WriteLine(paquete.ObtenerInformacionDelProducto());
            }
        }

    }
}
