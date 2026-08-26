namespace RRHHManager.Models
{
    public class Vacaciones
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
    }
}
