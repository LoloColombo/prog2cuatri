
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.ejercicio_buldier
{
    public interface IHamburguesaBuldier
    {
        IHamburguesaBuldier ConPan(string pan);
        IHamburguesaBuldier ConCarne(string carne);
        IHamburguesaBuldier ConQueso(bool queso = true);
        IHamburguesaBuldier ConCebolla(bool cebolla = true);
        IHamburguesaBuldier ConTomate(bool tomate = true);
        IHamburguesaBuldier ConLechuga(bool lechuga = true);
        IHamburguesaBuldier ConSalsa(string salsa);
        Hamburguesa Build();
    }
}
