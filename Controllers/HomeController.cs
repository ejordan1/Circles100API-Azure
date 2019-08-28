
using Microsoft.AspNetCore.Mvc;

namespace MessagesServer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public int Index()
        {
            return 23042323;
        }
    }
}