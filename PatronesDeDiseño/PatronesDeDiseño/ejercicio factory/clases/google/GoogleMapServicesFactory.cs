using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace PatronesDeDiseño.ejercicio_factory.clases
{
    public class GoogleMapServicesFactory : IMapServicesFactory
    {
        public IMapa CreateMapa()
        {
            return new GoogleMapas();
        }

        public IGeocoder CreateGeocoder()
        {
            return new GoogleGeoCoder();
        }

        public IRuteador CreateRuteador()
        {
            return new GoogleRuteador();
        }
    }
}
