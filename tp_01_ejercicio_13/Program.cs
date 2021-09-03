//Título: Trabajo Práctico 01 - Ejercicio 13
//Consigna: Dada una fecha mostrarla en el formato AAAAMMDD.
//Alumno: Nicolás Esteban Olmedo
using System;

namespace tp_01_ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                //DateTime dateTime = DateTime.Now;
                string datePattern = "dd/MM/yyyy";
                
                //Input
                Console.Write("Ingresar una fecha en formato dd/mm/yyyy: ");
                DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), datePattern, null);

                //Procesamiento
                //Output
                Console.WriteLine("***");
                Console.WriteLine("Fecha: {0}", dateTime.ToString("yyyyMMdd"));
                Console.WriteLine("***");
                Console.ReadKey();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()
    }
}
