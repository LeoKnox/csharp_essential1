using System;
using SchoolLibrary;

namespace testthree
{
    class Program
    {
        static void Main(string[] args)
        {
            enum Binary {"off", "on"};
            StringBuilder sb  = new StringBuilder("hello ");
            sb.append("you");
            sb.appendLine("!");
            if (sb == "true")
            {
                try Console.WriteLine(sb/3);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} happened.", e);
            }
            School test = new School("Swag", "111111111");
            Console.WriteLine("I live again!");
            String test = Console.ReadLine();
        }
    }
}
