namespace RRHHManager.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public int RolId { get; set; }
        public Roles Rol { get; set; }
    }
}
