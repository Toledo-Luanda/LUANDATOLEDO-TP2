using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class DetalleDocumentoComercial
    {
        // Atributos
        private int numeroFactura;
        private DateTime fechaEmision;
        private string clienteAsociado;
        private List<Item> listaDeItems;
        private bool iva;
        private bool percepcionesAplicadas;

        // Propiedades
        public int NumeroFactura
        {
            get { return numeroFactura; } 
            set { numeroFactura = value; } 
        }
        public DateTime FechaEmision
        {
            get { return fechaEmision; }
            set { fechaEmision = value; }
        }
        public string ClienteAsociado
        {
            get { return clienteAsociado; }
            set { clienteAsociado = value; }
        }
        public List<Item> ListaDeItems
        {
            get { return listaDeItems; }
            set { listaDeItems = value; }
        }
        public bool Iva
        {
            get { return iva; }
            set { iva = value; }
        }
        public bool PercepcionesAplicadas
        {
            get { return percepcionesAplicadas; }
            set { percepcionesAplicadas = value; }
        }

        // Constructor
        public DetalleDocumentoComercial(int numeroFactura, DateTime fechaEmision, string clienteAsociado)
        {
            NumeroFactura = numeroFactura;
            FechaEmision = fechaEmision;
            ClienteAsociado = clienteAsociado;
            ListaDeItems = new List<Item>();
            Iva = false;
            PercepcionesAplicadas = false;
        }

        // Método para agregar un ítem a la lista
        public void AgregarItem(Item item)
        {
            ListaDeItems.Add(item);
        }

        // Método para aplicar IVA y especificar el tipo
        public void AplicarIVA(bool tipoIVA)
        {
            Iva = true;
            if (tipoIVA)
            {
                Console.WriteLine("Se aplica IVA del 21%.");
            }
            else
            {
                Console.WriteLine("Se aplica IVA del 10.5%.");
            }
        }

        // Método para agregar percepciones
        public void AgregarPercepciones(bool suSS, bool ibba, bool ganancias)
        {
            PercepcionesAplicadas = true;
            if (suSS)
            {
                Console.WriteLine("Se aplicó percepción SUSS.");
            }
            if (ibba)
            {
                Console.WriteLine("Se aplicó percepción IBBA.");
            }
            if (ganancias)
            {
                Console.WriteLine("Se aplicó percepción GANANCIAS.");
            }
        }

        // Método abstracto que debe ser implementado por las clases derivadas
        public abstract void CalcularTotalItem(Item item);
    }
}
