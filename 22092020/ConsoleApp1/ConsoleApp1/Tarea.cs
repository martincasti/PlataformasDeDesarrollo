using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tarea
    {
        public String titulo { get; set; }
        public DateTime vencimiento { get; set; }
        public int estimacion { get; set; }
        public Recurso responsable { get; set; }
        public bool estado { get; set; }

        
        public Tarea(String titulos, DateTime vencimientos, int estimaciones, Recurso responsables, bool estados)
        {
            this.titulo = titulos;
            this.vencimiento = vencimientos;
            this.estimacion = estimaciones;
            this.responsable = responsables;
            this.estado = estados;
        }
    }
}
