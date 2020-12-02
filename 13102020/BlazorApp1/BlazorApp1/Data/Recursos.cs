using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class Recursos
    {
        [Key]
        public int idRecurso { get; set; }
        public String nombre { get; set; }
        //public Usuarios usuario { get; set; 

        public Recursos(int idRec, string nomb)
        {
            this.idRecurso = idRec;
            this.nombre = nomb;
        }
        public Recursos() { }
    }
}
