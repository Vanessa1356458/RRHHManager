using RRHHManager.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RRHHManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Puesto> Puestos { get; set; }
        public DbSet<Vacaciones> Vacaciones { get; set; }
        public DbSet<Constancia> Constancias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
    }
}
