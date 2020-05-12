using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.Domain.Models
{
    public class MatchEvent:DomainObject
    {
        public int Minut { get; set; }
        public Event Event { get; set; }
        public Player Player { get; set; }
    }
}
