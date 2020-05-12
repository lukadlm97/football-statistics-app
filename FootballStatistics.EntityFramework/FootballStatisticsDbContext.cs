using FootballStatistics.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.EntityFramework
{
    public class FootballStatisticsDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Nation> Nations { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchEvent> MatchEvents { get; set; }
        public DbSet<Event> Events { get; set; }

        public FootballStatisticsDbContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Season>().HasMany(s => s.Teams);

            modelBuilder.Entity<Team>().HasMany(t => t.Seasons);

            base.OnModelCreating(modelBuilder);
        }


    }
}
