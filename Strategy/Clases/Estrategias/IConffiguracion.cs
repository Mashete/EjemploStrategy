using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Clases.Estrategias
{
    public interface IConfiguracion
    {
        string ObtenerMontoTotal(float monto, float impuestos);

        string ObtenerDescripcion(string nombre);
    }
}
