namespace RRHHManager.Models
{
    public class Permisos
    {
        public int Id { get; set; }

        public int RolId { get; set; }
        public Roles Rol { get; set; }

        public string Modulo { get; set; } // ej: "Empleados", "Vacaciones", "Reportes"

        public bool PuedeVer { get; set; }
        public bool PuedeCrear { get; set; }
        public bool PuedeEditar { get; set; }
        public bool PuedeEliminar { get; set; }
    }
}
