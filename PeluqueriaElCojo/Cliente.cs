using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo
{
    public class Cliente
    {
        private string _nombre;
        private string _telefono;
        private string _visitas;
        private static int _contador = 0;

        public int Id {  get; private set; }

        public string Nombre

        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nombre requerido");
                _nombre = value.Trim();
            }
        }

        public string Telefono
            { get { return _telefono; }
            set
            {
                string limpio = value.Replace("-", "").Replace(" ", "");
                if (limpio.Length != 10)
                    throw new ArgumentException("Telefono: 10 digitos");
                _telefono = limpio;
            }



        }
    }

}
