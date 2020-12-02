using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrimerParcial
{
    class Tarea
    {
        [Key]
        public int idTarea { get; set; }
        public String titulo { get; set; }
        public DateTime vencimiento { get; set; }
        public int estimacion { get; set; }
        public Recurso responsable { get; set; }
        public bool estado { get; set; }
        public TipoTarea tipo { get; set; }

    }
}
