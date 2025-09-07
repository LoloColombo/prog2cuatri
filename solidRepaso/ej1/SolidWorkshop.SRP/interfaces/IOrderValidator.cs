using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorkshop.SRP;

namespace SolidWorkshop.SRP.interfaces
{
    public interface IOrderValidator
    {
        void Validation(Order order);
    }
}
