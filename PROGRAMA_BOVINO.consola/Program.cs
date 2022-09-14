// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using PROGRAMA_BOVINO.persistencia;
using bovino.dominio;
namespace PROGRAMA_BOVINO.consola
{
    class Programa 
    {
        private static I_Repo_Propietario _Repo_Propietario = new Repo_Propietario (new persistencia.AppContext());
        static void Main (string[] args)
        {
            Console.WriteLine("Hola Mundo");
            AdicionarPropietario();
        }
        private static void AdicionarPropietario()
        {
            var Propietario = new Aper_propietario()
            {
                
                Identificacion      = 123456,
                Nombre              = "Pedro",
                Apellido            = "Romero",
                Direccion           = "Cra 69C # 3 14",
                Telefono            = "3123824288",
                E_mail              = "freddy.vasquez.c@hotmail.com",
                Genero              = "Masculino",
                Id_Propietario      = 1,
                Nombre_Hacienda     = "Las Palmas"


            };
            _Repo_Propietario.AddPropietario(Propietario);
            
        }
            
}
}
