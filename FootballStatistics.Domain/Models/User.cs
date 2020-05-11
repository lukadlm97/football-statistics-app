using FootballStatistics.Domain.Models.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.Domain.Models
{
    public class User:DomainObject
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public UserRoles UserRole { get; set; }
    }
}
