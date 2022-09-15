// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using PROGRAMA_BOVINO.persistencia;
using bovino.dominio;
namespace PROGRAMA_BOVINO.consola
{
    class Programa 
    {
        private static I_Repo_Vacas _Repo_Vacas = new Rep_Vacas (new persistencia.AppContext());
        private static I_Repo_Propietario _Repo_Propietario = new Repo_Propietario (new persistencia.AppContext());
        static void Main (string[] args)
        {
            Console.WriteLine("Hola Mundo propietario");
            //AdicionarVaca();
            AdicionarPropietario();
            
        }
        private static void AdicionarVaca()
        {
            var Vaca = new Aper_vaca()
            {
                
                Cod_Vaca      = "777",
                Nombre              = "Lupe",
                Color            = "Gris",
                Raza           = "Brahman",
                Edad            = "2",
                Propietario              = "Jonathan Val",
                Veterinario              = "Santiago",
                Ubicacion                  = "Finca el paraiso"


            };
            _Repo_Vacas.AddVaca(Vaca);
            
        }
        private static void AdicionarPropietario()
        {
            var Propietario = new Aper_propietario()
            {
                
                Identificacion      = 102236522,
                Nombre              = "Juan C",
                Apellido            = "Perez",
                Direccion           = "kilometro 9 chia-bog",
                Telefono            = "313526402",
                E_mail              = "JuanC@correo.com",
                Genero              = "Masculino",
                Id_Propietario      = 999,
                Nombre_Hacienda     = "Finca el paraiso"


            };
            _Repo_Propietario.AddPropietario(Propietario);
            
        }
        //private static void buscarvaca(int idVaca)
        //{
          //  var Vaca= _Repo_Vacas.GetVaca(idVaca);
            //Console.WriteLine(Vaca.Nombre);
       // }
            
}
}
