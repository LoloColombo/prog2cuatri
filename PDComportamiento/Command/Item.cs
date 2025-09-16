using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Command
{
    public class Item
    {
        public string sku {  get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }

        public Item() { }

        public Item(string sku, string name, decimal price, int quantity)
        {
            this.sku = sku;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
