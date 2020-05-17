using FootballStatistics.Domain.Models;
using FootballStatistics.Domain.Models.Enum;
using FootballStatistics.WPF.Authenticators;
using FootballStatistics.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace FootballStatistics.WPF.Commands
{
    class RegisterCommand : ICommand
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly IAuthenticator _authenticator;

        public RegisterCommand(LoginViewModel loginViewModel, IAuthenticator authenticator)
        {
            _loginViewModel = loginViewModel;
            _authenticator = authenticator;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            RegistrationResult registrationResult = await _authenticator.Register(_loginViewModel.Email,_loginViewModel.Username,_loginViewModel.Password,_loginViewModel.ConfirmPassword);
            RegistrationResult registration = registrationResult;
        }
    }
}
