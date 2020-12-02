using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //int numeroSecreto = random.Next(10);
            //int numero = 0;

            //for (int intentos = 0; intentos < 3; intentos++)
            //{
            //    NumeroElegido("Ingrese un numero del 1 al 10: ", numero);

            //    if (numeroSecreto == numero)
            //    {
            //        break;
            //    }
            //}

            //if(numeroSecreto == numero)
            //{
            //    Console.WriteLine(Ganaste(numeroSecreto));

            //}
            //else
            //{
            //    Console.WriteLine(Perdiste(numeroSecreto));

            //}

            //Console.ReadKey(); 


            Boolean numero = CalcularAnioBisiesto("Ingrese su anio de nacimiento: ");

            if (numero == true)
            {
                Console.WriteLine("Has nacido en un anio bisiesto");
            }
            else
            {
                Console.WriteLine("Naciste en un anio no bisiesto");
            }

            Console.ReadKey();



        }

        static Boolean CalcularAnioBisiesto(string mensaje)
        {
            Console.WriteLine(mensaje);
            string anio = Console.ReadLine();
            int numero = int.Parse(anio);

            if (numero % 4 == 0 && numero % 100 != 0)

            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //static void NumeroElegido(string mensaje, int numero)
        //{
        //    Console.WriteLine(mensaje);
        //    string valor = Console.ReadLine();
        //    numero = int.Parse(valor);

        //}


        //static string Ganaste(int valor)
        //{
        //    return "Ganaste! El numero ganador era: " + valor;
        //}

        //static string Perdiste(int valor)
        //{
        //    return $"Perdiste! el numero era: {valor}";
        //}









    }







}
