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
            //buscarvaca(5);
        }
        private static void AdicionarVaca()
        {
            var Vaca = new Aper_vaca()
            {
                
                Cod_Vaca      = "10",
                Nombre              = "Manchitas",
                Color            = "Manchado",
                Raza           = "Brahman",
                Edad            = "3",
                Propietario              = "Andres Felipe Lopez Moreno",
                Veterinario              = "Martha Lucia Garcia Moreno",
                Ubicacion                  = "Finca la Estrella"


            };
            _Repo_Vacas.AddVaca(Vaca);
            
        }
    }
}
