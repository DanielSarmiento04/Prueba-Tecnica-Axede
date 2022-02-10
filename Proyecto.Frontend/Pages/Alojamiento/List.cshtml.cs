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
    public class ListAlojamientoModel : PageModel
    {
        private readonly RepositorioAlojamiento repositorioAlojamiento;
        public IEnumerable < Proyecto.Dominio.Alojamiento> Alojamientos {get;set;}

        public ListAlojamientoModel(RepositorioAlojamiento repositorioAlojamiento)
        {
            this.repositorioAlojamiento = repositorioAlojamiento;
        }
        public void OnGet()
        {
            Alojamientos = repositorioAlojamiento.GetAll();
        }
    }
}