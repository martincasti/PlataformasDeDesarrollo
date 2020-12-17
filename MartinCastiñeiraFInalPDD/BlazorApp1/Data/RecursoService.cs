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

        public async Task<List<Recurso>> ListadoRecursos()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllRecurso();
        }

        public async Task<Recurso> SeleccionarRecurso(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await ctx.Recursos.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<Recurso> Save(Recurso value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GuardarRecurso(value);
        }

        public async Task<bool> DeleteRecursos(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            await remoteService.BorrarRecurso(id);
            return true;
        }

        public async Task<List<Usuario>> GetUser()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllUsuario();
            //return await ctx.Usuarios.ToListAsync();
        }

    }
}
