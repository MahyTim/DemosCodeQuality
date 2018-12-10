using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoCDefault.Services
{
    public class EmailService<TEntity> : IEmailService<TEntity>
    {
        public void Send(String to, String message)
        {
            Console.WriteLine($"Sending email to {to} with message {message}");
        }

        public void Dispose()
        {
            Console.WriteLine("Shutting down mailserver");
        }
    }
}
