using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PeluqueriaElCojo.Utilidades
{
    public static class GeneradorReportes
    {
        public static void CrearBackup<T>(List<T> datos, string nombreArchivo)
        {
            // Se guarda en la carpeta bin/Debug del proyecto
            string ruta = AppDomain.CurrentDomain.BaseDirectory + nombreArchivo;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("===========================================");
            sb.AppendLine("   RESPALDO DE DATOS - PELUQUERÍA EL COJO  ");
            sb.AppendLine("   Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine("===========================================");
            sb.AppendLine();

            foreach (T item in datos)
            {
                sb.AppendLine(item.ToString());
            }

            File.WriteAllText(ruta, sb.ToString(), Encoding.UTF8);
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