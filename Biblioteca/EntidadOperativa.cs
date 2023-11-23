namespace Biblioteca
{
    public class EntidadOperativa
    {
        //Atributos
        public string condicionFrenteAlIva;
        public int cuit;
        public string razonSocial;
        public string domicilioComercial;

        //Propiedades
        public string CondicionFrenteAlIva
        {
            get { return condicionFrenteAlIva; }
            set { condicionFrenteAlIva = value; }
        }
        public int Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }
        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }
        public string DomicilioComercial
        {
            get { return domicilioComercial; }
            set { domicilioComercial = value; }
        }

        // Constructor
        public EntidadOperativa(string condicionFrenteAlIva, int cuit, string razonSocial, string domicilioComercial)
        { 
            CondicionFrenteAlIva = condicionFrenteAlIva;
            Cuit = cuit;
            RazonSocial = razonSocial;
            DomicilioComercial = domicilioComercial;
        }

        public EntidadOperativa() { }
    }
}