using System;
using System.Collections.Generic;
using Autofac;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
           var builder = new ContainerBuilder();
            builder.RegisterType<Program>().AsSelf();
            var program = builder.Build().Resolve<Func<Program>>();

        }
    }



















//    var builder = new ContainerBuilder();


//    builder.RegisterType<SaveCommand>()
//    .Named<ICommand>("handler");
//    builder.RegisterType<OpenCommand>()
//    .Named<ICommand>("handler");

//    builder.RegisterDecorator<ICommand>(
//    (c, inner) => new CommandHandlerDecorator(inner),
//    fromKey: "handler");

//    var container = builder.Build();

//    var handlers = container.Resolve<IEnumerable<ICommand>>();
//    foreach (var handler in handlers)
//    {
//    handler.Execute();
//    }

//public class CommandHandlerDecorator : ICommand
//    {
//        private readonly ICommand _command;

//        public CommandHandlerDecorator(ICommand command)
//        {
//            _command = command;
//        }

//        public void Execute()
//        {
//            Console.WriteLine("Decorator start");
//            _command.Execute();
//            Console.WriteLine("Decorator end");
//        }
//    }

//    public interface ICommand
//    {
//        void Execute();
//    }

//    public class OpenCommand : ICommand
//    {
//        public void Execute()
//        {
//            Console.WriteLine("Open");
//        }
//    }
//    public class SaveCommand : ICommand
//    {
//        public void Execute()
//        {
//            Console.WriteLine("Save");
//        }
//    }
}
