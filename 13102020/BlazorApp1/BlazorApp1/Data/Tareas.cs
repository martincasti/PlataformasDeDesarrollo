using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class Tareas
    {
        [Key]
        public int idTarea { get; set; }
        public string titulo { get; set; }
        public string vencimiento { get; set; }

        public Tareas(string tit, string vto)
        {
            this.titulo = tit;
            this.vencimiento = vto;
        }
        public Tareas() { }

    }
}

