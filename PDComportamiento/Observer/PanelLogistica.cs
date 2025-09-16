using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Observer
{
    public class PanelLogistica
    {
        public void Suscribir(PedidoService p) => p.estadoCambiado += OnEstadoCambiado;
        public void Desuscribir(PedidoService p) => p.estadoCambiado -= OnEstadoCambiado;

        private void OnEstadoCambiado(object sender, PedidoChangedEventArgs p)
        {
            Console.WriteLine($"LOGISTICA: Pedido {p.PedidoId} => {p.NuevoEstado} y {p.Cuando} ");
        }
    }
}
