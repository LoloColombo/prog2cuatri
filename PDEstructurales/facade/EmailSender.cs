using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEstructurales.facade
{
   public  class EmailSender
    {
       
            public void EnviarBienvenida(string email)
            {
                  Console.WriteLine($" enviando email a {email}");
                  Console.WriteLine("Bienvenido");
            }
        
    }
}
