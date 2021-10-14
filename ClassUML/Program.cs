using System;
using System.Collections.Generic;

namespace ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            //USE THIS SPACE FOR TESTING

            //Person a = new Person("Shrek", "123 Swamp");
            //Console.WriteLine(a.ToString());

            //Student b = new Student("P Sherman", "42 Wallaby Way, Sydney", "Marine Biology", 2, 4000);
            //Console.WriteLine(b.ToString());

            //Staff c = new Staff("Snape", "23 Hogwarts Lane", "Hogwarts", 4000);
            //Console.WriteLine(c.ToString());

            List<Person> people = new List<Person>
            {
                new Student("P Sherman", "42 Wallaby Way, Sydney", "Marine Biology", 2, 4000),
                new Student("George Costanza", "New York", "Architecture", 4, 100000),
                new Student("Jerry Seinfeld", "New York", "Comedy", 4, 100000),
                new Staff("Kramer", "New York", "School of Hard Knocks", 200000),
                new Staff("Snape", "23 Hogwarts Lane", "Hogwarts", 4000)
            };

            Person test = newPerson();
            people.Add(test);

            foreach(Person p in people)
            {
                Console.WriteLine(p.ToString());
            }
        }

        static Person newPerson()
        {
            Console.WriteLine("Is this person a student or staff?");
            Person result = null;
            while (true)
            {
                string choice = Console.ReadLine();
                if (choice == "student")
                {
                    result = newStudent();
                    break;
                }
                else if (choice == "staff")
                {
                    result = newStaff();
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid choice.");
                }
            }

            return result;
        }

        static Student newStudent()
        {
            Console.WriteLine("Enter the student's name.");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the student's address.");
            string address = Console.ReadLine();

            Console.WriteLine("Enter the student's program.");
            string program = Console.ReadLine();

            Console.WriteLine("Enter the student's year.");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fee for the student.");
            double fee = double.Parse(Console.ReadLine());

            //new student
            Student result = new Student(name, address, program, year, fee);
            return result;
        }

        static Staff newStaff()
        {
            Console.WriteLine("Enter the staff's name.");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the staff's address.");
            string address = Console.ReadLine();

            Console.WriteLine("Enter the school");
            string school = Console.ReadLine();

            Console.WriteLine("Enter the pay");
            double pay = double.Parse(Console.ReadLine());

            Staff result = new Staff(name, address, school, pay);
            return result;

        }
    }
}
