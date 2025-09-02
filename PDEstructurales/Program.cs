using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDEstructurales.adapter;
using PDEstructurales.decorator;
using PDEstructurales.facade;

namespace PDEstructurales
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1*/
            DemoAdapter.Run();
            Console.WriteLine("------------------");
            DemoDecorate.Run();
            Console.WriteLine("------------------");
            DemoFacade.Run();
            Console.ReadKey();
        }
    }
}
