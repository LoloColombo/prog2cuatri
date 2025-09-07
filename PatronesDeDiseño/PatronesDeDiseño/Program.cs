using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using PatronesDeDiseño.ejercicio_factory.clases;
using PatronesDeDiseño.ejercicio_buldier;
using PatronesDeDiseño.ejercicio_singleton;
using PatronesDeDiseño.ejercicio_factory;

namespace PatronesDeDiseño
{
    class Program
    {
        static void Main(string[] args)
        {
            //ej1
            DemoFactory.Run();

            //ej2
            DemoBuldier.Run();

            //ej3
            DemoSingleton.run();
           
            Console.ReadKey();
        }
    }
}
