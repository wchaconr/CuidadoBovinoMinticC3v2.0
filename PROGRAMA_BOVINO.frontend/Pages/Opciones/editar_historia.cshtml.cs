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
    public class editar_historiaModel : PageModel
    {
        private readonly I_Repo_Historia_Clinica repohistoria;

        public editar_historiaModel()
        {
             this.repohistoria=new Repo_Historia_Clinica(new PROGRAMA_BOVINO.persistencia.AppContext());
        }
        [BindProperty]
        public Historia_Clinica Historia {get;set;}

        public IActionResult OnGet(int idhistoria)
                    {
                        Historia=repohistoria.GetHistoria(idhistoria);

                        if(Historia == null)
                        {
                            return RedirectToPage("lista_visitas");
                        }
                        else
                        {
                            return Page();
                        }

                    }
        public IActionResult OnPost()
        {
            Historia=repohistoria.UpdateHistoria(Historia);
            return RedirectToPage("lista_visitas");
        }
    }
}
