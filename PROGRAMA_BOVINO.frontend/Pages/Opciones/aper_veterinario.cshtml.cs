using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using PROGRAMA_BOVINO.persistencia;
using bovino.dominio;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace cuidadobovinominticc3.Pages
{
    public class aper_veterinarioModel : PageModel
    {
        private readonly I_Repo_Veterinario repoveterinario;

        public aper_veterinarioModel()
        {
             this.repoveterinario=new Repo_Veterinario(new PROGRAMA_BOVINO.persistencia.AppContext());
        }
        [BindProperty]
        public Aper_veterinario Veterinario {get;set;}

        public IActionResult OnPost()
        {
            repoveterinario.AddVeterinario(Veterinario);
            
            return Page();
        }

        public void OnGet()
        {
        }
    }
}

