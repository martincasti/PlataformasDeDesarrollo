using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerParcial
{
    class Tarea
    {
        public String titulo { get; set; }
        public DateTime vencimiento { get; set; }
        public int estimacion { get; set; }
        public Recurso responsable { get; set; }
        public bool estado { get; set; }

    }
}
