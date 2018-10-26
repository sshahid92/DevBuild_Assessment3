using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPeeps_WelcomeToTheTeam
{
    class TeamMember : Person
    {
        public int Salary { get; set; }
        public string Address { get; set; }

        public TeamMember (string firstName, string lastName, int age, string email,
            int salary, string address) : base(firstName, lastName, age, email)
        {
            Salary = salary;
            Address = address;

        }

        public override void AddPerson(List<Person> list)
        {
            Person addPerson = new TeamMember(FirstName, LastName, Age, Email, Salary, Address);
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
