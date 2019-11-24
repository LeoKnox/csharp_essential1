using System;
using System.Collections.Generic;
using System.Text;

namespace essential_training
{
    public class SimpleArray
    {
        public string[] Classes;

        public SimpleArray()
        {
            Classes = new string[5] { "Warrior", "Scout", "Wizard", "Alchemist", "Sword Master" };
        }

        public override string ToString()
        {
            return "There are " + Classes.Length + " and they are: " + Classes.ToString();
        }
    }
}
