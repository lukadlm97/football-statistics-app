using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.Domain.Models
{
    public class Team:DomainObject
    {
        public string TeamName { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
        public int Capacity { get; set; }
        public Manager Manager { get; set; }
        public List<Player> Players { get; set; }
        public List<Season> Seasons { get; set; }
    }
}
