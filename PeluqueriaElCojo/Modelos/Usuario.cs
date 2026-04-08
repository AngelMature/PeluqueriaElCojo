using PeluqueriaElCojo.Atributos;
using PeluqueriaElCojo.Utilidades;

namespace PeluqueriaElCojo.Modelos
{
    // He movido el Enum a un archivo separado o fuera si prefieres, 
    // pero añadiendo "Cajero" para tener más niveles de privilegios.
    public enum RolSistema { Administrador, Empleado, Cajero }

    public class Usuario
    {
        [Requerido]
        public string Login { get; set; }

        // Cambiamos a ContraseñaHash para cumplir con el requisito de seguridad
        [Requerido]
        public string ContraseñaHash { get; set; }

        public RolSistema Rol { get; set; }

        // Constructor vacío necesario para Serialización (Backup XML)
        public Usuario() { }

        public Usuario(string user, string pass, RolSistema rol)
        {
            this.Login = user;
            // Guardamos el hash, nunca el texto plano
            this.ContraseñaHash = ControlAcceso.GenerarHash(pass);
            this.Rol = rol;
        }

        public bool ValidarPassword(string intento)
        {
            // Comparamos el hash del intento con el hash guardado
            return this.ContraseñaHash == ControlAcceso.GenerarHash(intento);
        }
    }
}