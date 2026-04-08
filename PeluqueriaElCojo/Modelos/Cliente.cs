using System;
using PeluqueriaElCojo.Atributos;

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

        public string TelefonoFormateado()
        {
            return string.Format("{0:###-###-####}", long.Parse(Telefono.Replace("-", "")));
        }
    }

    public enum TipoCliente
    {
        Nuevo,
        Regular,
        VIP
    }
}