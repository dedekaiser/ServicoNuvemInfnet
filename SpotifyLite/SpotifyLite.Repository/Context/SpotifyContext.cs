using Microsoft.EntityFrameworkCore;
using SpotifyLite.Domain.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Repository.Context
{
    public class SpotifyContext : DbContext
    {

        public SpotifyContext(DbContextOptions<SpotifyContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SpotifyContext).Assembly);
        

            //
         
            modelBuilder.Entity<Usuario>().OwnsOne(x => x.Nome)
                .Property(x => x)
                .HasColumnName("Nome")
                .IsRequired(true);
            modelBuilder.Entity<Usuario>().OwnsOne(x => x.Password)
                .Property(x => x.Valor)
                .HasColumnName("Password")
                .IsRequired(true);
            modelBuilder.Entity<Usuario>().OwnsOne(x => x.Email)
                .Property(x => x.Valor)
                .HasColumnName("Email")
                .IsRequired(true);
         
            //
                base.OnModelCreating(modelBuilder);
            
        }

        //

        public DbSet<Usuario> Usuarios { get; set; }   


    }
}
