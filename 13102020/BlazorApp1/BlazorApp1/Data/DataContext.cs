using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>()
                .ToTable("Usuario")
                .Property(p => p.clave);
            modelBuilder.Entity<Tareas>()
                .ToTable("Tarea");
            modelBuilder.Entity<Detalles>()
                .ToTable("Detalle")
                .Property(p => p.idDetalle);
            modelBuilder.Entity<Recursos>()
                .ToTable("Recurso")
                .Property(p => p.idRecurso);
        }

       public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Recursos> Recursos { get; set; }
        public DbSet<Detalles> Detalles { get; set; }
    }
}
