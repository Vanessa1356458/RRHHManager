namespace RRHHManager.Models
{
    public class ExpedientesDigitales
    {
        public int Id { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        public TipoDocumento TipoDocumento { get; set; }
        public string NombreArchivo { get; set; }
        public string RutaArchivo { get; set; }

        public DateTime FechaCarga { get; set; } = DateTime.Now;
        public string CargadoPor { get; set; }

        public bool Eliminado { get; set; } = false;
    }
    public enum TipoDocumento
    {
        Curriculum,
        Contrato,
        Identidad,
        Diplomas,
        Constancias,
        Evaluaciones,
        Incapacidades,
        Otros
    }
}
