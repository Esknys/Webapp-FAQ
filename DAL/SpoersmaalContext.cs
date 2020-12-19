using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Oppgave3.Models;

namespace Oppgave3.DAL
{
    public class Spoersmaalene
    {
        [Key]
        public int Id { get; set; }
        public string Spoersmaalet { get; set; }
        public string Svar { get; set; }
    }

    public class InnSpoersmaalene
    {
        [Key]
        public int Id { get; set; }
        public string Spoersmaalet { get; set; }
        public string Navn { get; set; }
        public string Epost { get; set; }
    }

    public class SpoersmaalContext : DbContext
    {
        public SpoersmaalContext(DbContextOptions<SpoersmaalContext> options)
          : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Spoersmaalene> Spoersmaalene { get; set; }
        public DbSet<InnSpoersmaalene> InnSpoersmaalene { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
