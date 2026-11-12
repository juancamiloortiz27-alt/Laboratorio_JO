using JO_APLICACION.entidades;
using JO_APLICACION.interfaces;
using JO_APLICACION.nucleo;
using Microsoft.EntityFrameworkCore;

namespace JO_APLICACION.implementaciones
{
    public class Conexion : DbContext, IConexion
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatosGenerales.StringConexion()!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Productos>? Productos { get; set; }
    }
}
