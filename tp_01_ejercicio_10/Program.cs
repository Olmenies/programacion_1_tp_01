//Título: Trabajo Práctico 01 - Ejercicio 10
//Consigna: Dada una frase cualquiera llamada x, mostrar como resultado una frase formada por la segunda mitad de x más la primer mitad de x. (usar el método substring)
//Alumno: Nicolás Esteban Olmedo
using System;

namespace tp_01_ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                string fraseIngresada, fraseResultado;

                //Input
                fraseIngresada = InputData();

                //Procesamiento
                fraseResultado = ConcatenacionFrases(fraseIngresada);

                //Output
                OutputData(fraseResultado);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()

        private static string InputData()
        {
            //método usado para ingresar valores
            string _fraseIngresada;
            Console.Write("Ingresar una frase: ");
            _fraseIngresada = Console.ReadLine();
            return _fraseIngresada;
        }//fin del método InputData()

        private static void OutputData(string _fraseResultado)
        {
            //método usado para imprimir resultado
            Console.WriteLine("***");
            Console.WriteLine("Frase resultado: {0}", _fraseResultado);
            Console.WriteLine("***");
            Console.ReadKey();
        }//fin del método OutputData()

        private static string ConcatenacionFrases(string _fraseIngresada)
        {
            //método usado para concatenar las frases ingresadas
            string _fraseResultado;
            _fraseResultado = _fraseIngresada.Substring(_fraseIngresada.Length / 2) + _fraseIngresada.Substring(0, _fraseIngresada.Length / 2);
            return _fraseResultado;
        }//fin del método ConcatenacionFrases()
    }
}
