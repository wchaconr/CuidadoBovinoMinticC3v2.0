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
            public class lista_veterinarioModel : PageModel
            {
                private readonly I_Repo_Veterinario repoveterinario;

                public IEnumerable <Aper_veterinario> Veterinario {set;get;}
                public lista_veterinarioModel()
                {
                    this.repoveterinario=new Repo_Veterinario(new PROGRAMA_BOVINO.persistencia.AppContext());
                }
                
                
                public void OnGet(string filtro)
                {
                    Veterinario=repoveterinario.GetAllVeterinario();
                }
            }
        }

