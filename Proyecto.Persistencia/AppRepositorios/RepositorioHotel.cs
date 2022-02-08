using System.Collections.Generic;
using Proyecto.Dominio;
using System.Linq;
using System;

namespace Proyecto.Persistencia.AppRepositorios
{
    
    public class RepositorioHotel
    {
        List<Hotel> Hoteles;
        
        public RepositorioHotel()
        {
            Hoteles= new List<Hotel>()  //Empezare creandolos por default para hacer pruebas
            {
                new Hotel{id =1, Capacidad = 8, Estado = "Disponible",Ciudad = "Barranquilla",Alojamientos= null}
                // new Hotel{id =2, Capacidad = 16, Estado = "Ocupado",Ciudad = "Cali",Precio = 900000}

            };
        }
        public IEnumerable<Hotel> GetAll()
        {
            return Hoteles;
        }
        public  Hotel GetHotelWithId(int id){
            return Hoteles.SingleOrDefault(b => b.id == id);
        }
    }
}