using System;
namespace Proyecto.Dominio{

    public class Hotel {

        public int id { get; set; }
        public int Capacidad {get;set;} // Por Habitacion
        public string Estado {get;set;}
        public string Ciudad {get;set;}
        public List<Alojamiento> Alojamientos {get;set;}
        
    }

}
