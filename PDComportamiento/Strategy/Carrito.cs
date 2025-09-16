using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Strategy
{
    public class Carrito
    {
        private IDescuentoStrategy descuento;

        public Carrito(IDescuentoStrategy descuento) { this.descuento = descuento; }

        public void SetDescuento(IDescuentoStrategy nuevoDescuento)
        {
            descuento = nuevoDescuento;
            Console.WriteLine($"Estrategia de descuento modificada a: {descuento.Nombre}");
        }

        public decimal Total(decimal subTotal)
        {
            decimal total = descuento.Aplicar(subTotal);
            return total;
        }

    }
}
