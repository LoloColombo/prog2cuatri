using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace PatronesDeDiseño.ejercicio_factory.clases
{
    public class MapBoxRuteador : IRuteador
    {
        public void CalcularRuta(string desde, string hasta)
        {
            Console.WriteLine($"Ruta desde: {desde} hasta: {hasta} mapbox");
        }
    }
}
