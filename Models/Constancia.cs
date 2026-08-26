namespace RRHHManager.Models
{
    public class Constancia
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public DateTime FechaGeneracion { get; set; } = DateTime.Now;
        public string Tipo { get; set; }
        public string Contenido { get; set; }
    }
}
