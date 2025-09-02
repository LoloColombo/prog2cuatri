using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEstructurales.facade
{
    public class DBService
    {
        public void GuardarUsuario(string nombre, string email)
        {
            Console.WriteLine($"Usuario guardado: nombre: {nombre} y email: {email} ");
        }
    }
}
