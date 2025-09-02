using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEstructurales.decorator
{
    public class MensajeEncriptado : MensajeDecorador
    {
        public MensajeEncriptado(IMensaje mensaje) : base(mensaje) { }

        public override void Enviar(string mensaje)
        {
            base.Enviar(mensaje.ToUpper());
        }

    }
}
