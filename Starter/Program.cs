using System;

namespace Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            LastNameAssignerAlgorithm.Process((text) =>
                {
                    Console.WriteLine(text);
                    return Console.ReadLine();
                },
                Console.WriteLine,
                new RandomLastNameGenerator().Generate);
        }
    }
}


























