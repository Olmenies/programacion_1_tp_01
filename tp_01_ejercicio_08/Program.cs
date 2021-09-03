//Título: Trabajo Práctico 01 - Ejercicio 08
//Consigna: Calcular el factorial de 6.
//Alumno: Nicolás Esteban Olmedo

/*
 * 6! = 1*2*3*4*5*6
 */

using System;

namespace tp_01_ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                int resultadoFactorial, resultado, valor = 6;

                //Input
                valor = InputData();

                //Procesamiento
                resultadoFactorial = CalculoFactorialRecursivo(valor);
                resultado = CalculoFactorial(valor);

                //Output
                ImprimirResultado(resultado, resultadoFactorial);

            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()

        private static int InputData()
        {
            //método usado para ingresar valore
            int valorIngresado;
            Console.Write("Calcular factorial de: ");
            valorIngresado = Convert.ToInt32(Console.ReadLine());
            return valorIngresado;
        }//fin del método InputData()

        private static int CalculoFactorialRecursivo(int _valor)
        {
            //método usado para calcular el factorial usando recursividad
            //Caso Base
            if (_valor == 1)
                return 1;
            //Caso Normal
            else
                return _valor * CalculoFactorial(_valor - 1);
        }//fin del método CalculoFactorialRecursivo()

        private static int CalculoFactorial(int _valor)
        {
            //método usado para calcular el factorial sin recursividad
            int resultado = 1;
            for(int i=1; i<=_valor; i++)
            {
                resultado = resultado * i;
            }//fin del for
            return resultado;
        }//fin del método CalculoFactorial()

        private static void ImprimirResultado(int _resultado, int _resultadoFactorial)
        {
            //método usado para imprimir los resultados
            Console.WriteLine("***");
            Console.WriteLine("Resultado factorial sin recursividad: {0}", _resultado);
            Console.WriteLine("Resultado factorial con recursividad: {0}", _resultadoFactorial);
            Console.WriteLine("***");
            Console.ReadKey();
        }//fin del método ImprimirResultado()
    }
}
