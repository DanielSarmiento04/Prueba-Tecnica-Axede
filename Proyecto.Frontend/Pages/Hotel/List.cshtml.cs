using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto.Persistencia.AppRepositorios;
using Proyecto.Dominio;

namespace Proyecto.Frontend.Pages
{
    
    public class ListHotelModel : PageModel
    {
        private readonly RepositorioHotel repositorioHotel;
        public IEnumerable < Proyecto.Dominio.Hotel> Hoteles {get;set;}
        public ListHotelModel(RepositorioHotel repositorioHotel)
        {
            this.repositorioHotel = repositorioHotel;
            
        }
        public void OnGet()
        {
            Hoteles = repositorioHotel.GetAll();
        }
    }
}
