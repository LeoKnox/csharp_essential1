using System;

namespace ConsoleApplication
{
    class Program
    {
        private static int MakeRef(ref int num)
        {
            num = num +3;
        }
        private static string MakeOut(out int num)
        {
            string returnStr = "num = " + num.ToString();
            return returnStr;
        }
        static void Main(string[] args)
        {
            whichPart = 2;
            Console.WriteLine("Welcome to {0} I give it a {1}!", title, whichPart);
            Console.Write(" Press enter ");
            Console.WriteLine(" To continue");
            string test = " test  ";
            Console.WriteLine(test.Trim().ToUpper());
            var one = "World";
            var two = 103.4f;
            var three = DateTime.Now;
            string.Format("Hello {0}. What time is it? {1:T}. Here's a number {2:0.00}.", one, two, three);
            int i = 3;
            MakeRef(ref i);
            string test = MakeOut(out i);
            Console.ReadLine();
        }
    }
}
