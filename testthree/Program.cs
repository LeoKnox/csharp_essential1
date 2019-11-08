using System;
using SchoolLibrary;

namespace testthree
{
    class Program
    {
        static void Main(string[] args)
        {
            enum Binary {"off", "on"};
            
            new bool test = true; // c# cannot convert bool to int
            if (test == "true")
            {
               new int testi = 1
            }
            else
            {
                new int testi = 0
            }
            
            Dictionary<int, string> dict = new Dictionary<int, string>();
            
            dict.Add(1,"First");
            dict.Add(2, "Second");
            dict.Add(3, "Third");
            
            StringBuilder sb  = new StringBuilder("hello ");
            sb.append("you");
            sb.appendLine("!");
            StringBuilder sb2 = new StringBuilder("I am ");
            sb2.append("being ");
            sb2.append("built");
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
