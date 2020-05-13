using FootballStatistics.Domain.Models;
using FootballStatistics.Domain.Models.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FootballStatistics.WPF.Authenticators
{
    public interface IAuthenticator
    {
        User CurrentUser { get; }
        bool IsLoggedIn { get; }

        Task<RegistrationResult> Register(string email, string username, string password,string confirmPassword);
        Task<bool> Login(string username, string password);
        void Logout();
    }
}
