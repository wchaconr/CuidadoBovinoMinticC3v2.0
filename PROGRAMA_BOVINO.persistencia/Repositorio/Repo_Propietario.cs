using bovino.dominio;
using System.Collections.Generic; 
using System.Linq;

namespace PROGRAMA_BOVINO.persistencia
{
    public class Repo_Propietario: I_Repo_Propietario
    {
        private readonly AppContext _appContext;
        public Repo_Propietario(AppContext appContext)
        {
            _appContext=appContext;
        }
        Aper_propietario I_Repo_Propietario.AddPropietario(Aper_propietario propietario)
        {
            var propietarioAdicionado= _appContext.Aper_Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }
        IEnumerable <Aper_propietario>I_Repo_Propietario.GetAllPropietario()
        {
            return _appContext.Aper_Propietarios;
        }
        void I_Repo_Propietario.DeletePropietario(int idPropietario)
        {
            var propietarioEncontrado=_appContext.Aper_Propietarios.FirstOrDefault(p=>p.Id==idPropietario);
           if(propietarioEncontrado==null)
           {
                return;
           }
            _appContext.Aper_Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
                }
        Aper_propietario I_Repo_Propietario.UpdatePropietario(Aper_propietario propietario){
            var propietarioEncontrado =_appContext.Aper_Propietarios.FirstOrDefault(p=>p.Id==propietario.Id);
            if(propietarioEncontrado!=null)
            {
                        propietarioEncontrado.Identificacion=propietario.Identificacion;
                        propietarioEncontrado.Nombre=propietario.Nombre;
                        propietarioEncontrado.Apellido=propietario.Apellido;
                        propietarioEncontrado.Direccion=propietario.Direccion;
                        propietarioEncontrado.Telefono=propietario.Telefono;
                        propietarioEncontrado.E_mail=propietario.E_mail;
                        propietarioEncontrado.Genero=propietario.Genero;
                        propietarioEncontrado.Nombre_Hacienda=propietario.Nombre_Hacienda;
                        _appContext.SaveChanges();
                    }
                    return propietarioEncontrado;
                }
                Aper_propietario I_Repo_Propietario.GetPropietario(int IdPropietario)
                {
                    return _appContext.Aper_Propietarios.FirstOrDefault(p=>p.Id==IdPropietario);
                }
            }
        }