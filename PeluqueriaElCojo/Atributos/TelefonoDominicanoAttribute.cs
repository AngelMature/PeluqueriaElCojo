using System;

namespace PeluqueriaElCojo.Atributos
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TelefonoDominicanoAttribute : Attribute
    {
        public string Mensaje => "El formato del teléfono no es válido para República Dominicana";
    }
}