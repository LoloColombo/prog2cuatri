using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace PatronesDeDiseño.ejercicio_factory.clases
{
    public class OsmMapServicesFactory : IMapServicesFactory
    {
        public IMapa CreateMapa()
        {
            return new OsmMapas();
        }

        public IGeocoder CreateGeocoder()
        {
            return new OsmGeoCoder();
        }
    }
}
