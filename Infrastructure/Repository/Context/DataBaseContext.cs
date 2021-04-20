using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using TecnicalAssistence.Infrastructure.Models;

namespace TecnicalAssistence.Infrastructure.Repository.Context
{
    public class DataBaseContext : DbContext
    {
        public DbSet<AssistenciaEntity> AssistenciaEntity { get; set; }
        public DbSet<DataAssistenciaEntity> DataAssistenciaEntity { get; set; }
        
        public DbSet<HorarioAssistenciaEntity> HorarioAssistenciaEntity { get; set; }
        


        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseMySql(
                        "Server=192.168.68.117;User Id=root;Password=root;Database=cyrela",
                        new MariaDbServerVersion(new Version(8, 0, 21)), // use MariaDbServerVersion for MariaDB
                        mySqlOptions => mySqlOptions
                            .CharSetBehavior(CharSetBehavior.NeverAppend))
                    // Everything from this point on is optional but helps with debugging.
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssistenciaEntity>().Property(b => b.IdAssunto).IsRequired(false);
            modelBuilder.Entity<AssistenciaEntity>().Property(b => b.IdBloco).IsRequired(false);
            modelBuilder.Entity<AssistenciaEntity>().Property(b => b.IdEmpreendimento).IsRequired(false);
            modelBuilder.Entity<AssistenciaEntity>().Property(b => b.IdSituacao).IsRequired(false);
            modelBuilder.Entity<AssistenciaEntity>().Property(b => b.IdStatus).IsRequired(false);
            modelBuilder.Entity<AssistenciaEntity>().Property(b => b.IdVisita).IsRequired(false);
            modelBuilder.Entity<AssistenciaEntity>().Property(b => b.IdTipoAtividade).IsRequired(false);

            modelBuilder.Entity<DataAssistenciaEntity>().HasNoKey();
            
            modelBuilder.Entity<HorarioAssistenciaEntity>().HasNoKey();
        }
        
    }
    
}