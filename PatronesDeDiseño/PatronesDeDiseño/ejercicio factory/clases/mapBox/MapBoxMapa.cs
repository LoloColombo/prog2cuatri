using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace PatronesDeDiseño.ejercicio_factory.clases
{
    public class MapBoxMapa : IMapa
    {
        public void MostrarMapa(string ubicacion) { Console.WriteLine($"mostrar mapa mapbox de {ubicacion}"); }
    }
}
