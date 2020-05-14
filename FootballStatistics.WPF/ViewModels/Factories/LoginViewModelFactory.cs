using FootballStatistics.WPF.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.WPF.ViewModels.Factories
{
    public class LoginViewModelFactory : IFootballStatisticViewModelFactory<LoginViewModel>
    {
        private readonly IAuthenticator _authenticator;

        public LoginViewModelFactory(IAuthenticator authenticator)
        {
            _authenticator = authenticator;
        }

        public LoginViewModel CreateViewModel()
        {
            return new LoginViewModel(_authenticator);
        }
    }
}
