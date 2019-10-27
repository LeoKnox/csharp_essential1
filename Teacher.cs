using System;

namespace SchoolLibrary
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override float ComputeGradeAverage()
        {
            // todo fix implmentation for later
            return 0.0f;
        }
    }
}
