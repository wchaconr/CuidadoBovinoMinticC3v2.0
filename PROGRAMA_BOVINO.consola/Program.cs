// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using PROGRAMA_BOVINO.persistencia;
using bovino.dominio;
namespace PROGRAMA_BOVINO.consola
{
    class Programa 
    {
       
       

       private static I_Repo_Historia_Clinica _Repo_Historia_Clinica = new Repo_Historia_Clinica (new persistencia.AppContext());
        static void Main (string[] args)
        {
            Console.WriteLine("Hola Mundo");
            AdicionarHistoria();
            //buscarvaca(5);
        }
       private static void AdicionarHistoria()
        {
            var Historia = new Historia_Clinica()
            {
                
                Id_Historia                 = 001,
                Fecha_Visita                = "15-09-2022",
                Id_Vaca                     = 1,
                Id_Veterinario              = 10,
                Temperatura                 = 60.2,
                Peso                        = 560.23,
                Frecuencia_Respiratoria     = 90,
                Frecuencia_Cardiaca         = 70,
                Estado_Animo                = "Optimo",
                Diagnostico                 = "El Bovino despies de los analisis realizados se encuentra en perfectas condiciones",
                Recomendaciones             = "Ninguno",
                Medicamentos                = "Ninguno"



            };
            _Repo_Historia_Clinica.AddHistoria(Historia);
            
        }
            
}
}
