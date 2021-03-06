﻿using System;
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

        public async Task<List<Tarea>> ListadoUsuarios()
        {
            //return await ctx.Tareas.Include(i => i.Responsable).ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllTarea();
        }

        public async Task<Tarea> GetTareaById(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await ctx.Tareas.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<Tarea> Save(Tarea value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GuardarTarea(value);
        }

        public async Task<bool> DeleteTarea(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            await remoteService.BorrarTarea(id);
            return true;
        }

        public async Task<List<Recurso>> GetResource()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllRecurso();
        }

    }
}
