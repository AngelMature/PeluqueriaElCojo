using System;

namespace PeluqueriaElCojo.Modelos
{
    public class Producto : IEquatable<Producto>, ICloneable
    {
        
        public string idProducto { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Costo { get; set; }
        public int CantidadStock { get; set; }
        public int StockMinimo { get; set; }

        
        public Producto() { }

        
        public Producto(string id, string nombre, string categoria, decimal precio, decimal costo, int stock, int stockMinimo = 2)
        {
            this.idProducto = id;
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.PrecioVenta = precio;
            this.Costo = costo;
            this.CantidadStock = stock;
            this.StockMinimo = stockMinimo;
        }

        public decimal CalcularGanancia()
        {
            return PrecioVenta - Costo;
        }

        public bool EstaBajoStock()
        {
            return CantidadStock <= StockMinimo;
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
            
            return string.Format("[{0}] {1} ({2}) - Venta: RD${3:N2} | Ganancia: RD${4:N2} | Stock: {5}",
                idProducto,
                Nombre,
                Categoria,
                PrecioVenta,
                CalcularGanancia(),
                CantidadStock);
        }
    }
}