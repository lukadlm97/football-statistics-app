using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.Domain.Models
{
    public class Match:DomainObject
    {
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public List<Player> HomeStarters { get; set; }
        public List<Player> AwayStarters { get; set; }
        public List<Player> HomeBench { get; set; }
        public List<Player> AwayBench { get; set; }
        public List<MatchEvent> MatchEvents { get; set; }
    }
}
