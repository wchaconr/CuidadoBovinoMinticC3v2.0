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
    public class editar_propietarioModel : PageModel
    {
        private readonly I_Repo_Propietario repopropietario;

        public editar_propietarioModel()
        {
             this.repopropietario=new Repo_Propietario(new PROGRAMA_BOVINO.persistencia.AppContext());
        }
        [BindProperty]
        public Aper_propietario Propietario {get;set;}

        public IActionResult OnGet(int idpropietario)
                    {
                        Propietario=repopropietario.GetPropietario(idpropietario);

                        if(Propietario == null)
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
            Propietario=repopropietario.UpdatePropietario(Propietario);
            return RedirectToPage("lista_propietario");
        }
    }
}
