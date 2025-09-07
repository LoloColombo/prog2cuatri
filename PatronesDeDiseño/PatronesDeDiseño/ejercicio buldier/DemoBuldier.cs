using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.ejercicio_buldier
{
    public static class DemoBuldier
    {
        public static void Run()
        {
            
            var builder = new HamburguesaPersonalizableBuldier();
            var cocinero = new Cocinero();
            var completa = cocinero.HamburguesaCompleta(builder);
            builder.Reset();
            var simple = cocinero.HamburguesaSimple(builder);
            builder.Reset();

            var personalizada = new HamburguesaPersonalizableBuldier()
             .ConPan("Pan de papa")
             .ConCarne("Medallon de pollo")
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
            
        }
    }
}
