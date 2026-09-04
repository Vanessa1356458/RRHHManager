namespace RRHHManager.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}
