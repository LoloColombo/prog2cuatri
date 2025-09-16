using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PDComportamiento.Observer.Estados;

namespace PDComportamiento.Observer
{
    public class PedidoService
    {
        private Dictionary<int, EstadoPedido> estadosPedidos;

        public EventHandler<PedidoChangedEventArgs> estadoCambiado;

        public PedidoService()
        {
            estadosPedidos = new Dictionary<int, EstadoPedido>();
        }

        public void CambiarEstado(int pedidoId, EstadoPedido nuevo)
        {
            DateTime Hora = DateTime.Now;
            estadosPedidos[pedidoId] = nuevo;
            Console.WriteLine($"Estado de pedido modificado: {nuevo}");
            estadoCambiado?.Invoke(this, new PedidoChangedEventArgs(pedidoId, nuevo, Hora));
            
        }
    }
}
