using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrimerParcial
{
    class Recurso
    {
        [Key]
        public int idRecurso { get; set; }
        public String nombre { get; set; }
        public Usuario usuario { get; set; }
    }
}
