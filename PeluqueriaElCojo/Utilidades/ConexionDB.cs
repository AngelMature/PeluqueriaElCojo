using System;
using System.Data.SqlClient;

namespace PeluqueriaElCojo.Utilidades
{
    public class ConexionDB
    {
        private string cadena = "Server=.; Database=PeluqueriaElCojo; Integrated Security=True; TrustServerCertificate=True;";
        public SqlConnection leerConexion = new SqlConnection();

        public ConexionDB()
        {
            leerConexion.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                if (leerConexion.State == System.Data.ConnectionState.Closed)
                {
                    leerConexion.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Cerrar()
        {
            if (leerConexion.State == System.Data.ConnectionState.Open)
            {
                leerConexion.Close();
            }
        }
    }
}