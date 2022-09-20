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
    public class visitasModel : PageModel
    {
        private readonly I_Repo_Historia_Clinica repo_Historia_Clinica;

        public visitasModel()
        {
             this.repo_Historia_Clinica=new Repo_Historia_Clinica(new PROGRAMA_BOVINO.persistencia.AppContext());
        }
        [BindProperty]
        public Historia_Clinica Historia {get;set;}

        public IActionResult OnPost()
        {
            repo_Historia_Clinica.AddHistoria(Historia);
            
            return Page();
        }

        public void OnGet()
        {
        }
    }
}
       
