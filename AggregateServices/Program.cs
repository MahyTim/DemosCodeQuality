using System;
using Autofac;
using Autofac.Extras.AggregateService;

namespace AggregateServices
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterAggregateService<IMyAggregateService>();
            var s = builder.Build().Resolve<IMyAggregateService>();
            s.Name = "Test";
            Console.WriteLine(s.Name);

        }
    }

    interface IMyAggregateService
    {
        string Name { get; set; }
    }
}
