using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.Domain.Models
{
    public class Person:DomainObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImgUrl { get; set; }
        public Nation Nationality { get; set; }
    }
}
