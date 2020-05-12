using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.Domain.Models
{
    public class Player:Staff
    {
        public int JersyNumber { get; set; }
        public string Position { get; set; }
        public List<MatchEvent>  MatchEvents{ get; set; }
}
}
