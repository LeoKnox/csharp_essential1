using System;
using System.Collections.Generic;
using System.Text;

namespace essential_training
{
    class SimpleArray
    {
        public string[] Classes;

        public SimpleArray()
        {
            Classes = new string[4] { "Warrior", "Scout", "Wizard", "Alchemist" };
        }

        public override string ToString()
        {
            return "There are " + Classes.Length + " and they are: " + Classes.ToString();
        }
    }
}
