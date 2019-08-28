
using Microsoft.AspNetCore.Mvc;

namespace Circles_API.Controllers
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