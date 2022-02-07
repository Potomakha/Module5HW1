using System;
using System.Text;
using Module5HW1.Modules;
using Module5HW1.Services;
using Newtonsoft.Json;

namespace Module5HW1
{
    public class Program
    {
        public static async Task Main()
        {
            var httpContent = new StringContent(JsonConvert.SerializeObject(new Users()), Encoding.UTF8, "application/json");
            var httpService = new HttpService();

            var httpMessage = new HttpRequestMessage();
            httpMessage.RequestUri = new Uri(@"https://reqres.in/api/users");
            httpMessage.Method = HttpMethod.Get;
            await httpService.SendAsync(httpMessage!);
        }
    }
}