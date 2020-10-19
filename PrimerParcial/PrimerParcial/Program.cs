using System;
using System.Linq;

namespace PrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {

            Insertar();
            Consultar();

            Console.WriteLine();

        }

        static void Consultar()
        {
            var ctx = new TareasDb();

            var ListUsuarios = ctx.Usuarios.ToList();
            foreach (var usuario in ListUsuarios)
            {
                Console.WriteLine($"Nombre: {usuario.nombre} ({usuario.codigo})");
            }

            ctx.SaveChanges();
        }

        static void Insertar()
        {
            var ctx = new TareasDb();

            ctx.Usuarios.Add(new Usuario { codigo = 1, nombre = "Martin", clave = "1234" });

            ctx.SaveChanges();
        }
        static void Actualizar()
        {
            var ctx = new TareasDb();

            var usuario = ctx.Usuarios.Where(i => i.codigo == 1).Single();
            usuario.nombre = "Pedro";
            ctx.SaveChanges();
        }

        static void Eliminar()
        {
            var ctx = new TareasDb();
            var usuario = ctx.Usuarios.Where(i => i.codigo == 1).Single();

            ctx.Usuarios.Remove(usuario);

            ctx.SaveChanges();

        }

    }
}
