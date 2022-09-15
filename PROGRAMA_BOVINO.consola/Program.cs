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
                
                Cod_Vaca      = "888",
                Nombre              = "Paloma",
                Color            = "Cafe",
                Raza           = "Brahman",
                Edad            = "4",
                Propietario              = "Pedro",
                Veterinario              = "Carlos",
                Ubicacion                  = "Finca el trebol"


            };
            _Repo_Vacas.AddVaca(Vaca);
            
        }
        //private static void buscarvaca(int idVaca)
        //{
          //  var Vaca= _Repo_Vacas.GetVaca(idVaca);
            //Console.WriteLine(Vaca.Nombre);
       // }
            
}
}
