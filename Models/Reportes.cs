namespace RRHHManager.Models
{
    public class Reportes
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Modulo { get; set; } // a qué módulo pertenece: Empleados, Vacaciones, Salarios, etc.

        public bool DisponibleExcel { get; set; } = true;
        public bool DisponiblePdf { get; set; } = true;
    }
}
