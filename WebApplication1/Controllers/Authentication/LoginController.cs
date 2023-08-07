using ApplicationCore.Interface;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.Authentication
{
    public class LoginController : Controller
    {
        //private readonly IGeneralRepository<User, int> _user;
        private readonly IUserRepository _user;

        public LoginController(IUserRepository user)
        {
            _user = user;
        }
        public IActionResult Index()
        {
            var k = _user.GetAll();
            return View();
        }
    }
}
