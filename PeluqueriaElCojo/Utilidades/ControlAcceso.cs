using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;

namespace PeluqueriaElCojo.Utilidades
{
    public static class ControlAcceso
    {
        public static string GenerarHash(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static void AplicarPrivilegios(Form formulario, RolSistema rol)
        {
          
            if (rol == RolSistema.Empleado)
            {
               
                if (formulario.Controls["btnInventario"] != null)
                    formulario.Controls["btnInventario"].Enabled = false;

                if (formulario.Controls["btnReportes"] != null)
                    formulario.Controls["btnReportes"].Visible = false;
            }
        }
    }
}