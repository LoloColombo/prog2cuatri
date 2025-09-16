using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Observer
{
    public class NotificadorCliente
    {
        public void Suscribir(PedidoService p) => p.estadoCambiado += OnEstadoCambiado;
        public void Desuscribir(PedidoService p) => p.estadoCambiado -= OnEstadoCambiado;

        private void OnEstadoCambiado(object sender,PedidoChangedEventArgs p)
        {
            Console.WriteLine($"CLIENTE: Tu pedido {p.PedidoId} ahora esta {p.NuevoEstado}");
        }
    }
}
