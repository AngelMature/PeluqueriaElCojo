using System;

namespace PeluqueriaElCojo.Atributos
{
    public class TelefonoDominicanoAttribute : ValidacionAttribute
    {
        
        public TelefonoDominicanoAttribute()
            : base("Formato de teléfono dominicano inválido")
        {
        }


        public override bool EsValido(object valor)
        {
            if (valor == null) return false;

            string telefono = valor.ToString();
            // Lógica simple para validar prefijos de RD
            return telefono.StartsWith("809") ||
                   telefono.StartsWith("829") ||
                   telefono.StartsWith("849");
        }
    }
}