using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Strategy
{
    public interface IDescuentoStrategy
    {
        decimal Aplicar(decimal subTotal);
        string Nombre {  get; }
    }
}
