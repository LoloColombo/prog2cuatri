using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDComportamiento.Command;
using PDComportamiento.Observer;
using PDComportamiento.Strategy;

namespace PDComportamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("----------Strategy---------");
            DemoStrategy.Run();
            */
            /*
            Console.WriteLine("----------Observer---------");
            DemoObserver.Run();
            */
            Console.WriteLine("----------Command---------");
            DemoCommand.Run();
            Console.ReadKey();



        }
    }
}
