using System;
namespace Proyecto.Dominio{

    public class Sede {
        public int id { get; set; }
        public List<Hotel> ?Hoteles { get; set; }
        public int CapacidadPersonas {get;set;}
        public int NumHabPremium {get;set;}
        public int NumHabVip {get;set;}
        public int NumHabStandard {get;set;}
        public string Ciudad {get;set;}
        public int precio {get;set;}
    }
}