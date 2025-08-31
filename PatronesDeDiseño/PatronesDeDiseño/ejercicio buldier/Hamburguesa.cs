using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.ejercicio_buldier
{
    public class Hamburguesa
    {
        public string pan { get; internal set; } = "";
        public string carne { get; internal set; } = "";
        public bool queso { get; internal set; }
        public bool cebolla { get; internal set; }
        public bool tomate { get; internal set; }
        public bool lechuga { get; internal set; }
        public string salsa { get; internal set; } = "";

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"pan: {pan}");
            sb.AppendLine($"carne: {carne}");
            if (queso) { sb.AppendLine("queso"); }
            if (cebolla) { sb.AppendLine("cebolla"); }
            if (tomate) { sb.AppendLine("tomate"); }
            if (lechuga) { sb.AppendLine("lechuga"); }
            if (!string.IsNullOrEmpty(salsa)) { sb.AppendLine($"salsa:{salsa}"); }

            return sb.ToString();
        }
    }
}

