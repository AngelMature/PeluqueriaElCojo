using System;

namespace PeluqueriaElCojo.Atributos
{
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class ValidacionAttribute : Attribute
    {
        public string Mensaje { get; set; }

        protected ValidacionAttribute(string mensaje)
        {
            this.Mensaje = mensaje;
        }

        public abstract bool EsValido(object valor);
    }
}