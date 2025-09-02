using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEstructurales.adapter
{
    public static class DemoAdapter
    {
        public static void Run()
        {
            IImpresora impresora = new AdaptadorTermica(new ImpresoraTermicaVieja());
            impresora.Imprimir("prueba 1");
        }
    }
}
