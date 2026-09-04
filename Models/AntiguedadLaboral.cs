namespace RRHHManager.Models
{
    public class AntiguedadLaboral
    {
        public int Id { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        public DateTime FechaIngreso { get; set; }
        public DateTime FechaCalculo { get; set; } = DateTime.Now;

        public int Anios { get; set; }
        public int Meses { get; set; }
        public int Dias { get; set; }
    }
}
