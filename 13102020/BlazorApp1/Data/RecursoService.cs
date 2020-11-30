using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refit;

namespace BlazorApp1.Data
{
    public class RecursoService
    {
        // Metodos de Recursos (Resource)

        private DataContext ctx;

        public RecursoService(DataContext _context)
        {
            ctx = _context;
        }

        public async Task<List<Recurso>> GetAll()
        {
            //return await ctx.Recursos.Include(i=>i.Usuario).ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllRecurso();
        }

        public async Task<Recurso> GetById(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetRecursoById(id);
        }

        public async Task<Recurso> Save(Recurso value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
           
            if (value.Id == 0)
            {
                return await remoteService.CrearUsuario(value);
            }
            else
            {
                return await remoteService.UpdateUsuario(value, value.Id);
            }
            await ctx.SaveChangesAsync();
            return value;
        }

        public async Task<Recurso> Detelterecurso(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.DeleteRecurso(id);

        }

        public async Task<List<Usuario>> GetUser()
        {
            return await ctx.Usuarios.ToListAsync();
        }

    }
}
