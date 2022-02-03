using Microsoft.EntityFrameworkCore;
using Proyecto.Dominio;


namespace Proyecto.Persistencia
{
    public class AppContext: DbContext{
    
    public DbSet<Hotel>? Hoteles {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("El url para Sql Server");
            }
        }
    }
}