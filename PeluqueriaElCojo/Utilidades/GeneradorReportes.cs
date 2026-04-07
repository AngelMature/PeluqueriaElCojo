using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PeluqueriaElCojo.Utilidades
{
    public static class GeneradorReportes
    {
        // Método Genérico <T> para crear un Backup en TXT
        public static void CrearBackup<T>(List<T> lista, string nombreArchivo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== RESPALDO DE SEGURIDAD - PELUQUERIA EL COJO ===");
            sb.AppendLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("--------------------------------------------------");

            foreach (T item in lista)
            {
                sb.AppendLine(item.ToString());
            }

            // Guardar en la carpeta del proyecto
            File.WriteAllText(nombreArchivo, sb.ToString());
        }

        // Método Genérico para mostrar un resumen en consola 
        public static string ObtenerResumen<T>(List<T> datos, string titulo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- " + titulo.ToUpper() + " ---");
            foreach (var d in datos)
            {
                sb.AppendLine("> " + d.ToString());
            }
            sb.AppendLine("Total registros: " + datos.Count);
            return sb.ToString();

        }
    }
}