//Título: Trabajo Práctico 01 - Ejercicio 09
//Consgina: Dadas dos frases concatenarlas y mostrar el resultado.
//Alumno: Nicolás Esteban Olmedo

using System;

namespace tp_01_ejercicio_09b
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                int cantidadFrases = 2;
                string fraseResultado;
                string[] frasesArray = new string[cantidadFrases];

                //Input
                InputData(frasesArray, cantidadFrases);

                //Procesamiento
                fraseResultado = ConcatenacionFrases(frasesArray, cantidadFrases);

                //Output
                OutputData(fraseResultado);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()

        private static void InputData(string[] _frasesArray, int _cantidadFrases)
        {
            for(int i=0; i<_cantidadFrases; i++)
            {
                Console.WriteLine("Ingresar una frase: ");
                _frasesArray[i] = Console.ReadLine();
            }//fin del for
        }//fin del método InputData()

        private static string ConcatenacionFrases(string[] _frasesArray, int _cantidadFrases)
        {
            string _fraseResultado = "";
            for(int i=0; i<_cantidadFrases; i++)
            {
                if (i == 0)
                    _fraseResultado = _frasesArray[i];
                else
                    _fraseResultado = _fraseResultado + _frasesArray[i];
            }//fin del for 
            return _fraseResultado;
        }//fin del método ConcatenacionFrases()

        private static void OutputData(string _fraseResultado)
        {
            Console.WriteLine("***");
            Console.WriteLine("Frase concatenada: {0}", _fraseResultado);
            Console.WriteLine("***");
            Console.ReadKey();
        }//fin del método OutputData()
    }
}