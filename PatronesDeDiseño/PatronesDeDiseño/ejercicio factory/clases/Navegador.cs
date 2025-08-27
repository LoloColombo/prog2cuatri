using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace PatronesDeDiseño.ejercicio_factory.clases
{
    public class Navegador
    {
        private IMapa mapa;
        private IGeocoder geocoder;
        private IRuteador ruteador;

        public Navegador(IMapServicesFactory factory)
        {
            mapa = factory.CreateMapa();
            geocoder = factory.CreateGeocoder();
            ruteador = factory.CreateRuteador();
        }

        public void Explorador(string ubicacion, string direccion, string desde, string hasta)
        {
            mapa.MostrarMapa(ubicacion);
            geocoder.BuscarDirecciones(direccion);
            ruteador.CalcularRuta(desde, hasta);
        }
    }
}
