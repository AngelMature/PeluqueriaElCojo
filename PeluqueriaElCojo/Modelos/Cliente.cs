using PeluqueriaElCojo.Atributos;
using System;

namespace PeluqueriaElCojo.Modelos
{
    public class Cliente
    {
        private static int _contadorId = 0;
        private int _visitas;

        public int Id { get; set; }

        [Requerido("El nombre del cliente es obligatorio")]
        public string Nombre { get; set; }

        [TelefonoDominicano(Mensaje = "Ingrese un teléfono válido (809/829/849)")]
        public string Telefono { get; set; }

        public TipoCliente Tipo { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Propiedad para acceder a las visitas (Encapsulación)
        public int Visitas
        {
            get { return _visitas; }
        }

        public Cliente(string nombre, string telefono)
        {
            Id = ++_contadorId;
            Nombre = nombre;
            Telefono = telefono;
            Tipo = TipoCliente.Nuevo;
            _visitas = 0;
            FechaRegistro = DateTime.Now;
        }

        public void RegistrarVisita()
        {
            _visitas++;

            if (_visitas >= 10) Tipo = TipoCliente.VIP;
            else if (_visitas >= 3) Tipo = TipoCliente.Regular;
        }

        public decimal ObtenerDescuento()
        {
            switch (Tipo)
            {
                case TipoCliente.VIP: return 0.15m;
                case TipoCliente.Regular: return 0.05m;
                default: return 0m;
            }
        }


        public override string ToString()
        {
            return string.Format("ID: {0} | Nombre: {1} | Tel: {2} | Tipo: {3} | Visitas: {4}",
                Id, Nombre, Telefono, Tipo, _visitas);
        }

        public string TelefonoFormateado()
        {
            try
            {
                return string.Format("{0:###-###-####}", long.Parse(Telefono.Replace("-", "").Replace(" ", "").Replace("(", "").Replace(")", "")));
            }
            catch
            {
                return Telefono; // Si falla el parseo, devuelve el original
            }
        }
    }

    public enum TipoCliente
    {
        Nuevo,
        Regular,
        VIP
    }
}