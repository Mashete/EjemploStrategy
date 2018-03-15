using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Clases.Estrategias
{
    public class ConfiguracionInternacional : IConfiguracion

    {
        public string ObtenerDescripcion(string nombre)
        {
            return string.Concat("Your product is ", nombre);
        }

        public string ObtenerMontoTotal(float monto, float impuestos)
        {
            float total = monto + impuestos;
            return string.Concat(total.ToString(), "U$D");
        }
    }
}
