using System;
using SchoolLibrary;

namespace testthree
{
    class Program
    {
        enum Gusts { world, nurse, goodbye };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello " + Enum.GetName(typeof(Gusts), 1));
            School test = new School("Swag", "111111111");
            Console.WriteLine("I live!");
            Console.WriteLinte("Writing more text");
            int? ieye = null;
            Console.ReadLine();
            var student = new Student();
        }

    }
}
