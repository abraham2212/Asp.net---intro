using Microsoft.AspNetCore.Mvc;

namespace Asp.net___intro_Hometask.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {

            var users = new List<string>() { "Ali", "Leyla", "Pervin",  "Ibrahim"  };

            return View(users);
        }
    }
}
