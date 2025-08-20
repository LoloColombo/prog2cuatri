using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop.SRP.interfaces
{
    public interface INotificationService
    {
        void SendConfirmation(Order order);
    }
}
