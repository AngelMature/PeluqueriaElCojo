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

            foreach (PropertyInfo prop in propiedades)
            {
                object valor = prop.GetValue(obj);

                // 1. Requerido
                if (Attribute.IsDefined(prop, typeof(RequeridoAttribute)))
                {
                    if (valor == null || string.IsNullOrEmpty(valor.ToString()))
                    {
                        var att = (RequeridoAttribute)Attribute.GetCustomAttribute(prop, typeof(RequeridoAttribute));
                        errores.Add(att.Mensaje);
                    }
                }

                // 2. Rango
                if (Attribute.IsDefined(prop, typeof(RangoAttribute)))
                {
                    if (valor != null && double.TryParse(valor.ToString(), out double num))
                    {
                        var att = (RangoAttribute)Attribute.GetCustomAttribute(prop, typeof(RangoAttribute));
                        if (num < att.Minimo || num > att.Maximo)
                        {
                            errores.Add(string.Format("El campo {0} debe estar entre {1} y {2}", prop.Name, att.Minimo, att.Maximo));
                        }
                    }
                }

                // TelefonoDominicano
                if (Attribute.IsDefined(prop, typeof(TelefonoDominicanoAttribute)))
                {
                    if (valor != null)
                    {
                        string tel = valor.ToString().Replace("-", "").Replace(" ", "");
                        if (tel.Length != 10 || (!tel.StartsWith("809") && !tel.StartsWith("829") && !tel.StartsWith("849")))
                        {
                            var att = (TelefonoDominicanoAttribute)Attribute.GetCustomAttribute(prop, typeof(TelefonoDominicanoAttribute));
                            errores.Add(att.Mensaje);
                        }
                    }
                }
            }
            return errores;
        }
    }
}