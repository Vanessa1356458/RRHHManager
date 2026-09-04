namespace RRHHManager.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Identidad { get; set; }
        public string Correo { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public DateTime FechaNacimiento { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime FechaSalida { get; set; }

        public int PuestoId { get; set; }
        public EstadoEmpleado Estado { get; set; } = EstadoEmpleado.Activo;

        public ICollection<HistorialLaboral> HistorialLaborales { get; set; } = new List<HistorialLaboral>();

        public ICollection<HistorialSalarial> HistorialSalariales { get; set; } = new List<HistorialSalarial>();
        public ICollection<Vacaciones> Vacaciones { get; set; }
        public ICollection<Constancia> Constancias { get; set; }
        public Usuario Usuario { get; set; }
    }
}
