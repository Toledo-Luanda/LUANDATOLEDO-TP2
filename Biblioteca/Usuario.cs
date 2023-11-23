using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario : EntidadOperativa
    {

        // Constructor
        public Usuario(string razonSocial, int cuit)
            : base("", cuit, razonSocial, "")
        {
        }
    }
}
