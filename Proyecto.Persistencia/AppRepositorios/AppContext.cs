using Microsoft.EntityFrameworkCore;
using Proyecto.Dominio;


namespace Proyecto.Persistencia
{
    public class AppContext: DbContext{
    
    public DbSet<Hotel>? Hoteles {get;set;}
    public DbSet<Sede>? Sedes {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (local db)\\MSSQLLocalDB; Initial Catalog = Proyecto");
            }
        }
    }
}