using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Strategy
{
    public static class DemoStrategy
    {
        public static void Run()
        {
            try
            {
                Console.WriteLine("ingrese el subtotal:");
                decimal subtotal = decimal.Parse(Console.ReadLine());

                var carrito = new Carrito(new SinDescuento());
                int opcion = 0;
                do
                {
                    Console.WriteLine("INGRESE EL TIPO DE DESCUENTO");
                    Console.WriteLine("1= SIN DESCUENTO");
                    Console.WriteLine("2= 10 PORCIENTO");
                    Console.WriteLine("3= MONTO FIJO 3500");
                    Console.WriteLine("4= SALIR");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            {
                                carrito.SetDescuento(new SinDescuento());
                                Console.WriteLine($"Total {nameof(SinDescuento)}: {carrito.Total(subtotal)}");
                            }
                            break;
                        case 2:
                            {
                                carrito.SetDescuento(new Porcentaje());
                                Console.WriteLine($"Total {nameof(Porcentaje)}: {carrito.Total(subtotal)}");
                            }
                            break;
                        case 3:
                            {
                                carrito.SetDescuento(new TopeBanco());
                                Console.WriteLine($"Total {nameof(TopeBanco)}: {carrito.Total(subtotal)}");
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Ingrese una opcion valida");

                            }
                            break;
                    }
                } while(opcion<4);
               
            }
            catch(Exception e)
            {
                Console.WriteLine(e);   
                return;
            }
        }

   

    }
}
