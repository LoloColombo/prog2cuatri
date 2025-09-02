using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEstructurales.decorator
{
    public class MensajeConEmoji : MensajeDecorador
    {
        public MensajeConEmoji(IMensaje mensaje) : base(mensaje) { }

        public override void Enviar(string mensaje)
        {
            base.Enviar(mensaje + "👋");
        }
    }
}
