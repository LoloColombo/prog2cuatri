using interfaces;
using PatronesDeDiseño.ejercicio_factory.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.ejercicio_factory
{
    public static class DemoFactory
    {
        public static void Run()
        {
            
            IMapServicesFactory factoryGoogle = new GoogleMapServicesFactory();
            IMapServicesFactory factoryOSM = new OsmMapServicesFactory();
            IMapServicesFactory factoryMapBox = new MapboxMapServiceFactory();

            var navegador = new Navegador(factoryMapBox);
            navegador.Explorador("mar del plata", "-21 -54", "buenos aires", "newYork");
            
        }
    }
}
