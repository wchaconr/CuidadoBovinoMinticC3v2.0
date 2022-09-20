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
    public class lista_propietarioModel : PageModel
            {
                private readonly I_Repo_Propietario repopropietario;

                public IEnumerable <Aper_propietario> Propietario {set;get;}
                public lista_propietarioModel()
                {
                    this.repopropietario=new Repo_Propietario(new PROGRAMA_BOVINO.persistencia.AppContext());
                }
                
                
                public void OnGet(string filtro)
                {
                    Propietario=repopropietario.GetAllPropietario();
                }
            }
        }