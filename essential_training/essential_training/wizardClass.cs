using System;
using System.Collections.Generic;
using System.Text;

namespace essential_training
{
    class wizardClass
    {
        public List<string> Wizards { get; set; }

        public wizardClass()
        {
            Wizards = new List<string>();
        }

        public bool IsWizard(string wizard)
        {
            return Wizards.Contains(wizard);
        }
    }
}
