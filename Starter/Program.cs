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

            }
        }
    }
}



















