using System;
using ClassLibrary;


namespace Ejercicio_3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculadora calculadora = new Calculadora();

            Console.WriteLine(calculadora.Sumar(1, 2));
            Console.WriteLine(calculadora.Restar(4, 2));
            Console.WriteLine(calculadora.Multiplicar(4, 4));
            Console.WriteLine(calculadora.Dividir(4, 2));

            Console.ReadKey();

        }

       




    }
}
