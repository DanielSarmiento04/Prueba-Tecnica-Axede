using System.Collections.Generic;
using Proyecto.Dominio;
using System.Linq;
using System;

namespace Proyecto.Persistencia.AppRepositorios
{
    public class RepositorioAlojamiento
    {
        List<Alojamiento> Alojamientos;
        public RepositorioAlojamiento()
        {
            Alojamientos = new List<Alojamiento>()  //Empezare creandolos por default para hacer pruebas
            {
                new Alojamiento{id =1, Capacidad = 8, Estado = "Disponible",Ciudad = "Barranquilla",Precio =900000,Tipo="Premium"},
                new Alojamiento{id =2, Capacidad = 16, Estado = "Ocupado",Ciudad = "Cali",Precio = 900000,Tipo = "Premium"}

            };
        }
        public IEnumerable<Alojamiento> GetAll()
        {
            return Alojamientos;
        }
        public  Alojamiento GetAlojamientoWithId(int id){
            return Alojamientos.SingleOrDefault(b => b.id == id);
        }
    }
}