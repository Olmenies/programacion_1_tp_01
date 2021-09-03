//Título: Trabajo Práctico 01 - Ejercicio 04
//Consigna: Dados los datos necesarios de un Cuadrado calcular la superficie.
//Alumno: Nicolás Esteban Olmedo

using System;

namespace tp_01_ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                float lado_00, lado_01, superficie;

                //Input
                lado_00 = InputData("base");
                lado_01 = InputData("altura");

                //Procesamiento
                superficie = CalculoSuperficie(lado_00, lado_01);

                //Output
                Console.WriteLine("***");
                Console.WriteLine("Superficie: " + superficie);
                Console.WriteLine("***");
                Console.ReadKey();
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()

        private static float CalculoSuperficie(float _lado_00, float _lado_01)
        {
            //método usado para calcular la superficie
            float _resultado;
            _resultado = _lado_00 * _lado_01;
            return _resultado;
        }//fin del método CalculoSuperficie()

        private static float InputData(string _leyenda)
        {
            //método usado para ingresar valores
            float _resultado;
            do
            {
                Console.Write("Ingresar {0}: ", _leyenda);
                _resultado = Convert.ToSingle(Console.ReadLine());
                if (_resultado < 0)
                    Console.Write("Valor no válido.");
            } while (_resultado < 0);//fin del do-while
            return _resultado;
        }//fin del método InputData()
    }
}
