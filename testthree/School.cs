using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name {get; set;}
        public string Address{get; set;}
        public string City {get; set;}
        public string State {get; set;}
        public string Zip {get; set;}
        public string PhoneNumber {get; set;}
        private string _twitterAddress;
        public string TwitterAddress
        {
            //make sure twitter address starts with @
            get { return _twitterAddress; }
            set 
            {
                if(value.StartsWith("@")) {
                    _twitterAddress = value;
                } else {
                    throw new Exception("The twitter address must begin with @");
                }
            }

        }
        public School() // constructor does not have return type or void
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }

        // alternate constructer used if parameters are passed
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        /* public float AverageThreeScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return result;
        } */

        // function bodied expression notice no return statement
        public static float AverageThreeScores(float a, float b, float c) => (a + b+ c) / 3;

        // overloading method, same name but different parameter types

        public static int AverageThreeScores(int a, int b, int c)
        // adding static can use function outside of class without instatianting it
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);

            return sb.ToString();
        }
    }
}
