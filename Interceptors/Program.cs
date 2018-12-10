using System;
using System.IO;
using System.Linq;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;

namespace Interceptors
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SaveCommand>()
                .As<ICommand>()
                .EnableInterfaceInterceptors();            

            builder.Register(c => new CallLogger(Console.Out))
                .Named<IInterceptor>("log-calls");
            builder.Register(c => new CallLogger(Console.Out));

            var command = builder.Build().Resolve<ICommand>();
            command.Execute("Tim");
        }
    }

    public class SaveCommand : ICommand
    {
        public void Execute(string s)
        {
            Console.WriteLine(s);
        }
    }

    public interface ICommand
    {
        void Execute(string s);
    }

    public class CallLogger : IInterceptor
    {
        TextWriter _output;

        public CallLogger(TextWriter output)
        {
            _output = output;
        }

        public void Intercept(IInvocation invocation)
        {
            _output.Write("Calling method {0} with parameters {1}... ",
                invocation.Method.Name,
                string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()));

            invocation.Proceed();

            _output.WriteLine("Done: result was {0}.", invocation.ReturnValue);
        }
    }
}
