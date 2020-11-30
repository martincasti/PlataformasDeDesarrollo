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

        public async Task<List<Tarea>> ListadoTareas()
        {
            //return await ctx.Tareas.Include(i => i.Responsable).ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllTarea();
        }

        public async Task<Tarea> GetTareaById(int id)
        {
            return await ctx.Tareas.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<Tarea> Save(Tarea value)
        {
            if (value.Id == 0)
            {
                await ctx.Tareas.AddAsync(value);
            }
            else
            {
                ctx.Tareas.Update(value);
            }
            await ctx.SaveChangesAsync();
            return value;
        }

        public async Task<bool> DeleteTarea(int id)
        {
            Tarea task = await ctx.Tareas.Where(i => i.Id == id).SingleAsync();

            ctx.Tareas.Remove(task);

            await ctx.SaveChangesAsync();
            return true;
        }

        public async Task<List<Recurso>> GetResource()
        {
            return await ctx.Recursos.ToListAsync();
        }

    }
}
