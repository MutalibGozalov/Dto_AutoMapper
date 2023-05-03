using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReflectionsDemo.Models
{
    public class SuperHeroDto
    {
        public string? SuperHeroName { get; set; }
        public string? SuperPowers { get; set; }
        public string? Team { get; set; }

        public override string ToString()
        {
            return this.SuperHeroName + "\n" + this.SuperPowers + "\n" + this.Team;
        }
    }
}