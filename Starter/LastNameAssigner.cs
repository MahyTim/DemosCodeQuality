using System;

namespace Starter
{
    class LastNameAssignerAlgorithm
    {
        public static void Process(Func<string,string> input, 
            Action<string> output, 
            Func<string> generator)
        {
            while (true)
            {
                var firstName = input("Please provide a firstname: ");
                var lastName = generator();
                var result = $"{firstName} {lastName}";
                output(result);
            }
        }
    }
}