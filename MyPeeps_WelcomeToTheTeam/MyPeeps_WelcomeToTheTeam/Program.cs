using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPeeps_WelcomeToTheTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation validate = new Validation();
            List<Person> personList = new List<Person>();
            bool cont = true;
            
            while (cont)
            {                
                bool fName = false;
                bool lName = false;
                bool isAge = false;
                bool isEmail = false;
                bool isSalary = false;
                bool isAddress = false;
                bool teacherFlag = false;
                string firstName = "";
                string lastName = "";
                string sAge = "";
                int age = 0;
                string sSalary = "";
                string address = "";
                int salary = 0;
                string email = "";
                
                Console.WriteLine("Lets add a person to your list!" );

                bool teacherexit = true;
                while (teacherexit)
                {
                    Console.WriteLine("Would you like to add a team member to your list? (y/n)");

                    bool? answer = validate.YesNo(Console.ReadLine(), "Not a valid answer.Try again.");
                    if (answer == true)
                    {
                        teacherFlag = true;
                        break;
                    }
                    else if (answer == false)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }


                Console.WriteLine("Enter the First Name of the person you wish to add:");
                while (!fName)
                {
                    firstName = Console.ReadLine();
                    fName = validate.String(firstName, @"^[A-Za-z]{1,30}$", "Not a valid response. Please try again");
                }

                Console.WriteLine("Enter the Last Name of the person you wish to add:");                
                while (!lName)
                {
                    lastName = Console.ReadLine();
                    lName = validate.String(lastName, @"^[A-Za-z]{1,30}$", "Not a valid response. Please try again");
                }

                Console.WriteLine("Enter the Age of the person you wish to add:");
                while (!isAge)
                {
                    sAge = Console.ReadLine();
                    isAge = validate.String(sAge, @"^\d?\d\d?$", "Not a valid response. Please try again");
                    if (isAge)
                    {
                        age = Convert.ToInt32(sAge);
                    }

                }

                Console.WriteLine("Enter the email of the person you wish to add:");
                while (!isEmail)
                {
                    email = Console.ReadLine();
                    isEmail = validate.String(email, @"^[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}\.[a-zA-Z]{2,3}$", "Not a valid response. Please try again");
                }
                
                if(teacherFlag == true)
                {
                    Console.WriteLine("Enter the Salary of the person you wish to add:");
                    while (!isSalary)
                    {
                        sSalary = Console.ReadLine();
                        isSalary = validate.String(sSalary, @"^\d|\d\d|\d?$", "Not a valid response. Please try again");
                        if (isSalary)
                        {
                            salary = Convert.ToInt32(sSalary);
                        }
                    }

                    Console.WriteLine("Enter the Address of the person you wish to add:");
                    while (!isAddress)
                    {
                        address = Console.ReadLine();
                        isAddress = validate.String(address, @".", "Not a valid response. Please try again");
                    }

                }
                

                if (!teacherFlag)
                {
                    Person newPerson = new Person(firstName, lastName, age, email);
                    newPerson.AddPerson(personList);
                    Console.WriteLine($"Here is every person in your list:\n");
                    foreach (Person p in personList)
                    {
                        Console.WriteLine($"\tName: {p.FirstName} {p.LastName}\n" +
                                          $"\tAge: {p.Age}\n" +
                                          $"\tEmail: {p.Email}\n");
                    }
                }
                else
                {
                    Person newTeamMember = new TeamMember(firstName, lastName, age, email, salary, address);
                    newTeamMember.AddPerson(personList);
                    Console.WriteLine($"Here is every person in your list:\n");
                    foreach (TeamMember p in personList)
                    {
                        Console.WriteLine($"\tName: {p.FirstName} {p.LastName}\n" +
                                          $"\tAge: {p.Age}\n" +
                                          $"\tEmail: {p.Email}\n" +
                                          $"\tSalary: {p.Salary}\n" +
                                          $"\tAddress: {p.Address}\n");
                    }



                }




                bool exit = true;
                while (exit)
                {
                    Console.WriteLine("Do you want to add another person to your list? (y/n)");
                    
                    bool? answer = validate.YesNo(Console.ReadLine(), "Not a valid answer.Try again.");
                    if (answer == true)
                    {
                        break;
                    }
                    else if (answer == false)
                    {
                        cont = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            
            }

        }


    }
}
