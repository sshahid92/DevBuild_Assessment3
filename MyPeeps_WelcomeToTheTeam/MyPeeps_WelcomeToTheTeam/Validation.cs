using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyPeeps_WelcomeToTheTeam
{
    class Validation
    {
        public Validation()
        {
         
        }

        public bool String(string input, string regex, string failMessage)
        {            
            bool validate = Regex.IsMatch(input, regex);
            if (validate == true)
            {
                return true;
            }
            else
            {
                Console.WriteLine(failMessage);
                return false;
            }
        }

        public bool Age(int input, string regex, string failMessage)
        {
            string convertInt = input.ToString();
            bool validate = Regex.IsMatch(convertInt, regex);
            if (validate == true)
            {
                return true;
            }
            else
            {
                Console.WriteLine(failMessage);
                return false;
            }
        }

        public bool? YesNo(string input, string nullMessage)
        {
            switch (input)
            {
                case "yes":
                case "y":
                    return true;

                case "no":
                case "n":
                    return false;
                    

                default:
                    Console.WriteLine(nullMessage);
                    return null;
            }
        }
    }
}
