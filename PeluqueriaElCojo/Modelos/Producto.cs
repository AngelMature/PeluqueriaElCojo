using System;

namespace PeluqueriaElCojo.Modelos //Agregar modulo de productos
{
    public class Producto : IEquatable<Producto>, ICloneable
    {
        public string idProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioVenta { get; set; }
        public int CantidadStock { get; set; }

        public Producto(string id, string nombre, decimal precio, int stock)
        {
            this.idProducto = id;
            this.Nombre = nombre;
            this.PrecioVenta = precio;
            this.CantidadStock = stock;
        }

        public bool Equals(Producto otro)
        {
            if (otro == null) return false;
            return this.idProducto == otro.idProducto;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1} - RD${2:N2} (Stock: {3})", idProducto, Nombre, PrecioVenta, CantidadStock);
        }
    }
}