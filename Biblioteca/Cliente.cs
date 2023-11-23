using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : EntidadOperativa
    {
        // Constructor
        public Cliente( string condicionFrenteAlIva, int cuit, string razonSocial, string domicilioComercial)
            : base( condicionFrenteAlIva, cuit, razonSocial, domicilioComercial)
        {
        }
        public Cliente()
        {

        }
    }
}
