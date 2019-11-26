using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class FirstCaster
    {
        public string CasterName; // public identifiers and methods get Capital first letter
        private int casterLevel; // private identifiers get Lower Case first letter

        public FirstCaster()
        {
            CasterName = "Dum Dum";
            casterLevel = 0;
        }

        public FirstCaster(string name, int level)
        {
            CasterName = name;
            casterLevel = level;
        }

        public int FireBall()
        {
            Random random = new Random();
            return casterLevel * (random.Next(8) +1) + casterLevel;
        }
    }
}
