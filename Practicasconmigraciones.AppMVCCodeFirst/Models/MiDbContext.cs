using Microsoft.EntityFrameworkCore;

namespace Practicasconmigraciones.AppMVCCodeFirst.Models
{
    public class MiDbContext: DbContext
    {
        public MiDbContext(DbContextOptions<MiDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnoss { get; set; }
        public DbSet<Empleado> Empleados { get; set; }


    }
}
