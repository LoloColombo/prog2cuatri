using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace PatronesDeDiseño.ejercicio_factory.clases
{
    public class MapboxMapServiceFactory : IMapServicesFactory
    {
        public IMapa CreateMapa()
        {
            return new MapBoxMapa();
        }

        public IGeocoder CreateGeocoder()
        {
            return new MapBoxGeoCoder();
        }
    }
}
