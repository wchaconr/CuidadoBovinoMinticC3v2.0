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
    public class lista_visitasModel : PageModel
    {
                private readonly I_Repo_Historia_Clinica repohistoria;

                public IEnumerable <Historia_Clinica> Historia {set;get;}
                public lista_visitasModel()
                {
                    this.repohistoria=new Repo_Historia_Clinica(new PROGRAMA_BOVINO.persistencia.AppContext());
                }
                
                
                public void OnGet(string filtro)
                {
                    Historia=repohistoria.GetAllHistoria();
                }
            }
        }

