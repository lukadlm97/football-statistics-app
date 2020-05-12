using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.Domain.Models
{
    public class League:DomainObject
    {
        public string Name { get; set; }
        public int NumberOfTeams { get; set; }
        public string Sponsor { get; set; }
    }
}
