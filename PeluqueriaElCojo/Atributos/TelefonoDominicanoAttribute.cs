using System;

namespace PeluqueriaElCojo.Atributos
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TelefonoDominicanoAttribute : Attribute
    {
        public string Mensaje { get; set; }

        public TelefonoDominicanoAttribute()
        {
            this.Mensaje = "Formato de teléfono dominicano inválido";
        }
    }
}