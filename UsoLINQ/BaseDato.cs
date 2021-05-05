using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UsoLINQ
{
    public partial class BaseDato : DbContext
    {
        public BaseDato()
            : base("name=BaseDato")
        {
        }

        public virtual DbSet<Procesadores> Procesadores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Procesadores>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Procesadores>()
                .Property(e => e.plataforma)
                .IsUnicode(false);

            modelBuilder.Entity<Procesadores>()
                .Property(e => e.socket)
                .IsUnicode(false);

            modelBuilder.Entity<Procesadores>()
                .Property(e => e.linea)
                .IsUnicode(false);

            modelBuilder.Entity<Procesadores>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Procesadores>()
                .Property(e => e.velocidad)
                .IsUnicode(false);
        }
    }
}
