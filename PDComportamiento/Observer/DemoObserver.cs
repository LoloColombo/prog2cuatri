using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PDComportamiento.Observer.Estados;

namespace PDComportamiento.Observer
{
    public static class DemoObserver
    {
        public static void Run()
        {
            var pedido = new PedidoService();

            //observadores
            var cliente = new NotificadorCliente();
            var panel = new PanelLogistica();
            var auditoria = new AuditoriaPedidos();

            cliente.Suscribir(pedido);
            panel.Suscribir(pedido);
            auditoria.Suscribir(pedido);

            Console.WriteLine("flujo de Recibido -> Preparando -> Enviado -> Entregado \n");
            Console.WriteLine(" Recibido \n");
            pedido.CambiarEstado(101, EstadoPedido.Recibido);
            Console.WriteLine();
            Console.WriteLine("Preparando\n\n");
            pedido.CambiarEstado(101, EstadoPedido.Preparando);
            Console.WriteLine();
            Console.WriteLine("Enviado\n\n");
            pedido.CambiarEstado(101, EstadoPedido.Enviado);
            Console.WriteLine();
            Console.WriteLine("Entregado\n\n");
            pedido.CambiarEstado(101, EstadoPedido.Entregado);

        }

    }
}
