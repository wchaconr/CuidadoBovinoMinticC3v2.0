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
    public class ver_historiaModel : PageModel
    {
                private readonly I_Repo_Historia_Clinica repohistoria;



                public Historia_Clinica Historia {set;get;}
                public ver_historiaModel()
                {
                    this.repohistoria=new Repo_Historia_Clinica(new PROGRAMA_BOVINO.persistencia.AppContext());
                }
                
                public IActionResult OnGet(int Id_Historia)
                
                {
                    Historia=repohistoria.GetHistoria(Id_Historia);

                    if(Historia == null)
                    {
                        return RedirectToPage("./NoFound");
                    }
                    else
                    {
                        return Page();
                    }
                }
            }
        }
