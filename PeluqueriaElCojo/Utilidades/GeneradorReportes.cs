using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PeluqueriaElCojo.Utilidades
{
    public static class GeneradorReportes
    {
        public static void CrearBackup<T>(List<T> datos, string ruta)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("RESPALDO DEL SISTEMA");
            sb.AppendLine("Fecha: " + DateTime.Now.ToString());
            sb.AppendLine("---------------------------");

            foreach (T item in datos)
            {
                sb.AppendLine(item.ToString());
            }

            File.WriteAllText(ruta, sb.ToString());
        }

        public static string ObtenerResumen<T>(List<T> datos, string titulo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- " + titulo.ToUpper() + " ---");

            foreach (var d in datos)
            {
                sb.AppendLine("> " + d.ToString());
            }

            sb.AppendLine("---------------------------");
            sb.AppendLine("Total registros: " + datos.Count);

            return sb.ToString();
        }
    }
}