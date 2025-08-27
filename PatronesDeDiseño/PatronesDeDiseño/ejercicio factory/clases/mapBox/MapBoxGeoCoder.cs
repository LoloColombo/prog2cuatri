using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace PatronesDeDiseño.ejercicio_factory.clases
{
    public class MapBoxGeoCoder : IGeocoder
    {
        public void BuscarDirecciones(string direccion) { Console.WriteLine($"direccion  cordenadas {direccion} mapbox"); }
    }
}
