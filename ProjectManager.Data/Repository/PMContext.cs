using Microsoft.EntityFrameworkCore;

namespace ProjectManager.Data.Context
{
    public class PMContext : DbContext
    {
        public PMContext(DbContextOptions<PMContext> options) : base(options)
        {

        }

        public PMContext()
        {

        }



        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Proyecto> Proyecto { get; set; }
        public virtual DbSet<Tarea> Tarea { get; set; }
    }
}



