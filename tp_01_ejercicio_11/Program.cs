//Título: Trabajo Práctico 01 - Ejercicio 11
//Consigna: Dada una frase informar la cantidad de caracteres que tiene.
//Alumno: Nicolás Esteban Olmedo
using System;

namespace tp_01_ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                string fraseIngresada;
                int cantidadChars;

                //Input
                fraseIngresada = InputData();

                //Procesamiento
                cantidadChars = ConteoChars(fraseIngresada);

                //Output
                OutputData(cantidadChars);
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()

        private static string InputData()
        {
            //método usado para ingresar valores
            string _fraseIngresada;
            Console.Write("Ingresar una frase: ");
            _fraseIngresada = Console.ReadLine();
            return _fraseIngresada;
        }//fin del método InputData()

        private static int ConteoChars(string _fraseIngresada)
        {
            //método usado para contar los caracteres
            int _cantidadChars = 0;
            foreach (char _char in _fraseIngresada) 
            {
                _cantidadChars++;
            }//fin foreach
            return _cantidadChars;
        }//fin del método ConteoChars()

        private static void OutputData(int _cantidadChars)
        {
            //método usado para imprimir resultado
            Console.WriteLine("***");
            Console.WriteLine("Cantidad de chars ingresados: {0}", _cantidadChars);
            Console.WriteLine();
            Console.ReadKey();
        }//fin del método OutputData()
    }
}
