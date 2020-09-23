using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class Calculadora
    {
        //private int numero1;

        //public int Numero1 { get; set; }
        //public int Numero2 { get; set; }


        //public Calculadora()
        //{

        //}
        //public Calculadora( int valor1, int valor2)
        //{
        //    Numero1 = valor1;
        //    Numero2 = valor2;
        //}

        //public int Metodo( string valor)
        //{
        //    return 0;

        //}

        //public int Metodo (int valor, int valor2)
        //{
        //    return 0;
        //}


        //public int Metodo()
        //{
        //    if (Numero1 == Numero2)
        //    {
        //        return 0;
        //    }

        //    return 1;

        //}

        //private class operacion
        //{

        //}

        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;

        }

        public int Restar (int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;

        }

        public double Dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }



    }
}
