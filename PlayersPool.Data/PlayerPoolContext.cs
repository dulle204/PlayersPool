using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PlayersPool.Data
{
    public partial class PlayerPoolContext : DbContext
    {
        public PlayerPoolContext()
        {
        }

        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>()
                .HasMany(e => e.Players)
                .WithOne(e => e.Club)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Leagues)
                .WithOne(e => e.Country)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Players)
                .WithOne(e => e.Country)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<League>()
                .HasMany(e => e.Clubs)
                .WithOne(e => e.League)
                .HasForeignKey(e => e.LeagueId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
