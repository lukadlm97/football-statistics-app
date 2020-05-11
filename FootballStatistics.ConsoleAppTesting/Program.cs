using FootballStatistics.Domain.Models;
using FootballStatistics.Domain.Services;
using FootballStatistics.EntityFramework;
using FootballStatistics.EntityFramework.Services;
using System;
using System.Collections.Generic;

namespace FootballStatistics.ConsoleAppTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userDataService = new UserDataService(new FootballStatisticsDbContextFactory());

            Console.WriteLine(userDataService.Get(1).Result);

            Console.ReadKey();
        }
    }
}
