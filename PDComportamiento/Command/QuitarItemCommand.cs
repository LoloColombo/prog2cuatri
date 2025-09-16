using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Command
{
    public class QuitarItemCommand : ICommand
    {
        private Carrito carrito;
        private string sku;
        private Item backup;

        public QuitarItemCommand(Carrito carrito, string sku)
        {
            this.carrito = carrito;
            this.sku = sku;
        }

        public void Execute()
        {
            backup = carrito.itemsD[sku];
            carrito.Quitar(sku);
        }

        public void Undo()
        {
            carrito.Agregar(backup);
        }
    }
}
