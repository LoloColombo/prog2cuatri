using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Observer
{
    public class AuditoriaPedidos
    {
        public void Suscribir(PedidoService p) => p.estadoCambiado += OnEstadoCambiado;
        public void Desuscribir(PedidoService p) => p.estadoCambiado -= OnEstadoCambiado;

        private void OnEstadoCambiado(object sender, PedidoChangedEventArgs p)
        {
            Console.WriteLine($"AUDITORIA: cambio registrado: pedido= {p.PedidoId} nuevo estado = {p.NuevoEstado} fecha={p.Cuando}");
        }
    }
}
