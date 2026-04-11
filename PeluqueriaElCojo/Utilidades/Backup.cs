using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace PeluqueriaElCojo.Utilidades
{
    public static class Backup
    {
        public static void GenerarBackup()
        {
            string carpeta = @"C:\Backups";
            try
            {
                
                if (!Directory.Exists(carpeta)) Directory.CreateDirectory(carpeta);

                string nombreArchivo = "PeluqueriaDB_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".bak";
                string rutaCompleta = Path.Combine(carpeta, nombreArchivo);

                string query = "BACKUP DATABASE [PeluqueriaElCojo] TO DISK = '" + rutaCompleta + "' WITH FORMAT, INIT;";

                using (SqlConnection conn = new SqlConnection(ConexionDB.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Backup exitoso guardado en:\n" + rutaCompleta, "Sistema Peluquería", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el backup. Asegúrese de ejecutar Visual Studio como Administrador.\nDetalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}