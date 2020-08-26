using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro = 10;
            string nroGuardado = "";

            Console.Write("Ingrese un numero: ");
            nroGuardado = Console.ReadLine();
            int valor = int.Parse(nroGuardado);
            while (valor != 10)
            {
                Console.Write("Segui participando! Ingrese un numero: ");
                nroGuardado = Console.ReadLine();
                valor = int.Parse(nroGuardado);

            }

            Console.Write("Felicitaciones, Ganaste! ");
            Console.ReadKey();

            }
        }
    }
