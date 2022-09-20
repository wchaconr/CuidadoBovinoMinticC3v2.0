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
    public class editar_vacaModel : PageModel
    {
        private readonly I_Repo_Vacas repovacas;

        public editar_vacaModel()
        {
             this.repovacas=new Rep_Vacas(new PROGRAMA_BOVINO.persistencia.AppContext());
        }
        [BindProperty]
        public Aper_vaca Vaca {get;set;}

        public IActionResult OnGet(int idvaca)
                    {
                        Vaca=repovacas.GetVaca(idvaca);

                        if(Vaca == null)
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
            Vaca=repovacas.UpdateVaca(Vaca);
            return RedirectToPage("lista_vacas");
        }
    }
}
