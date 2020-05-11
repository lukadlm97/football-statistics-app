using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FootballStatistics.Domain.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public string Username { get; set; }

        public UserNotFoundException(string username)
        {
            Username = username;
        }

        public UserNotFoundException(string message, string username) : base(message)
        {
            Username = username;
        }

        public UserNotFoundException(string message, string username, Exception innerException) : base(message, innerException)
        {
            Username = username;
        }
    }
}
