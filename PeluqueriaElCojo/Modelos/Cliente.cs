using PeluqueriaElCojo.Atributos;
using System;

namespace PeluqueriaElCojo.Modelos
{
    public class Cliente
    {
        private int _visitas;
        private string _nombre;
        private string _telefono;

        public int Id { get; set; }

        [Requerido("El nombre del cliente es obligatorio")]
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                _nombre = value;
            }
        }

        [TelefonoDominicano(Mensaje = "Ingrese un teléfono válido (809/829/849)")]
        public string Telefono
        {
            get { return _telefono; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("El teléfono es obligatorio.");
                _telefono = value;
            }
        }

        public TipoCliente Tipo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public int Visitas
        {
            get { return _visitas; }
            set { _visitas = value; }
        }

        public Cliente(string nombre, string telefono)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del cliente es obligatorio.");

            if (string.IsNullOrWhiteSpace(telefono))
                throw new ArgumentException("El teléfono del cliente es obligatorio.");

            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Tipo = TipoCliente.Nuevo;
            this._visitas = 0;
            this.FechaRegistro = DateTime.Now;
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
                string limpio = Telefono.Replace("-", "").Replace(" ", "").Replace("(", "").Replace(")", "");
                return string.Format("{0:###-###-####}", long.Parse(limpio));
            }
            catch
            {
                return Telefono;
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