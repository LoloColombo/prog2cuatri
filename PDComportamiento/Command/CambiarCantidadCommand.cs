using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Command
{
    public class CambiarCantidadCommand : ICommand
    {
        private Carrito carrito;
        private string sku;
        private int cantidadNueva;
        private int cantidadAnterior;

        public CambiarCantidadCommand(Carrito carrito, string sku, int cantidadNueva)
        {
            this.carrito = carrito;
            this.sku = sku;
            this.cantidadNueva = cantidadNueva;
        }

        public void Execute()
        {
           cantidadAnterior = carrito.itemsD[sku].quantity;
           carrito.CambiarCantidad(sku, cantidadNueva);
        }

        public void Undo()
        {
            carrito.CambiarCantidad(sku, cantidadAnterior);
        }
    }
}
