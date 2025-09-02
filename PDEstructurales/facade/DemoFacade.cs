using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEstructurales.facade
{
    public static class DemoFacade
    {
        public static void Run()
        {
            UserFacade _userFacade = new UserFacade();

            Console.WriteLine(" Ingrese un nombre de usuario");
            string nombre = Console.ReadLine();

            Console.WriteLine(" Ingrese un email al usuario");
            string email = Console.ReadLine();


            _userFacade.RegistrarUsuario(nombre, email);
        }
    }
}
