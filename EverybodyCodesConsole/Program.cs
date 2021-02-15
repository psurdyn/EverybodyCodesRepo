using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EverybodyCodesConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();

            var resp = await client.GetAsync("https://localhost:44330/api/geographiccoordinates/all/formatted");
            var stringResponse = await resp.Content.ReadAsStringAsync();

            Console.WriteLine(stringResponse);
        }
    }
}
