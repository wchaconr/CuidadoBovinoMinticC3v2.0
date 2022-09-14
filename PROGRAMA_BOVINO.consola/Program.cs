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
        static void Main (string[] args)
        {
            Console.WriteLine("Hola Mundo");
            AdicionarVaca();
        }
        private static void AdicionarVaca()
        {
            var Vaca = new Aper_vaca()
            {
                
                Cod_Vaca      = 999,
                Nombre              = "Paloma",
                Color            = "Cafe",
                Raza           = "Braman",
                Edad            = "3",
                Propietario              = "Pedro",
                Veterinario              = "Carlos",
                Ubicacion                  = "Finca el trebol"


            };
            _Repo_Vacas.AddVaca(Vaca);
            
        }
            
}
}
