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
    public class eliminar_veterinarioModel : PageModel
    {
       private readonly I_Repo_Veterinario repoveterinario;

        public eliminar_veterinarioModel()
        {
            this.repoveterinario=new Repo_Veterinario(new PROGRAMA_BOVINO.persistencia.AppContext());
        }
        [BindProperty]

        public Aper_veterinario Veterinario {get;set;}

        public IActionResult OnGet(int idveterinario)
                    {
                        Veterinario=repoveterinario.GetVeterinario(idveterinario);

                        if(Veterinario == null)
                        {
                            return RedirectToPage("aper_veterinario");
                        }
                        else
                        {
                            return Page();
                        }

                    }
        public IActionResult OnPost()
        {
         repoveterinario.DeleteVeterinario(Veterinario.Id);
         return RedirectToPage("lista_veterinario");
        }
    }
}