using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.Domain.Models
{
    public class Season:DomainObject
    {
        public League League { get; set; }
        public string NameOfSeason { get; set; }
        public List<Team> Teams  { get; set; }
    }
}
