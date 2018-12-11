using System;

namespace Currying
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (x, y) => x + y;

            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());

            var result = add(first, second);

            Console.WriteLine(result);
        }


    }










    //Func<int, Func<int, int>> curriedAdd = x => y => x + y;
    //int b = curriedAdd(2)(3); // b = 5


    //var adder = curriedAdd(5);
    //int c = adder(3); // c = 8
    //int d = adder(5); // d = 10



    //Action<string, string> logger = (userName, message) => Console.WriteLine($"{userName} {message}");
    //logger("Tim", "Hello world");
    //logger("Tim", "Hello world 2");

    //Func<string, Action<string>> userLogger = (userName) => message => Console.WriteLine($"{userName} {message}");
    //var log = userLogger("Tim");
    //log("Hello world");
    //log("Hello world2");


    //static void LogToConsole(string username, string message)
    //{
    //Console.WriteLine($"{username} {message}");
    //}


    //Action<string, string> logger = LogToConsole;

    //public static class CurryHelper
    //{
    //    public static Action<T> Curry<T>(this Action<T, T> action, T arg1)
    //    {
    //        return arg2 => action(arg1, arg2);
    //    }
    //}

    //var userLogger = logger.Curry("Tim");
    //userLogger("Hello world");
    //userLogger("Hello world2");
}
