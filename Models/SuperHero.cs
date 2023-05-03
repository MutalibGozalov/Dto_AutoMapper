using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReflectionsDemo.Models
{
    public class SuperHero
    {
        public SuperHero(int id, string? firstName, string? lastName, string? superHeroName, byte age, string? superPowers, string? team)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            SuperHeroName = superHeroName;
            Age = age;
            SuperPowers = superPowers;
            Team = team;
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? SuperHeroName { get; set; }
        public byte Age { get; set; }
        public string? SuperPowers { get; set; }
        public string? Team { get; set; }
    }
}