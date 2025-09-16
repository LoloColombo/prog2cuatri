using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Command
{
    public class AgregarItemCommand : ICommand
    {
        private Carrito carrito;
        private Item item;

        public AgregarItemCommand(Carrito carrito, Item item)
        {
            this.carrito = carrito;
            this.item = item;
        }

        public void Execute()
        {
          carrito.Agregar(item);
        }

        public void Undo()
        {
            carrito.Quitar(item.sku);
      
        }
    }
}
