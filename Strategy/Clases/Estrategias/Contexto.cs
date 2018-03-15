using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Clases.Estrategias
{
    public class Contexto
    {
        private IConfiguracion configuracion;

        public IConfiguracion Configuracion
        {
            get { return configuracion; }
            set { this.configuracion = value; }
        }

        public string ObtenerDescripcion(string nombre)
        {
            return configuracion.ObtenerDescripcion(nombre);
        }

        public string ObtenerMontoTotal(float monto, float impuestos)
        {
            return configuracion.ObtenerMontoTotal(monto, impuestos);
        }
    }
}
