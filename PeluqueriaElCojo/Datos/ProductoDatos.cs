using System;
using System.Data;
using System.Data.SqlClient;
using PeluqueriaElCojo.Utilidades;

namespace PeluqueriaElCojo.Datos
{
    public class ProductoDatos
    {
        public bool ActualizarStockEnDB(string productoId, int cantidad)
        {
            string query = "UPDATE Productos SET CantidadStock = CantidadStock - @can WHERE ProductoID = @id AND CantidadStock >= @can";
            using (SqlConnection conn = new SqlConnection(ConexionDB.ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", productoId);
                    cmd.Parameters.AddWithValue("@can", cantidad);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        public DataTable ObtenerRankingReal()
        {
            DataTable dt = new DataTable();
            string query = "SELECT Nombre, TotalVentas FROM Barberos ORDER BY TotalVentas DESC";
            using (SqlConnection conn = new SqlConnection(ConexionDB.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}