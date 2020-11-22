using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 


namespace BlazorApp1.Data
{
    public class RecursoServicies
    {
        private DataContext context;
        public RecursoServicies(DataContext contxt)
        {

            context = contxt;
        }

        public async Task<List<Recursos>> ListaRecursos()
        {
            var ctx = new DataContext();
            var lista = ctx.Recursos.ToList();


            return lista;
        }

        public Recursos AddRecurso(int idRec, string name)
        {
            var ctx = new DataContext();
            var recurso = new Recursos
            {
                idRecurso = idRec,
                nombre= name
                
            };
            ctx.Set<Recursos>().Add(recurso);
            ctx.SaveChanges();
            return recurso;
        }

        public Recursos updateRecurso(int idRec, string name)
        {
            var ctx = new DataContext();
            var recurso = ctx.Recursos.Where(i => i.idRecurso == idRec).FirstOrDefault();
            return recurso;
        }


        /*public Recursos[] GetRecursos()
        {
            Recursos[] resultado = new Recursos[5];

            resultado[0] = new Recursos(01, "Notebook");
            resultado[1] = new Recursos(02, "Mouse");
            resultado[2] = new Recursos(03, "Monitor");
            resultado[3] = new Recursos(03, "Mousepad");
            resultado[4] = new Recursos(03, "Teclado");

            return resultado;
        }*/
    }
}
