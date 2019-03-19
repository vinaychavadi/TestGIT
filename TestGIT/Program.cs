using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;

namespace TestGIT
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeRequest();


           

        }

        private static async Task MakeRequest()
        {
            Console.WriteLine("Making Request again with Changes");
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(new Uri("https://247-dev.atlassian.net/rest/webhooks/webhook1"));
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
            Console.ReadLine();
        }
    }
}
