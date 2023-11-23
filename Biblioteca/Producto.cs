using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto : ElementoComercial
    {
        // Constructor
        public Producto (int precio, string nombre, string descripcion)
            : base(precio, nombre, descripcion)
        {
        }
        public Producto() { }   
    }
}
