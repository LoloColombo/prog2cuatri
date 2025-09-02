using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEstructurales.decorator
{
    public static class DemoDecorate
    {
        public static void Run()
        {
            IMensaje msj = new MensajeSimple();

            msj = new MensajeEncriptado(msj);
            msj = new MensajeConEmoji(msj);
            msj.Enviar("Hola mundo");
        }
    }
}
