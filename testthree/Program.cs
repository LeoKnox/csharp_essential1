using System;
using SchoolLibrary;

namespace testthree
{
    class Program
    {
        static void Main(string[] args)
        {
            enum Binary {"off", "on"};
            
            var unknown = 32; // must be declared with var, cannot be defined and declared
            
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
            
            new char multi = 'A';
            switch (multi)
            {
                case 'a':
                    Console.WriteLine('lower');
                    break;
                case 'A':
                    Console.WriteLine('upper');
                    break;
                default:
                    Console.WriteLine('unknown');
                    break;
            }
            
            Stack<string> st = new Stack<string>();
            
            st.push("one");
            st.push("two");
            st.push("plus");
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
            st.Clear();
            
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
    class EncapsulationExample
    {
        private int encexam = 0;
        public void addOne(int x)
        {
            encexam += x;
        }
        public double showExam()
        {
            return encexam;
        }
        public void SetExam(int y)
        {
            encexam = y;
        }
    }
    class WriteLine
    {
        Console.Write("Type text: ");
        string words = Console.ReadLine();
        Console.WriteLine("Writing " + words + "!");
    }
    class MoreLine
    {
        Console.WriteLine("Type text: ");
        string morewords = Consol.ReadLine();
        Console.WriteLine("Writing, {0}!", morewords);
        Console.WriteLine("Writing {0} and more {1}!", words, morewords);
    }
}
