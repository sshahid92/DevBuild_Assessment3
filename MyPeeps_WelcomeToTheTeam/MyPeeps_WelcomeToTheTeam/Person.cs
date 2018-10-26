using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPeeps_WelcomeToTheTeam
{
    class Person
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool IsAdult { get; set; }
        #endregion

        #region Constructors
        public Person(string firstName, string lastName, int age, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
        }
        #endregion

        public bool LegalAge()
        {
            if(Age < 18)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public virtual void AddPerson(List<Person> list)
        {
            Person addPerson = new Person(FirstName, LastName, Age, Email);
            bool legal = addPerson.LegalAge();
            if (legal)
            {
                list.Add(addPerson);
            }
            else
            {
                Console.WriteLine("Cannot add person who is under 18.");
            }
        }



    }
}
