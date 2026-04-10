using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Utilidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PeluqueriaElCojo.Datos
{
    public class ClienteDatos
    {
        private ConexionDB conexion = new ConexionDB();

        public void Insertar(Cliente cliente)
        {
            string query = "INSERT INTO Clientes (Nombre, Telefono, TipoCliente, Visitas) VALUES (@nom, @tel, @tipo, @vis)";
            SqlCommand cmd = new SqlCommand(query, conexion.leerConexion);
            cmd.Parameters.AddWithValue("@nom", cliente.Nombre);
            cmd.Parameters.AddWithValue("@tel", cliente.Telefono);
            cmd.Parameters.AddWithValue("@tipo", cliente.Tipo.ToString());
            cmd.Parameters.AddWithValue("@vis", cliente.Visitas);

            conexion.Abrir();
            cmd.ExecuteNonQuery();
            conexion.Cerrar();
        }

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            string query = "SELECT Nombre, Telefono FROM Clientes";
            SqlCommand cmd = new SqlCommand(query, conexion.leerConexion);

            conexion.Abrir();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Cliente(reader["Nombre"].ToString(), reader["Telefono"].ToString()));
            }
            conexion.Cerrar();
            return lista;
        }
    }
}