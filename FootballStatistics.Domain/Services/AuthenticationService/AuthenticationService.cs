using FootballStatistics.Domain.Exceptions;
using FootballStatistics.Domain.Models;
using FootballStatistics.Domain.Models.Enum;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FootballStatistics.Domain.Services.AuthenticationService
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IDataService<User> _userDataService;
        private readonly IPasswordHasher _passwordHasherService;

        public AuthenticationService(IDataService<User> userDataService,IPasswordHasher passwordHasher)
        {
            _userDataService = userDataService;
            _passwordHasherService = passwordHasher;
        }

        public async Task<User> Login(string username, string password)
        {
            User storedUser = await _userDataService.GetByUsername(username);

            if(storedUser == null)
            {
                throw new UserNotFoundException(username);
            }

            PasswordVerificationResult verificationResult = _passwordHasherService.VerifyHashedPassword(storedUser.HashedPassword, password);

            if(verificationResult != PasswordVerificationResult.Success)
            {
                throw new InvalidPasswordException(username, password);
            }

            return storedUser;
        }

        public async Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword)
        {
            RegistrationResult result = RegistrationResult.Success;

            if(password != confirmPassword)
            {
                result = RegistrationResult.PasswoedsDoNotMatch;
            }

            User emailUser = await _userDataService.GetByEmail(email);
            if(emailUser != null)
            {
                result = RegistrationResult.EmailAlredyExists;
            }

            User usernameUser = await _userDataService.GetByUsername(username);
            if(usernameUser != null)
            {
                result = RegistrationResult.UsernameAlreadyExists;
            }

            if(result == RegistrationResult.Success)
            {
                string hashedPassword = _passwordHasherService.HashPassword(password);

                User user = new User()
                {
                    Email = email,
                    Username = username,
                    HashedPassword = hashedPassword,
                    DatedJoined = DateTime.Now,
                    UserRole = UserRoles.User
                };

                await _userDataService.Create(user);
            }

            return result;
        }
    }
}
