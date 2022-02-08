using System;
namespace Proyecto.Dominio{

    public class Alojamiento {

        public int id { get; set; }
        public int Capacidad {get;set;}// Por Habitacion
        public string Estado {get;set;}
        public string Ciudad {get;set;}
        public int Precio {get;set;}  
        public string Tipo {get;set;}   //Vip -Standard

    }

}