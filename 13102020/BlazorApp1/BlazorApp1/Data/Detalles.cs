using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class Detalles
    {

        [Key]
        public int idDetalle { get; set; }
        public String fecha { get; set; }
        public String tiempo { get; set; }
        //public Recurso recurso { get; set; }
        //public Tareas tarea { get; set; }

        public Detalles(int idDet, string fech, string tiemp) {

            this.idDetalle = idDet;
            this.fecha = fech;
            this.tiempo = tiemp;        
        }

        public Detalles() { }

    }
}

