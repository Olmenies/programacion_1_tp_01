//Título: Trabajo Práctico 01 - Ejercicio 14
//Consigna: Dadas dos fechas calcular la diferencia en días entre una y la otra.
//Alumno: Nicolás Esteban Olmedo
using System;

namespace tp_01_ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                DateTime dateTime00, dateTime01;
                TimeSpan diferenciaFechas;

                //Input
                dateTime00 = InputData();
                dateTime01 = InputData();

                //Procesamiento
                diferenciaFechas = CalculoDiferenciaFechas(dateTime00, dateTime01);

                //Output
                OutputData(diferenciaFechas);
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }//fin del método Main()

        private static DateTime InputData()
        {
            //método usado ingresar fechas
            DateTime _dateTime;
            string datePattern = "dd/MM/yyyy";
            Console.Write("Ingresar fecha en formato dd/mm/yyyy");
            _dateTime = DateTime.ParseExact(Console.ReadLine(), datePattern, null);
            return _dateTime;
        }//Fin del método InputData()

        private static TimeSpan CalculoDiferenciaFechas(DateTime _dateTime00, DateTime _dateTime01)
        {
            //método usado para calcular la diferencia entre las fechas
            TimeSpan _diferenciaFechas;
            if (_dateTime00 > _dateTime01)
                _diferenciaFechas = _dateTime00 - _dateTime01;
            else
                _diferenciaFechas = _dateTime01 - _dateTime00;
            return _diferenciaFechas;
        }//fin del método CalculoDiferenciaFechas()

        private static void OutputData(TimeSpan _diferenciaFechas)
        {
            //método usado para imprimir resultado
            Console.WriteLine("***");
            Console.WriteLine("Diferencia en días: {0}", _diferenciaFechas.Days);
            Console.WriteLine("***");
            Console.ReadKey();
        }//fin del método OutputData()
    }
}
