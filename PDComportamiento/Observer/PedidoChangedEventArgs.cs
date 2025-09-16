using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PDComportamiento.Observer.Estados;

namespace PDComportamiento.Observer
{
    public class PedidoChangedEventArgs : EventArgs
    {
        public int PedidoId {  get;}
        public EstadoPedido NuevoEstado { get;}
        public DateTime Cuando { get;}

        public PedidoChangedEventArgs(int pedidoId, EstadoPedido nuevoEstado, DateTime cuando)
        {
            PedidoId = pedidoId;
            NuevoEstado = nuevoEstado;
            Cuando = cuando;
        }
    }
}
