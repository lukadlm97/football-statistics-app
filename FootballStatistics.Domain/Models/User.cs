using FootballStatistics.Domain.Models.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.Domain.Models
{
    public class User:DomainObject
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public DateTime DatedJoined { get; set; }
        public UserRoles UserRole { get; set; }
    }
}
