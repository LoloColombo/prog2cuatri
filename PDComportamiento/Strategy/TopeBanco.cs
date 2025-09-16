using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Strategy
{
    public class TopeBanco : IDescuentoStrategy
    {
        public string Nombre => "Descuento monto fijo de 3500 pesos";

        public decimal Aplicar(decimal subTotal)
        {
            subTotal = subTotal - 3500;
            if(subTotal<0)
            {
                return 0;
            }
            else
            {
                return subTotal;
            }
            
        }
    }
}
