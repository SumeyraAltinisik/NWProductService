using Newtonsoft.Json;
namespace NWTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Categories().ConfigureAwait(true);
        //http://localhost:5093/
            Console.WriteLine("Hello, World!");
        }
        static async Task Categories()
        {
            using (var httpClient = new HttpClient())
            {
                using(var response = await httpClient.GetAsync("http://localhost:5093/api/satis/Product/GetCategories"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var listem = JsonConvert.DeserializeObject(apiResponse);
                }
            }
        }

    }
}