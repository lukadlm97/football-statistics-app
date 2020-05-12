using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.Domain.Models
{
    public class Staff:Person
    {
        public DateTime DatedJoined { get; set; }
        public DateTime ContactUntil { get; set; }
    }
}
