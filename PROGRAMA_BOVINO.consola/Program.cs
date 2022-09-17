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
                
                Id_Historia                 = 002,
                Fecha_Visita                = "16-09-2022",
                Id_Vaca                     = 2,
                Id_Veterinario              = 11,
                Temperatura                 = 68.2,
                Peso                        = 660.88,
                Frecuencia_Respiratoria     = 98,
                Frecuencia_Cardiaca         = 85,
                Estado_Animo                = "Bajo",
                Diagnostico                 = "El Bovino presenta Leptospirosis Es una enfermedad infecciosa que está muy difundida a nivel mundial y que en bovinos se caracteriza por causar trastornos reproductivos como aborto, nacimiento de crías débiles, crías que nacen muertas e infertilidad. v Rinotraqueitis Infecciosa Bovina (IBR) La rinotraqueitis infecciosa bovina es una enfermedad contagiosa, causada por un virus, caracterizada por producir trastornos en vías respiratorias superiores, además de problemas reproductivos como el aborto que se presenta después de una enfermedad respiratoria leve y frecuentemente en el último tercio de la gestación.",
                Recomendaciones             = "Recomendaciones para prevención de enfermedades Para mantener el hato en buenas condiciones sanitarias es muy importante contar con un programa de diagnóstico de enfermedades para su prevención y control. Adicionalmente, deben adoptarse prácticas de higiene y desinfección de equipo e instalaciones, así como mantener en cuarentena a los animales enfermos y los que vayan a ingresar a la explotación. El manejo de vacunas ayuda a controlar las enfermedades. Los principales cuidados son: v Vacunas  Las vacunas deben mantenerse entre los 4°C y 7°C · Desechar frascos con sobrantes · Utilizar agujas limpias y de preferencia una por animal · Aplicar vacunas que protejan, de preferencia, contra dos o tres enfermedades · Aplicar la dosis y vía de administración indicadas por el laboratorio.",
                Medicamentos                = "Calcio Oral Veterinario Remineralizante y Reconstituyente, Calcio Oral Veterinario Remineralizante y Reconstituyente. Gluconato de Calcio Calcio. "



            };
            _Repo_Historia_Clinica.AddHistoria(Historia);
            
        }
            
}
}
