//Títutlo: Trabajo Práctico 01 - Ejercicio 15
//Consigna: Informar cuantos días faltan para el 25/12/2020. ***Update*** Usé 25/12/2021
//Alumno: Nicolás Esteban Olmedo
using System;

namespace tp_01_ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                DateTime fechaFijada = DateTime.ParseExact("25/12/2021", "dd/MM/yyyy", null);
                DateTime fechaActual = DateTime.Now;
                TimeSpan diferenciaFechas;

                //Input
                //Procesamiento
                diferenciaFechas = fechaFijada - fechaActual;

                //Output
                Console.WriteLine("***");
                Console.WriteLine("Diferencia de días: {0}", diferenciaFechas.Days);
                Console.WriteLine("***");
                Console.ReadKey();
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()
    }
}
