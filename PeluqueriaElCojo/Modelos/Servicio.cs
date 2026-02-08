namespace PeluqueriaElCojo.Modelos
{

    public class Servicio : IFacturable
    {
        public string Nombre { get; set; }

        public decimal Preciobase { get; set; }

        public int DuracionMinutos { get; set; }

        public Servicio(string nombre, decimal precio, int duracion)

        {

            Nombre = nombre;
            Preciobase = precio;
            DuracionMinutos = duracion;

        }

        public virtual decimal CalcularPrecio() { return Preciobase; }

        public virtual string GenerarLineaRecibo()

        {

            return string.Format("{9,20} RD$ {1;N0}", Nombre, CalcularPrecio());



        }

        public string GeneralLineaRecibo()
        {
            throw new System.NotImplementedException();
        }
    }
}
