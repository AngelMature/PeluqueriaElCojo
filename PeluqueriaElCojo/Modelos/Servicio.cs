using System;

namespace PeluqueriaElCojo.Modelos
{
    public abstract class Servicio : IFacturable
    {
        private string nombre;
        private decimal precioBase;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public decimal PrecioBase { get { return precioBase; } set { precioBase = value; } }
        public int DuracionMinutos { get; set; }

        public Servicio(string nombre, decimal precio, int duracion)
        {
            this.nombre = nombre;
            this.precioBase = precio;
            this.DuracionMinutos = duracion;
        }

   
        public virtual decimal CalcularPrecio()
        {
            return precioBase;
        }

        public virtual string GenerarLineaRecibo()
        {
            return string.Format("{0,-20} RD$ {1:N2}", nombre, CalcularPrecio());
        }
    }
}