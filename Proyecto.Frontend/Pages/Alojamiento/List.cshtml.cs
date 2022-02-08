using System;
using Proyecto.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto.Persistencia.AppRepositorios;


namespace Proyecto.Frontend.Pages
{
    public class ListAlojamientosModel : PageModel
    {
        private readonly RepositorioAlojamiento repositorioAlojamiento;
        // public IEnumerable<Alojamiento> Alojamientos2 {get;set;}
        public ListAlojamientosModel(RepositorioAlojamiento repositorioAlojamiento)
        {
            this.repositorioAlojamiento = repositorioAlojamiento;
        }
        public void OnGet()
        {
            // Alojamientos2 = repositorioAlojamiento.GetAll();
        }
    }
}
