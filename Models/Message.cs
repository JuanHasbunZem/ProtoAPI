using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ProtoAPI.Models
{
  public class Message
  {
    public string UserName { get; set; }
    public DateTime PostTime { get; set; }
    
    public static List<Message> GetMessages(string apiKey)
    {
      var apiCallTask = ApiHelper.ApiCall(apiKey);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Message> MessageList = JsonConvert.DeserializeObject<List<Message>>(jsonResponse["results"].ToString());

      return MessageList;
    }
  }
}