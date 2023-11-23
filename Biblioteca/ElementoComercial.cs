using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class ElementoComercial
    {
        // Atributos
        private int precio;
        private string nombre;
        private string descripcion;

        // Propiedades

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        // Constructor
        protected ElementoComercial(int precio, string nombre, string descripcion)
        {
            Precio = precio;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public ElementoComercial() { }
    }
}
