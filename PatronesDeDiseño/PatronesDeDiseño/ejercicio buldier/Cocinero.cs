using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.ejercicio_buldier
{
    public class Cocinero
    {
        public Hamburguesa HamburguesaCompleta(IHamburguesaBuldier builder)
        {
            return builder
                .ConPan("Clasico")
                .ConCarne("Simple")
                .ConQueso(true)
                .ConCebolla(true)
                .ConTomate(true)
                .ConLechuga(true)
                .ConSalsa("Mayones y Ketchup")
                .Build();
        }

        public Hamburguesa HamburguesaSimple(IHamburguesaBuldier builder)
        {
            return builder
                .ConPan("Clasico")
                .ConCarne("Simple")
                .ConQueso(false)
                .ConCebolla(false)
                .ConTomate(false)
                .ConLechuga(false)
                .ConSalsa("sin salsa")
                .Build();
        }
    }
}
