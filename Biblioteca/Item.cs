using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Item
    {
        // Atributos 
        private ElementoComercial elemento;
        private int cantidad;

        // Propiedades
        public ElementoComercial Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        // Constructor
        public Item(ElementoComercial elemento, int cantidad)
        {
            Elemento = elemento;
            Cantidad = cantidad;
        }
    }
}
