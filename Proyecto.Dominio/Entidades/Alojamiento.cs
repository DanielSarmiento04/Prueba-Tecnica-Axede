using System;
namespace Proyecto.Dominio{

    public class Alojamiento {

        public int id { get; set; }
        public int Capacidad {get;set;}// Por Habitacion
        public string Estado {get;set;}  //Si el estado Es disponible la Fecha de Cierre y Inicio no se incluyen
        public string Ciudad {get;set;}
        public int Precio {get;set;}  
        public string Tipo {get;set;}   //Vip -Standard
        public string? FechaCierre { get; set; } //Establecer cuando va estar hospedado
        public string? FechaInicio { get; set; } 

    }

}