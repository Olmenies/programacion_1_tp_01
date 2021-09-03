//Título: Trabajo Práctico 01 - Ejercicio 03
//Consigna: Dados los lados de un triangulo calcular el perímetro.
//Alumno: Nicolás Esteban Olmedo

using System;

namespace tp_01_ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                float lado_00, lado_01, lado_02, perimetro;

                //Input
                lado_00 = InputData();
                lado_01 = InputData();
                lado_02 = InputData();

                //Procesamiento
                perimetro = CalculoPerimetro(lado_00, lado_01, lado_02);

                //Output
                Console.WriteLine("***");
                Console.WriteLine("Perímetro: " + perimetro);
                Console.WriteLine("***");
                Console.ReadKey();
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()

        private static float InputData()
        {
            //método usado para ingresar valores
            float _resultado;
            do
            {
                Console.WriteLine("Ingresar valor del lado: ");
                _resultado = Convert.ToSingle(Console.ReadLine());
                if (_resultado < 0)
                    Console.WriteLine("Valor no válido.");
            } while (_resultado < 0);//fin del do-while
            return _resultado;
        }//fin método InputData()

        private static float CalculoPerimetro(float _lado_01, float _lado_02, float _lado_03)
        {
            float _perimetro;
            _perimetro = _lado_01 + _lado_02 + _lado_03;
            return _perimetro;
        }//fin del método CalculoPerimetro()
    }
}
