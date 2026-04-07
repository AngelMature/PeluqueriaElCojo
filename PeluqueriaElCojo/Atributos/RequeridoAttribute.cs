using System;

namespace PeluqueriaElCojo.Atributos
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequeridoAttribute : Attribute
    {
        public string Mensaje { get; set; }
        public RequeridoAttribute(string mensaje)
        {
            this.Mensaje = mensaje;
        }
    }
}