//Título: Trabajo Práctico 01 - Ejercicio 02
//Consigna: Desarrollar una aplicación de consola que tomando 2 números informe cuantos números hay entre los dos.
//Alumno: Nicolás Esteban Olmedo
using System;

namespace tp_01_ejercicio_02
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
                resultado = Comparacion(valor_00, valor_01);

                //Output
                Console.WriteLine("***");
                Console.WriteLine("Diferencia entre números: " + resultado);
                Console.WriteLine("***");
                Console.ReadKey();
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()

        private static int InputData()
        {
            //método usado para ingresar valores
            int _resultado;
            Console.Write("Ingresar un entero: ");
            _resultado = Convert.ToInt32(Console.ReadLine());
            return _resultado;
        } //fin del método InputData()

        private static int Comparacion(int valorA, int valorB)
        {
            //método usado para comparar los dos valores ingresados
            int _resultado;
            if (valorA > valorB)
                _resultado = valorA - valorB;
            else
                _resultado = valorB - valorA;
            return _resultado;
        } //fin del método Comparación()
    }
}
