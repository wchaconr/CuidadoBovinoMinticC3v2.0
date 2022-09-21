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
    public class aper_vacasModel : PageModel
    {
        
        
        private readonly I_Repo_Vacas repovacas;

        public aper_vacasModel()
        {
             this.repovacas=new Rep_Vacas(new PROGRAMA_BOVINO.persistencia.AppContext());
        }
        [BindProperty]
        public Aper_vaca Vaca {get;set;}

        public IActionResult OnPost()
        {
            repovacas.AddVaca(Vaca);
            
            return RedirectToPage("lista_vacas");
        }
        

        public void OnGet()
        {
        }
    }
}

