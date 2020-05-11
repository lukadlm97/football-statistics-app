using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.Domain.Models.Enum
{
    public enum RegistrationResult
    {
        Success,
        PasswoedsDoNotMatch,
        EmailAlredyExists,
        UsernameAlreadyExists
    }
}
