using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Martin", "Cristian", "Pedro", "Federico" };

            IEnumerable<string> empiezanconF = from nombre in nombres where nombre.StartsWith("F") select nombre;

            IEnumerable<string> empiezanconM = nombres.Where(i => i.StartsWith("M"));

            foreach (var item in empiezanconF)
            {
                Console.WriteLine(item);
            }

            List<Actividad> eventos = new List<Actividad>();
            eventos.Add(new Actividad { lugar = "Caba", nombre = "Ms Build", fecha = new DateTime(2020, 22, 9) });


            Console.ReadLine();


        }
    }
}
