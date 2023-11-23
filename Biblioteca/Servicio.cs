using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Servicio : ElementoComercial
    {
        // Constructor
        public Servicio(int precio, string nombre, string descripcion)
            : base(precio, nombre, descripcion)
        {
        }

        public Servicio() { }
    }
}