using System;

namespace PersonTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int total = 3;
            Person[] persons = new Person[total];
            Console.WriteLine("Enter 3 Person Name");
            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Enter name is " + Name;
        }

        ~Person()
        {
            Name = string.Empty;
        }
    }
}