using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Person> people = new Queue<Person>();

            while (true)
            {
               
                Menu.display();

                switch (Menu.userchoice())
                {
                    case 1:
                        people.Enqueue(AddPerson());
                        break;
                    case 2:
                        Person deletedPerson = people.Dequeue();
                        Console.WriteLine($"Person getting removed; Name: {deletedPerson.Name}, Age: {deletedPerson.Age}");
                        break;
                    case 3:
                        Console.WriteLine($"Count: {people.Count}");
                        break;
                    case 4:
                        int max = people.Max(x => x.Age);
                        int min = people.Min(x => x.Age);

                        Console.WriteLine($"Max age: {max}");
                        Console.WriteLine($"Min age: {min}");
                        break;
                    case 5:
                        Console.WriteLine("Write the name: ");
                        string searchName = Console.ReadLine();

                        List<Person> SearchList = people.Where(x => searchName == x.Name).ToList();

                        Console.WriteLine();
                        foreach (Person person in SearchList)
                        {
                            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                        }

                        break;
                    case 6:
                        foreach (Person person in people)
                        {
                            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                        }

                        break;
                    case 7:
                        Environment.Exit(1);
                        break;


                    default:
                        break;
                }

                Console.ReadKey();
            }
            

        }

        static Person AddPerson() 
        {
            Console.Clear();

            Console.WriteLine("Write the name: ");
            string name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Write the age: ");
            int age = 0;
            while (!int.TryParse(Console.ReadLine(),out age))
            {
                Menu.errorMessage(3);
            }


            return new Person() { Name = name, Age = age };
        
        }

    }
}
