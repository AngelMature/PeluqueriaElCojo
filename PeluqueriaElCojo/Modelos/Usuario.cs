namespace PeluqueriaElCojo.Modelos  //Añadir clase Usuario y Enums para control de privilegios y login
{
    public enum RolSistema { Administrador, Empleado }

    public class Usuario
    {
        public string Login { get; set; }
        private string Password;
        public RolSistema Rol { get; set; }

        public Usuario(string user, string pass, RolSistema rol)
        {
            this.Login = user;
            this.Password = pass;
            this.Rol = rol;
        }

        public bool ValidarPassword(string intento)
        {
            return this.Password == intento;
        }
    }
}