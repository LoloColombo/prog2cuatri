using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorkshop.SRP.interfaces;

namespace SolidWorkshop.SRP.Implementaciones
{
    public  class OrderValidator : IOrderValidator
    {
          
        public void Validation(Order order)
        {
            // 1) Validación
            if (order == null) throw new ArgumentNullException(nameof(order));
            if (string.IsNullOrWhiteSpace(order.CustomerEmail))
                throw new InvalidOperationException("Customer email is required.");
            if (order.Items.Count == 0)
                throw new InvalidOperationException("Order must have at least one item.");
        }
    }
}
