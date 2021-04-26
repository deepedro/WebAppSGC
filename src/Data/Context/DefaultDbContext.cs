using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {

        }


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contacto> Contactos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contacto>().ToTable("Contacto");

            #region configurações de cliente
            modelBuilder.Entity<Cliente>().Property(l => l.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(l => l.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();
            #endregion

            #region configurações de contacto
            modelBuilder.Entity<Contacto>().Property(l => l.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contacto>().Property(l => l.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contacto>().Property(l => l.Telefone)
                .HasColumnType("varchar(15)");
            #endregion
        }
    }
}
