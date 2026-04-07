using System;
using System.Collections.Generic;
using System.Reflection;
using PeluqueriaElCojo.Atributos;

namespace PeluqueriaElCojo.Utilidades
{
    public static class Validador
    {
        public static List<string> Validar(object obj)
        {
            List<string> errores = new List<string>();
            PropertyInfo[] propiedades = obj.GetType().GetProperties();

            foreach (var prop in propiedades)
            {
                if (Attribute.IsDefined(prop, typeof(RequeridoAttribute)))
                {
                    object valor = prop.GetValue(obj);
                    if (valor == null || string.IsNullOrEmpty(valor.ToString()))
                    {
                        RequeridoAttribute att = (RequeridoAttribute)Attribute.GetCustomAttribute(prop, typeof(RequeridoAttribute));
                        errores.Add(att.Mensaje);
                    }
                }
            }
            return errores;
        }
    }
}