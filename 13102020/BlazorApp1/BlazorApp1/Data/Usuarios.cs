using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class Usuarios
    {
        [Key]
        public int codigo { get; set; }

        [Required]
        public String nombre { get; set; }

        [Required]
        public String clave { get; set; }

        public Usuarios(int id, string nomb, string clav)
        {
            this.codigo = id;
            this.nombre = nomb;
            this.clave = clav;

        }
        public Usuarios() { }

    }
}
