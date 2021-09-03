//Título: Trabajo Práctico 01 - Ejercicio 06
//Consigna: Si la circunferencia de un círculo es pi * Diámetro, desarrollar una aplicación que dada la circunferencia calcule el diámetro.
//Alumno: Nicolás Esteban Olmedo

using System;

namespace tp_01_ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                float radio, circunferencia;

                //Input
                radio = InputData();

                //Procesamiento
                circunferencia = CalculoCircunferencia(radio);

                //Output
                Console.WriteLine("***");
                Console.WriteLine("Circunferencia: {0}", circunferencia);
                Console.WriteLine("***");
                Console.ReadKey();
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()

        private static float InputData()
        {
            //método usado para ingresar valore
            float _resultado;
            do
            {
                Console.Write("Ingresar diámetro: ");
                _resultado = (Convert.ToSingle(Console.ReadLine()))/2;
                if (_resultado < 0)
                    Console.WriteLine("Valor no válido.");
            } while (_resultado < 0);//fin del do-while
            return _resultado;
        }//fin del método InputData()

        private static float CalculoCircunferencia(float _radio) 
        {
            //método usado para calcular la circunferencia
            float _resultado;
            _resultado = Convert.ToSingle(Math.PI) * Convert.ToSingle(Math.Pow(_radio, 2));
            return _resultado;
        }//fin del método CalculoCircunferencia()
    }
}
