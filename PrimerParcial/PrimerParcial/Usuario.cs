using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrimerParcial
{
    
    class Usuario
    {
        [Key]
        public int codigo { get; set; }

        [Required]
        public String nombre { get; set; }

        [Required]
        public String clave { get; set; }

    }
}
