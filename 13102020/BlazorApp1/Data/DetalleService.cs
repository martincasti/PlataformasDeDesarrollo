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

        public async Task<List<Detalle>> GetAllDetalleByTaskId(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllByTaskId(id);
        }

        public async Task<Detalle> GetById(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetDetalleById(id);
        }

        public async Task<Detalle> SaveDetail(Detalle value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");

            if (value.RecursoId == 0)
            {
                return await remoteService.CrearDetalle(value);
            }
            else
            {
                return await remoteService.UpdateDetalle(value, value.RecursoId);
            }
         
        }

        public async Task<Detalle> DeleteDetail(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.DeleteDetalle(id);
        }

    }
}
