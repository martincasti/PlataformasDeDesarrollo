﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Detalle
    {
        public DateTime fecha { get; set; }
        public String Tiempo { get; set; }
        public Recurso recurso { get; set; }
        public Tarea tarea { get; set; }
    }
}
