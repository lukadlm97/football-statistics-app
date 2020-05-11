using FootballStatistics.Domain.Models;
using FootballStatistics.Domain.Services;
using FootballStatistics.Domain.Services.AuthenticationService;
using FootballStatistics.EntityFramework;
using FootballStatistics.EntityFramework.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;

namespace FootballStatistics.ConsoleAppTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userDataService = new UserDataService(new FootballStatisticsDbContextFactory());
            IAuthenticationService authenticationService = new AuthenticationService(userDataService, new PasswordHasher());


            Console.WriteLine(authenticationService.Login("asd", "pass4").Result);
            Console.ReadKey();
        }
    }
}
