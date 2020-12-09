using Microsoft.EntityFrameworkCore;
using NotasFinalDiars.Models.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasFinalDiars.Models.BD
{
    public class NotasContext:DbContext
    {

        public NotasContext(DbContextOptions<NotasContext> options) : base(options) { }

        public DbSet<Notas> Notas { get; set; }
        public DbSet<Etiquetas> Etiquetas { get; set; }
        public DbSet<NotaEtiqueta> NotaEtiquetas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new NotaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaMap());
            modelBuilder.ApplyConfiguration(new NotaEtiquetaMap());
        }

    }
}
