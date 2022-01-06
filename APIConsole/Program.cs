using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://zoo-animal-api.herokuapp.com/");
            string response = await client.GetStringAsync("animals/rand/3"); // Every function you make asynchronous (async) needs to be inside another asynchronous function. This is why you put async up in Main. However, because it's asynchronous, you can't just return something (ex: void). Therefore you have to put Task in Main as well. Therefore we have to do using System.Threading.Tasks;
            Console.WriteLine(response);
        }
    }
}
