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
    public class eliminar_vacaModel : PageModel
    {
        private readonly I_Repo_Vacas repovacas;

        public eliminar_vacaModel()
        {
             this.repovacas=new Rep_Vacas(new PROGRAMA_BOVINO.persistencia.AppContext());
        }
        [BindProperty]
        public Aper_vaca Vaca {set;get;}

        public IActionResult OnGet(int idvaca)
                    {
                        Vaca=repovacas.GetVaca(idvaca);

                        if(Vaca == null)
                        {
                            return RedirectToPage("lista_vacas");
                        }
                        else
                        {
                            return Page();
                        }

                    }

        public IActionResult OnPost()
        {
         repovacas.DeleteVaca(Vaca.id);
         return RedirectToPage("lista_vacas");
        }
    }
}