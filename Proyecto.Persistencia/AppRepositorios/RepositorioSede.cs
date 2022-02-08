using System.Collections.Generic;
using Proyecto.Dominio;
using System.Linq;
using System;

namespace Proyecto.Persistencia.AppRepositorios
{
    public class RepositorioSede
    {
        List<Sede> Sedes;
        public RepositorioSede()
        {
            Sedes= new List<Sede>()  //Empezare creandolos por default para hacer pruebas
            {
                new Sede{id =1, Capacidad = 8, Estado = "Disponible",Ciudad = "Barranquilla",Precio =900000},
                // new Sede{id =2, Capacidad = 16, Estado = "Ocupado",Ciudad = "Cali",Precio = 900000}

            };
        }
        public IEnumerable<Sede> GetAll()
        {
            return Sedes;
        }
        public  Sede GetHotelWithId(int id){
            return Sedes.SingleOrDefault(b => b.id == id);
        }
    }
}