using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        private DataContext ctx;

        public UsuarioService(DataContext _context)
        {
            ctx = _context;
        }

        // Metodos de Usuarios (Usuario)
        public async Task<List<Usuario>> ListadoUsuarios()
        {
            //return await ctx.Usuarios.ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllUsuario();
        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetUsuarioById(id);
        }

        public async Task<Usuario> Save(Usuario value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");

            if (value.UsuarioPK == 0)
            {
               return await remoteService.CrearUsuario(value);
            }
            else
            {
                return await remoteService.UpdateUsuario(value, value.UsuarioPK);
            }

        }

        public async Task<bool> Delete(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            await remoteService.DeleteUsuario(id);
            return true;
        }
    }
}
