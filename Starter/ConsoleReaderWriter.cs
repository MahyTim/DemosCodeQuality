using System;

namespace Starter
{
    public class ConsoleReaderWriter : IInputReader, IOutputWriter
    {
        public string Read(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        public void Write(string s)
        {
            Console.WriteLine(s);
        }
    }
}