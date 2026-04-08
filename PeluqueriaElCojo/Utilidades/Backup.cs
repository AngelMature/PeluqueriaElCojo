using System;
using System.IO;

namespace PeluqueriaElCojo.Utilidades
{
    public static class Backup
    {
        public static void GenerarBackup(string origen, string destino)
        {
            try
            {

                if (File.Exists(origen))
                {
                    File.Copy(origen, destino, true);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Fallo en el respaldo: " + ex.Message);
            }
        }
    }
}