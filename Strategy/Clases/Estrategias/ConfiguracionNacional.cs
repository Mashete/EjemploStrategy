using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Clases.Estrategias
{
    public class ConfiguracionNacional : IConfiguracion
    {

        public string ObtenerDescripcion(string nombre)
        {
            return string.Concat("su producto es ", nombre);
        }

        public string ObtenerMontoTotal(float monto, float impuestos)
        {
            float total = monto * this.ObtenerCotizacionDolar() + impuestos * 2;
            return string.Concat(total.ToString(), "$");
        }

        private float ObtenerCotizacionDolar()
        {
            //Consulto Web Service del banco central y...
            return 21.2f;
        }
    }
}
