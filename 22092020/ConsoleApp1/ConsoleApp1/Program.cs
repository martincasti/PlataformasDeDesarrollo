using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tarea> tareas = new List<Tarea>();
            tareas.Add(new Tarea("Ejercicio A", new DateTime(2020, 9, 22), 1, new Recurso(), false));
            tareas.Add(new Tarea("Ejercicio B", new DateTime(2020, 9, 22), 2, new Recurso(), true));
            tareas.Add(new Tarea("Ejercicio C", new DateTime(2020, 9, 22), 1, new Recurso(), false));
            tareas.Add(new Tarea("Ejercicio D", new DateTime(2020, 9, 22), 2, new Recurso(), true));
            tareas.Add(new Tarea("Ejercicio E", new DateTime(2020, 9, 22), 3, new Recurso(), false));
            tareas.Add(new Tarea("Ejercicio F", new DateTime(2020, 9, 22), 10, new Recurso(), true));




        }
    }
}
