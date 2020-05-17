using FootballStatistics.Domain.Models.Enum;
using FootballStatistics.WPF.Authenticators;
using FootballStatistics.WPF.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace FootballStatistics.WPF.ViewModels
{
    public class LoginViewModel:ViewModelBase
    {
        private string _username { get; set; }
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _usernameRegister { get; set; }
        public string UsernameRegister
        {
            get
            {
                return _usernameRegister;
            }
            set
            {
                _usernameRegister = value;
                OnPropertyChanged(nameof(UsernameRegister));
            }
        }

        private string _email { get; set; }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        private string _password { get; set; }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private string _confirmPassword { get; set; }
        public string ConfirmPassword
        {
            get
            {
                return _confirmPassword;
            }
            set
            {
                _confirmPassword = value;
                OnPropertyChanged(nameof(ConfirmPassword));
            }
        }

        private UserRoles _userRole { get; set; }
        public UserRoles UserRole
        {
            get
            {
                return _userRole;
            }
            set
            {
                _userRole = value;
                OnPropertyChanged(nameof(UserRole));
            }
        }




        public ICommand LoginCommand { get; }

        public LoginViewModel(IAuthenticator authenticator)
        {
            LoginCommand = new LoginCommand(this, authenticator);
        }

    }
}
