using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Strategy
{
    public class SinDescuento : IDescuentoStrategy
    {
        public string Nombre => "Sin Descuento";

        public decimal Aplicar(decimal subTotal)
        {
           return subTotal;
        }
    }
}
