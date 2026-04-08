using PeluqueriaElCojo.Atributos;
using PeluqueriaElCojo.Utilidades;

namespace PeluqueriaElCojo.Modelos
{
    public enum RolSistema { Administrador, Empleado, Cajero }

    public class Usuario
    {
        [Requerido("El nombre de usuario es obligatorio")]
        public string Login { get; set; }

        [Requerido("La contraseña es obligatoria")]
        public string ContraseñaHash { get; set; }

        public RolSistema Rol { get; set; }

        public Usuario() { }

        public Usuario(string user, string pass, RolSistema rol)
        {
            this.Login = user;
            this.ContraseñaHash = ControlAcceso.GenerarHash(pass);
            this.Rol = rol;
        }

        public bool ValidarPassword(string intento)
        {
            return this.ContraseñaHash == ControlAcceso.GenerarHash(intento);
        }
    }
}