using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Strategy
{
    public class Porcentaje : IDescuentoStrategy
    {
        public string Nombre => "Descuento del 10 porciento";

        public decimal Aplicar(decimal subTotal)
        {
            return subTotal - subTotal * 10 / 100;
        }
    }
}
