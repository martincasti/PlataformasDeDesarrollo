using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareasServicies
    {

        private DataContext context;
        public TareasServicies(DataContext contxt)
        {

            context = contxt;
        }

        public async Task<List<Tareas>> ListaTareas()
        {
            var ctx = new DataContext();
            var lista = ctx.Tareas.ToList();


            return lista;
        }

        public Tareas AddTask(int idTask, string tit, string vto)
        {
            var ctx = new DataContext();
            var tarea = new Tareas
            {
                idTarea = idTask,
                titulo = tit,
                vencimiento= vto
            };
            ctx.Set<Tareas>().Add(tarea);
            ctx.SaveChanges();
            return tarea;
        }

        public Tareas updateTask(int idTask, string tit, string vto)
        {
            var ctx = new DataContext();
            var tarea = ctx.Tareas.Where(i => i.idTarea== idTask).FirstOrDefault();
            return tarea;
        }
        /*public Tareas[] GetTareas()
        {
            Tareas[] resultado = new Tareas[10];

            resultado[0] = new Tareas("Tarea1", "10/11/2021");
            resultado[1] = new Tareas("Tarea2", "14/11/2021");
            resultado[2] = new Tareas("Tarea3", "17/11/2021");
            resultado[3] = new Tareas("Tarea4", "25/11/2021");
            resultado[4] = new Tareas("Tarea5", "30/11/2021");
            resultado[5] = new Tareas("Tarea6", "1/01/2021");
            resultado[6] = new Tareas("Tarea7", "10/12/2021");
            resultado[7] = new Tareas("Tarea8", "5/12/2021");
            resultado[8] = new Tareas("Tarea9", "10/01/2021");
            resultado[9] = new Tareas("Tarea10", "12/11/2021");

            return resultado;
        }
        */

    }
}
