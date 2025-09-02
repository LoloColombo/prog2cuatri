using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEstructurales.facade
{
    public class UserFacade
    {
        private readonly DBService _dBService = new DBService();
        private readonly EmailValidator _emailValidator = new EmailValidator();
        private readonly EmailSender _emailsender = new EmailSender();

        public void RegistrarUsuario(string nombre, string email)
        {
            Console.WriteLine("Cargando registrar usuario comenzando validacion");
            bool validacion = _emailValidator.EsValido(email);
            if (validacion)
            {
                Console.WriteLine("Email valido");
                _dBService.GuardarUsuario(nombre, email);
                _emailsender.EnviarBienvenida(email);
            }
            else
            {
                Console.WriteLine("Email invalido");
            }
        }
    }
}
