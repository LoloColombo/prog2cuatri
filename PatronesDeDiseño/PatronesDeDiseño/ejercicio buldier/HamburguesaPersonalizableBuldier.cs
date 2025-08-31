using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.ejercicio_buldier
{
    public class HamburguesaPersonalizableBuldier : IHamburguesaBuldier
    {
        private Hamburguesa hamburguesa = new Hamburguesa();

        public void Reset()
        {
            hamburguesa = new Hamburguesa();
        }

        public IHamburguesaBuldier ConPan(string pan)
        {
            hamburguesa.pan = pan;
            return this;
        }

        public IHamburguesaBuldier ConCarne(string carne)
        {
            hamburguesa.carne = carne;
            return this;
        }

        public IHamburguesaBuldier ConQueso(bool queso = true)
        {
            hamburguesa.queso = queso;
            return this;
        }

        public IHamburguesaBuldier ConCebolla(bool cebolla = true)
        {
            hamburguesa.cebolla = cebolla;
            return this;
        }

        public IHamburguesaBuldier ConTomate(bool tomate = true)
        {
            hamburguesa.tomate = tomate;
            return this;
        }

        public IHamburguesaBuldier ConLechuga(bool lechuga = true)
        {
            hamburguesa.lechuga = lechuga;
            return this;
        }

        public IHamburguesaBuldier ConSalsa(string salsa)
        {
            hamburguesa.salsa = salsa;
            return this;
        }

        public Hamburguesa Build()
        {
            if (string.IsNullOrEmpty(hamburguesa.pan))
            {
                throw new InvalidOperationException("La hamburguesa debe tener pan");
            }
            if (string.IsNullOrEmpty(hamburguesa.carne))
            {
                throw new InvalidOperationException("La hamburguesa debe tener carne");
            }

            return hamburguesa;
        }
    }
}
