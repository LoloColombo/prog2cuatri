using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.ejercicio_singleton
{
    public static class DemoSingleton
    {
        public static void run()
        {
            
              var a = Logger.instancia;
                 a.Info("1 log");
                 a.Info("2 log");
                 a.Info("3 log");
                 a.Info("4 log");

              var b = Logger.instancia;
                 b.Info("5 log");
              Console.WriteLine("ver referencia");
              Console.WriteLine(ReferenceEquals(a, b));

        }
    }
}
