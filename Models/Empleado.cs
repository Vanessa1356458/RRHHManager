namespace RRHHManager.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaIngreso { get; set; }

        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }

        public int PuestoId { get; set; }
        public Puesto Puesto { get; set; }

        public ICollection<Vacaciones> Vacaciones { get; set; }
        public ICollection<Constancia> Constancias { get; set; }
        public Usuario Usuario { get; set; }
    }
}
