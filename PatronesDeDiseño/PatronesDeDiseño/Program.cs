using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using PatronesDeDiseño.ejercicio_factory.clases;
using PatronesDeDiseño.ejercicio_buldier;
using PatronesDeDiseño.ejercicio_singleton;

namespace PatronesDeDiseño
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             //ej1
            IMapServicesFactory factoryGoogle = new GoogleMapServicesFactory();
            IMapServicesFactory factoryOSM = new OsmMapServicesFactory();
            IMapServicesFactory factoryMapBox = new MapboxMapServiceFactory();

            var navegador = new Navegador(factoryMapBox);
            navegador.Explorador("mar del plata", "-21 -54", "buenos aires", "newYork");
            */


            //ej2
            /*
            var builder = new HamburguesaPersonalizableBuldier();
            var cocinero = new Cocinero();
            var completa = cocinero.HamburguesaCompleta(builder);
            builder.Reset();
            var simple = cocinero.HamburguesaSimple(builder);
            builder.Reset();

            var personalizada = new HamburguesaPersonalizableBuldier()
             .ConPan("Pan de papa")
             .ConCarne("Carne de cerdo")
             .ConTomate(true)
             .ConCebolla(false) 
             .ConLechuga(false)
             .ConSalsa("Mostaza y Miel")
             .Build();
            
            Console.WriteLine("Hamburguesas");
            Console.WriteLine("simple");
            Console.WriteLine(simple.ToString());
            Console.WriteLine("completa");
            Console.WriteLine(completa.ToString());
            Console.WriteLine("personalizada");
            Console.WriteLine(personalizada.ToString());
            */
             
            //ej3
            /*
            var a = Logger.instancia;
            a.Info("1 log");
            a.Info("2 log");
            a.Info("3 log");
            a.Info("4 log");

            var b = Logger.instancia;
            b.Info("5 log");
            Console.WriteLine("ver referencia");
            Console.WriteLine(ReferenceEquals(a, b));
            */
           
            Console.ReadKey();
        }
    }
}
