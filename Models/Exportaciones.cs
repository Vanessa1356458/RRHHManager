namespace RRHHManager.Models
{
    public class Exportaciones
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public string NombreReporte { get; set; }
        public FormatoExportaciones Formato { get; set; }

        public DateTime FechaExportacion { get; set; } = DateTime.Now;
        public string RutaArchivo { get; set; }
    }
    public enum FormatoExportaciones
    {
        Excel,
        PDF
    }

}
