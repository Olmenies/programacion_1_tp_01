//Título: Trabajo Práctico 01 - Ejercicio 07
//Consigna: Si 1Byte tiene 8 bits, desarrolle una solución programática que permita calcular cuántos bits hay en cualquier combinación de x KBytes. Explique cómo llegó a esa conclusión.
//Alumno: Nicolás Esteban Olmedo

/* 1byte = 8bits
 * 1Kib = 1024 bytes
 * 1Kib = 1024*8 bits
 */

using System;

namespace tp_01_ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                int cantidadKib, cantidadBit;

                //Input
                cantidadKib = InputData();

                //Procesamiento
                cantidadBit = ConvertirKibxBit(cantidadKib);

                //Output
                Console.WriteLine("***");
                Console.WriteLine("{0} Kib = {1} bit", cantidadKib, cantidadBit);
                Console.WriteLine("***");
                Console.ReadKey();
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()

        private static int InputData()
        {
            //método usado para ingresar valores
            int valorIngresado;
            Console.Write("Ingresar cantidad de Kib a convertir: ");
            valorIngresado = Convert.ToInt32(Console.ReadLine());
            return valorIngresado;
        }//fin del método InputData

        private static int ConvertirKibxBit(int _cantidadKib)
        {
            //método usado para convertir Kib a Bits
            int resultado;
            resultado = _cantidadKib * 1024 * 8;
            return resultado;
        }//fin del método ConvertirKibxBit
    }
}
