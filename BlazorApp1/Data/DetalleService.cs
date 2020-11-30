﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refit;

namespace BlazorApp1.Data
{
    public class DetalleService
    {
        // Metodos de Detalle (Detail)

        private DataContext ctx;

        public DetalleService(DataContext _context)
        {
            ctx = _context;
        }

        public async Task<List<Detalle>> ListadoDetalles()
        {
            //return await ctx.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllDetalle();
        }

        public async Task<Detalle> GetDetalleById(int id)
        {
            return await ctx.Detalles.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<Detalle> Save(Detalle value)
        {
            if (value.Id == 0)
            {
                await ctx.Detalles.AddAsync(value);
            }
            else
            {
                ctx.Detalles.Update(value);
            }
            await ctx.SaveChangesAsync();
            return value;
        }

        public async Task<bool> DeleteDetalle(int id)
        {
            Detalle det = await ctx.Detalles.Where(i => i.Id == id).SingleAsync();

            ctx.Detalles.Remove(det);

            await ctx.SaveChangesAsync();
            return true;
        }

        public async Task<List<Recurso>> GetResource()
        {
            return await ctx.Recursos.ToListAsync();
        }

        public async Task<List<Tarea>> GetTask()
        {
            return await ctx.Tareas.ToListAsync();
        }
    }
}
