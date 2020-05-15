using FootballStatistics.Domain.Models;
using FootballStatistics.Domain.Services;
using FootballStatistics.Domain.Services.AuthenticationService;
using FootballStatistics.EntityFramework;
using FootballStatistics.EntityFramework.Services;
using FootballStatistics.WPF.Authenticators;
using FootballStatistics.WPF.State.Navigators;
using FootballStatistics.WPF.ViewModels;
using FootballStatistics.WPF.ViewModels.Factories;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FootballStatistics.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();

            Window window = serviceProvider.GetRequiredService<MainWindow>();
            window.Show();
       
            base.OnStartup(e);
        }


        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<FootballStatisticsDbContextFactory>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IDataService<User>, UserDataService>();
            services.AddSingleton<IPasswordHasher, PasswordHasher>();
             services.AddSingleton<INavigator, Navigator>();
             services.AddSingleton<IRootFootballStatisticViewModelFactory, RootFootballStatisticViewModelFactory>();
             services.AddSingleton<IFootballStatisticViewModelFactory<LoginViewModel>, LoginViewModelFactory>();
           
           
            services.AddScoped<IAuthenticator, Authenticator>();
            services.AddScoped<MainViewModel>();

            services.AddScoped<MainWindow>(s => new MainWindow(s.GetRequiredService<MainViewModel>()));

            return services.BuildServiceProvider();

        }
    }
}
