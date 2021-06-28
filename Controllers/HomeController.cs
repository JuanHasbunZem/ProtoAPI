using Microsoft.AspNetCore.Mvc;
using ProtoAPI.Models;

namespace ProtoAPI.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allMessages = Message.GetMessages(EnvironmentVariables.ApiKey);
            return View(allMessages);
        }
    }
}