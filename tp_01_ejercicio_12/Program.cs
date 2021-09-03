//Título: Trabajo Práctico 01 - Ejercicio 12
//Consigna: Mostrar la fecha y hora actual.
//Alumno: Nicolás Esteban Olmedo
using System;

namespace tp_01_ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                DateTime dateTime = DateTime.Now;

                //Input
                //Procesamiento
                //Output
                Console.WriteLine("***");
                Console.WriteLine("Fecha: {0}\nHora: {1}", dateTime.ToString("dd MMMM, yyyy"), dateTime.ToString("hh:mm:ss"));
                Console.WriteLine("***");
                Console.ReadKey();
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }
    }//fin del método Main()
}
