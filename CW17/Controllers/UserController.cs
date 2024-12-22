using CW17.Models.Entity;
using CW17.Models.Servise;
using Microsoft.AspNetCore.Mvc;

namespace CW17.Controllers
{
    public class UserController : Controller
    {
        private readonly UserServise _userServise = new UserServise();
        public static User OnUser { get; set; }

        [HttpGet]
        public IActionResult LoginGet(string username, string password)
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var log = _userServise.Login(username, password);
            if (log == true)
            {
                OnUser = new User()
                {
                    Username = username,
                    Password = password
                };
                return RedirectToAction("index","RootUser");
            }
            else
            {
                return RedirectToAction("RegisterGet","User");
            }
        }


        [HttpGet]
        public IActionResult RegisterGet(string username, string password)
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(string username, string password)
        {
            var reg = _userServise.Register(username, password);
            if (reg != null)
            {
                return RedirectToAction("LoginGet","User");
            }
            else
            {
                return RedirectToAction("index", "Home");
            }
        }
    }
}
