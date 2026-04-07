using System;

namespace PeluqueriaElCojo.Atributos
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RangoAttribute : Attribute
    {
        public double Minimo { get; set; }
        public double Maximo { get; set; }

        public RangoAttribute(double min, double max)
        {
            this.Minimo = min;
            this.Maximo = max;
        }
    }
}