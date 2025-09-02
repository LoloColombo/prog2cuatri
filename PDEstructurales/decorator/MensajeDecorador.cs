using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEstructurales.decorator
{
    public abstract class MensajeDecorador : IMensaje
    {

        protected readonly IMensaje _mensaje;

        protected MensajeDecorador(IMensaje mensaje)
        {
            _mensaje = mensaje;
        }

        public virtual void Enviar(string mensaje)
        {
            _mensaje.Enviar(mensaje);
        }
    }
}
