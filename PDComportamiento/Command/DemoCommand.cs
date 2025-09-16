using PDComportamiento.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Command
{
    public static class DemoCommand
    {
        public static void Run()
        {
            try
            {

                var carrito = new Carrito();
                var invoker = new CarritoInvoker();
                int opcion = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE LA OPCION");
                    Console.WriteLine("1= AGREGAR ITEM");
                    Console.WriteLine("2= QUITAR ITEM");
                    Console.WriteLine("3= CAMBIAR CANTIDAD");
                    Console.WriteLine("4= UNDO");
                    Console.WriteLine("5= REDO");
                    Console.WriteLine("6= TOTAL");
                    Console.WriteLine("7= PROMO");
                    Console.WriteLine("8= SALIR");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            {
                           
                                try
                                {
                                    Console.WriteLine("Ingrese el SKU del producto?");
                                    string sku = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nombre");
                                    string nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese el precio");
                                    decimal precio  = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la cantidad");
                                    int cantidad = int.Parse(Console.ReadLine());

                                    Item nuevoItem = new Item(sku, nombre, precio, cantidad);

                                    var CommandAgregar = new AgregarItemCommand(carrito, nuevoItem);
                                    CommandAgregar.Execute();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex + "Error al agregar intente de nuevo");
                                    return;
                                }
                               
                            }
                            break;
                        case 2:
                            {
                                try
                                {
                                    Console.WriteLine("Ingrese el SKU del producto a eliminar?");
                                    string sku = Console.ReadLine();

                                    var CommandQuitar = new QuitarItemCommand(carrito, sku);
                                    CommandQuitar.Execute();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex + "Error al quitar intente de nuevo");
                                    return;
                                }
                            }
                            break;
                        case 3:
                            {
                                try
                                {
                                    Console.WriteLine("Ingrese el SKU del producto a modificar?");
                                    string sku = Console.ReadLine();
                                    Console.WriteLine("Ingrese la nueva cantidad");
                                    int cantidad = int.Parse(Console.ReadLine());


                                    var CommandCambiar = new CambiarCantidadCommand(carrito, sku ,cantidad);
                                    CommandCambiar.Execute();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex + "Error al modificar intente de nuevo");
                                    return;
                                }
                            }
                            break;
                        case 4:
                            {
                               invoker.Undo();
                            }break;
                        case 5:
                            {
                                invoker.Redo();
                            }
                            break;
                        case 6:
                            {
                                Console.WriteLine($" TOTAL DEL CARRITO {carrito.Total()}");
                            }
                            break;
                        case 7:
                            {
                                Console.WriteLine("Ejecutando Promo Yogurt y Leche agregados con cantidad de 10");
                                Item nuevoItem1 = new Item("1231", "leche", 1200, 10);
                                Item nuevoItem2 = new Item("4363", "yogurt", 1700, 10);
                                var CommandAgregar1 = new AgregarItemCommand(carrito, nuevoItem1);
                                var CommandAgregar2 = new AgregarItemCommand(carrito, nuevoItem2);
                                List<ICommand> Promo = new List<ICommand>
                                {
                                    CommandAgregar1,
                                    CommandAgregar2
                                };


                                var MacroCommand = new MacroCommand(Promo);
                                invoker.Run(MacroCommand);

                            }
                            break;
                        case 8:
                            {
                                Console.WriteLine("Saliendo...");
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Ingrese una opcion valida");
                            }
                            break;
                    }
                    Console.ReadKey();
                } while (opcion < 9);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
        }



    }
}
