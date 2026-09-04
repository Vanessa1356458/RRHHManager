namespace RRHHManager.Models
{
    public class HistorialSalarial
    {
        public int Id { get; set; }

        public int EmpleadoId { get; set; }

        public Empleado? Empleado { get; set; }

        public decimal SalarioAnterior { get; set; }

        public decimal SalarioNuevo { get; set; }

        public decimal PorcentajeAumento { get; set; }

        public DateTime FechaCambio { get; set; }

        public string Motivo { get; set; } = string.Empty;
    }
}
