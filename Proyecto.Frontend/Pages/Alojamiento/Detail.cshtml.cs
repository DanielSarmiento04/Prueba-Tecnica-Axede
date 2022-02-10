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
    public class DetailAlojamientoModel : PageModel
    {
        private readonly RepositorioAlojamiento repositorioAlojamiento;
        public Proyecto.Dominio.Alojamiento Alojamiento {get;set;}
        public DetailAlojamientoModel(RepositorioAlojamiento repositorioAlojamiento)
        {
            this.repositorioAlojamiento = repositorioAlojamiento;
        }
        public IActionResult OnGet(int AlojamientoId)
        {
            Alojamiento = repositorioAlojamiento.GetAlojamientoWithId(AlojamientoId);
            return Page();
        }
    }
}