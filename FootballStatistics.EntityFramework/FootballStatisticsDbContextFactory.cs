using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.EntityFramework
{
    public class FootballStatisticsDbContextFactory : IDesignTimeDbContextFactory<FootballStatisticsDbContext>
    {
        public FootballStatisticsDbContext CreateDbContext(string[] args=null)
        {
            var options = new DbContextOptionsBuilder<FootballStatisticsDbContext>();
            options.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = FootballApp_Dev; Trusted_Connection = True; MultipleActiveResultSets = true");

            return new FootballStatisticsDbContext(options.Options);
        }
    }
}
