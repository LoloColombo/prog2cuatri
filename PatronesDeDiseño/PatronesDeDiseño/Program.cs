using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using PatronesDeDiseño.ejercicio_factory.clases;

namespace PatronesDeDiseño
{
    class Program
    {
        static void Main(string[] args)
        {
            IMapServicesFactory factoryGoogle = new GoogleMapServicesFactory();
            IMapServicesFactory factoryOSM = new OsmMapServicesFactory();
            IMapServicesFactory factoryMapBox = new MapboxMapServiceFactory();

            var navegador = new Navegador(factoryGoogle);
            navegador.Explorador("mar del plata", "-21 -54", "bsas", "newYork");

            Console.ReadKey();
        }
    }
}
