using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEstructurales.adapter
{
    public class AdaptadorTermica : IImpresora
    {
        private readonly ImpresoraTermicaVieja _legacy;

        public AdaptadorTermica(ImpresoraTermicaVieja legacy)
        {
            _legacy = legacy;
        }

        public void Imprimir(string texto)
        {
            if(texto.Length <= 100)
            {
                _legacy.PrintTicket(texto);
            }
            else
            {
                Console.WriteLine(texto);
            }
          

        }
    }
}
