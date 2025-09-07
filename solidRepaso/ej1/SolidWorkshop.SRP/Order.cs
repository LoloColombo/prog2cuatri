using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop.SRP
{
    public class Order
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public string CustomerEmail { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public decimal Total => CalculateTotal();

        private decimal CalculateTotal()
        {
            decimal sum = 0;
            foreach (var it in Items) sum += it.UnitPrice * it.Qty;
            return sum;
        }
    }
}
