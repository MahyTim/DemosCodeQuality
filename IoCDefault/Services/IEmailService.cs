namespace IoCDefault.Services
{
    public interface IEmailService
    {
        void Send(string to, string message);
    }
}