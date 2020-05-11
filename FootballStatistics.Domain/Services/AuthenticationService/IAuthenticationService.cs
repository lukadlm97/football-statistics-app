using FootballStatistics.Domain.Models;
using FootballStatistics.Domain.Models.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FootballStatistics.Domain.Services.AuthenticationService
{
    public interface IAuthenticationService
    {
        Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword);
        Task<User> Login(string username, string password);
    }
}
