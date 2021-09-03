//Título: Trabajo Práctico 01 - Ejercicio 01
//Consigna: Dados dos valores ingresados por teclado mostrar la suma de ambos.
//Alumno: Nicolás Estban Olmedo

using System;

namespace tp_01_ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                int valor_00, valor_01, resultado;

                //Input
                valor_00 = InputData();
                valor_01 = InputData();

                //Procesamiento
                resultado = valor_00 + valor_01;

                //Output
                Console.WriteLine("***");
                Console.WriteLine("Resultado: " + resultado);
                Console.WriteLine("***");
                Console.ReadKey();
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()

        private static int InputData()
        {
            int _resultado;
            Console.Write("Ingresar un entero: ");
            _resultado = Convert.ToInt32(Console.ReadLine());
            return _resultado;
        } //fin del método InputData()
    }
}
