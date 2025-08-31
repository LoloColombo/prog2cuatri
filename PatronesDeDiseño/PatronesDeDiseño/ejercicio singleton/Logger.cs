using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.ejercicio_singleton
{
    public sealed class Logger
    {

        // 1. Instancia única y perezosa (Singleton)
        private static readonly Lazy<Logger> _instancia = new Lazy<Logger>(() => new Logger());

        public static Logger instancia => _instancia.Value;
        // 2. Estado interno (historial de mensajes)
        private readonly List<string> _logs = new List<string>();
        // 3. Constructor privado para evitar instanciación externa
        private Logger() { _logs = new List<string>();
            Console.WriteLine("Logger Inicializado");
        }
        // 4. API pública (métodos para interactuar con el Logger)
        public void Info(string message) 
        {
            string msgLog = $"[INFO]{message}";
            _logs.Add(msgLog);
            Console.WriteLine(msgLog); 
        }

        public void Dump()
        {
            Console.WriteLine("\n--- Historial de Logs ---");
            foreach (var mensaje in _logs)
            {
                Console.WriteLine(mensaje);
            }
            Console.WriteLine("--------------------------");
        }
    }
}
