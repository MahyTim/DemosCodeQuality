using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Timeout;

namespace FailOften
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ValidateEmailClient(new HttpClient());
            while (true)
            {
                var s = client.GetEmail("test@test.be").Result;
                Console.WriteLine(s);
            }
        }
    }

    public class ValidateEmailClient
    {
        private HttpClient _client;

        public ValidateEmailClient(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri($"https://extremegoverner.azurewebsites.net");
        }

        public async Task<string> GetEmail(string email)
        {
            var emailUrl = new Uri($"/api/externalusers?email=test@test.be{email}", UriKind.Relative);
            var res = await _client.GetAsync(emailUrl);
            Console.WriteLine("Request performed");
            if (res.IsSuccessStatusCode)
            {
                return await res.Content.ReadAsStringAsync();
            }
            throw new NotSupportedException("Error reading result");
        }
    }
}
