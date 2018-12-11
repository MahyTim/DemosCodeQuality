using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Primitives
{
    class Program
    {
        static void Main(string[] args)
        {

           
        }
    }
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public uint Age { get; set; }
    }
}
