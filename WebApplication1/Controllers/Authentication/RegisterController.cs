using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.Authentication
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
