using System;
using Bogus;
using Bogus.DataSets;

namespace Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            LastNameAssigner.Process();
        }
    }


    class Person
    {
        public int Age { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }

    class LastNameAssigner
    {
        public static void Process()
        {
            while (true)
            {
                var person = new Person
                {
                    Firstname = Console.ReadLine(),
                    Lastname = new Faker<Person>("nl")
                        .RuleFor(z => z.Lastname, z => z.Name.LastName(Name.Gender.Male))
                        .Generate()
                        .Lastname
                };

                Console.WriteLine($"Hello {person}");
            }
        }
    }
}


























