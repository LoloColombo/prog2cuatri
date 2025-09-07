using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorkshop.SRP.interfaces;

namespace SolidWorkshop.SRP.Implementaciones
{
    public class ConsoleLog : ILogger
    {
        public void Log(string txt)
        {
            Console.WriteLine(txt);
        }

    }
}
