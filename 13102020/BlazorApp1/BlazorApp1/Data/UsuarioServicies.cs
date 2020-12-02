using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioServicies
    {

        private DataContext context;
        public UsuarioServicies(DataContext contxt)
        {

            context = contxt;
        }

        public async Task<List<Usuarios>> ListaUsuarios()
        {
            var ctx = new DataContext();
            var lista = ctx.Usuarios.ToList();


            return lista;
        }

        public Usuarios AddUsers(int idUser, string name, string pass)
        {
            var ctx = new DataContext();
            var usuario = new Usuarios
            {
                codigo = idUser,
                nombre = name,
                clave = pass
            };
            ctx.Set<Usuarios>().Add(usuario);
            ctx.SaveChanges();
            return usuario;
        }

        public Usuarios updateUsers(int idUser, string name, string pass)
        {
            var ctx = new DataContext();
            var usuario = ctx.Usuarios.Where(i => i.codigo == idUser).FirstOrDefault();
            return usuario;
        }




        //public Usuarios[] GetUsuarios()
        //{
        //  Usuarios[] resultado = new Usuarios[5];

        //resultado[0] = new Usuarios(01, "Martin Kuznetov","cast123");
        //resultado[1] = new Usuarios(02, "Frederick Brooke","fredo245");
        //resultado[2] = new Usuarios(03, "Charles Lowery","c2harle2s");
        //resultado[3] = new Usuarios(04, "Brian Williamsom","b1mwillamsom23");
        //resultado[4] = new Usuarios(05, "Coral Rodriguez", "nenKa24");

        // return resultado;
        //}







    }
}
