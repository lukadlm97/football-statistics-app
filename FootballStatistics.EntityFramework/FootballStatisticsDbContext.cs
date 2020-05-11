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

        public FootballStatisticsDbContext(DbContextOptions options):base(options)
        {

        }

    }
}
