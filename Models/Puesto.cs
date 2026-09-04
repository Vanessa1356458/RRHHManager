namespace RRHHManager.Models
{
    public class Puesto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}
