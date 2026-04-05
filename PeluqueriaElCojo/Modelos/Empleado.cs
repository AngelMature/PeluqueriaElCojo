using System;

namespace PeluqueriaElCojo.Modelos   //Implementar ranking de barberos con interfaz IComparable
{
    public class Empleado : IComparable<Empleado>
    {
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public decimal SueldoBase { get; set; }
        public decimal TotalVentas { get; set; }

        public Empleado(string nombre, string apodo, decimal sueldo)
        {
            this.Nombre = nombre;
            this.Apodo = apodo;
            this.SueldoBase = sueldo;
            this.TotalVentas = 0;
        }

        public int CompareTo(Empleado otro)
        {
            if (otro == null) return 1;
            return otro.TotalVentas.CompareTo(this.TotalVentas);
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - Ventas: RD${2:N2}", Nombre, Apodo, TotalVentas);
        }
    }
}