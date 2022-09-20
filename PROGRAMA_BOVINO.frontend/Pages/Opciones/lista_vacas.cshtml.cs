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
    public class lista_vacasModel : PageModel
    {
        private readonly I_Repo_Vacas repovacas ;

        public IEnumerable<Aper_vaca> Vaca { set; get; }
        public lista_vacasModel()
        {
            this.repovacas = new Rep_Vacas( new PROGRAMA_BOVINO.persistencia.AppContext());
            
        }

        

        public void OnGet(string filtro)
        {
            
            Vaca = repovacas.GetAllVaca();
            
        }
    }
}
