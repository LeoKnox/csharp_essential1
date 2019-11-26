using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class FirstCaster
    {
        private int casterLevel;
        public int FireBall()
        {
            Random random = new Random();
            return casterLevel * (random.Next(8) +1) + casterLevel;
        }
    }
}
