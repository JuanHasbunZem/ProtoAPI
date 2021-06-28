using System.Threading.Tasks;
using RestSharp;

namespace ProtoAPI.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("[API ADDRESS]");
      RestRequest request = new RestRequest($"[API ENDPOINT]" /* in this format -> home.json?api-key={apiKey} */, Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}