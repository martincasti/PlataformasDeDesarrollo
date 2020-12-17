using System;
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

        public async Task<List<Detalle>> ListaDetalle()
        {
         
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllDetalle();
        }

        public async Task<Detalle> SeleccionarDetalle(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await ctx.Detalles.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<Detalle> Save(Detalle value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GuardarDetalle(value);
        }

        public async Task<bool> DeleteDetalle(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            await remoteService.BorrarDetalle(id);
            return true;
        }

        public async Task<List<Recurso>> GetResource()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllRecurso();
        }

        public async Task<List<Tarea>> GetTask()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllTarea();
        }
    }
}
