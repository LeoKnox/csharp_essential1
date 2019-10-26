using System;

namespace ConsoleApplication
{
    class Program
    {
        public static string title = "My world of C#";
        public static int whichPart;
        static void Main(string[] args)
        {
            whichPart = 2;
            Console.WriteLine("Welcome to {0} I give it a {1}!", title, whichPart);
            Console.Write(" Press enter ");
            Console.WriteLine(" To continue");
            string test = " test  ";
            Console.WriteLine(test.Trim().ToUpper());
            conan = new Char("Strong");
            Console.WriteLine(conan.Describe);
            Console.ReadLine();
        }
    }
    
    class Char
    {
        private string stat;

        public Char(string stat)
        {
            this.stat = stat;
        }

        public string Describe()
        {
            return "This char is " + Stat;
        }

        public string Stat
        {
            get { return stat; }
            set { stat = value; }
        }
    }
    
    // overload example
    public static T operator- (T a, T b)
    {
        T res = new T(a.num - b.num);
        return res;
    }
    
    // indexer example
    public int this[int index]
    {
        get
        {
            return n[index]
        }
        set
        {
            n[index] = value;
        }
    }
}
