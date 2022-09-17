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
    public class ver_vacaModel : PageModel
    {
        private readonly I_Repo_Vacas repovacas;

        public Aper_vaca verVaca { set; get; }
        public ver_vacaModel()
        {
            this.repovacas = new Rep_Vacas(new PROGRAMA_BOVINO.persistencia.AppContext());
        }

        

        public IActionResult OnGet(int IdVaca)

        {
            verVaca = repovacas.GetVaca(IdVaca);

            if (verVaca == null)
            {
                return RedirectToPage("inicio");
            }
            else
            {
                return Page();
            }
        }
    }
}

