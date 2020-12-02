using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrimerParcial
{
    class Detalle
    {
        [Key]
        public int idDetalle { get; set; }
        public DateTime fecha { get; set; }
        public String Tiempo { get; set; }
        public Recurso recurso { get; set; }
        public Tarea tarea { get; set; }

    }
}
