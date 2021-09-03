//Título: Trabajo Práctico 01 - Ejercicio 09
//Consgina: Dadas dos frases concatenarlas y mostrar el resultado.
//Alumno: Nicolás Esteban Olmedo

using System;

namespace tp_01_ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                string frase00, frase01, fraseResultado;

                //Input
                frase00 = InputData(1);
                frase01 = InputData(2);

                //Procesamiento
                fraseResultado = frase00 + frase01;

                //Output
                Console.WriteLine("***");
                Console.WriteLine("Frase resultado: {0}", fraseResultado);
                Console.WriteLine("***");
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()

        private static string InputData(int _valor)
        {
            string fraseIngresada;
            Console.Write("Ingresar frase {0}", _valor);
            fraseIngresada = Console.ReadLine();
            return fraseIngresada;
        }//fin del método InputData()
    }
}
