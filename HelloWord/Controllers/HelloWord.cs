using Microsoft.AspNetCore.Mvc;

namespace HelloWord.Controllers
{
    public class HelloWord : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
