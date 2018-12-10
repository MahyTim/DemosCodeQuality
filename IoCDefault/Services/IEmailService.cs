using System;

namespace IoCDefault.Services
{
    public interface IEmailService<TEntity> : IDisposable
    {
        void Send(string to, string message);
    }
}