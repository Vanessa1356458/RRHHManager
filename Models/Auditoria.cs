namespace RRHHManager.Models
{
    public class Auditoria
    {
        public int Id { get; set; }

        public string Usuario { get; set; } = string.Empty;

        public string Modulo { get; set; } = string.Empty;

        public string Accion { get; set; } = string.Empty;

        public string? ValorAnterior { get; set; }

        public string? ValorNuevo { get; set; }

        public DateTime Fecha { get; set; }
    }
}
