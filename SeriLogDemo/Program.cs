using System;
using System.Data.SqlClient;
using System.Security.Principal;
using Serilog;
using Serilog.Context;
using Serilog.Sinks.ContextRollingFile;
using Serilog.Sinks.Elasticsearch;

namespace SeriLogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .Enrich.FromLogContext()
                .WriteTo.Console(outputTemplate:"{Message}")
                .CreateLogger();

            int a = 10, b = 0;
            try
            {
                Log.Debug("Dividing {A} by {B}", a, b);
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, "Something went wrong");
            }
            Log.CloseAndFlush();
        }
    }
}
