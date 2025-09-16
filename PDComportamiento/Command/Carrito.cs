using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Command
{
    public class Carrito
    {
        public List<Item> Items { get; private set; } = new List<Item>();
        public Dictionary<string, Item> itemsD { get; private set; } = new Dictionary<string, Item>();


        public Carrito() { }

        public void Agregar(Item nuevoItem)
        {
            Items.Add(nuevoItem);
            itemsD[nuevoItem.sku] = nuevoItem;
        }

        public void Quitar(string sku)
        {
            Item itemEliminar = itemsD[sku];
            Items.Remove(itemEliminar);
            itemsD.Remove(sku);
        }

        public void CambiarCantidad(string sku, int nuevaCantidad)
        {
            Item itemActualizar = itemsD[sku];
            itemActualizar.quantity = nuevaCantidad;
            itemsD[itemActualizar.sku] = itemActualizar;

            for (int i = 0; i< Items.Count; i++)
            {
                if (itemActualizar.sku.Equals(Items[i].sku))
                {
                    Items[i].quantity = nuevaCantidad;
                }
            }
        }

        public decimal Total()
        {
            decimal total = 0;
            for (int i = 0; i < Items.Count; i++)
            {
                total += Items[i].price * Items[i].quantity;
            }
            return total;
        }

    }
}
