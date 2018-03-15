using Strategy.Clases.Estrategias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Clases
{
    public class Paquete
    {
        private Contexto contexto;

        public float Monto { get; set; }
        public float Impuestos { get; set; }
        public string Nombre { get; set; }

        public Paquete()
        {
            contexto = new Contexto();
        }

        public void ConfiguracionNacional()
        {
            IConfiguracion config = new ConfiguracionNacional();
            contexto.Configuracion = config;
        }

        public void ConfiguracionInternacional()
        {
            IConfiguracion config = new ConfiguracionInternacional();
            contexto.Configuracion = config;
        }

        public string ObtenerInformacionDelProducto()
        {
            return string.Concat(contexto.ObtenerDescripcion(this.Nombre), " - ", contexto.ObtenerMontoTotal(this.Monto, this.Impuestos));
        }


    }
}
