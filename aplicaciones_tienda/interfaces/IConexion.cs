using JO_APLICACION.entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace JO_APLICACION.interfaces
{
    public interface IConexion
    {
        DbSet<Productos>? Productos { get; set; }
        
        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
