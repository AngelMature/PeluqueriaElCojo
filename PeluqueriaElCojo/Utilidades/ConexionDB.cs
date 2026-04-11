using System;
using System.Data;
using System.Data.SqlClient;

namespace PeluqueriaElCojo.Utilidades
{
    public class ConexionDB
    {
        
        public static string ConnectionString = "Server=.; Database=PeluqueriaElCojo; Integrated Security=True; TrustServerCertificate=True;";

        public SqlConnection leerConexion = new SqlConnection(ConnectionString);

        public void Abrir()
        {
            if (leerConexion.State == ConnectionState.Closed) leerConexion.Open();
        }

        public void Cerrar()
        {
            if (leerConexion.State == ConnectionState.Open) leerConexion.Close();
        }
    }
}