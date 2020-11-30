using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refit;

namespace BlazorApp1.Data
{
    public class TareaService
    {

        // Metodos de Tareas (Task)

        private DataContext ctx;

        public TareaService(DataContext _context)
        {
            ctx = _context;
        }

        public async Task<List<Tarea>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllTarea();
        }

        public async Task<Tarea> SeleccionarTareas(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetTareaById(id);
        }

        public async Task<Tarea> SaveTask(Tarea value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");

            if (value.Id == 0)
            {
                return await remoteService.CrearTarea(value);
            }
            else
            {
                return await remoteService.UpdateTarea(value, value.Id);
            }
           
            
        }

        public async Task<Tarea> DeleteTarea(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.DeleteTarea(id);
        }

        public async Task<List<Recurso>> GetResource()
        {
            return await ctx.Recursos.ToListAsync();
        }

    }
}
