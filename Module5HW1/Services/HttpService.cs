using Module5HW1.Interfaces;

namespace Module5HW1.Services
{
    public class HttpService : IHttpService
    {
        public async Task SendAsync(HttpRequestMessage? httpMessage)
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.SendAsync(httpMessage!);
            }
        }
    }
}
