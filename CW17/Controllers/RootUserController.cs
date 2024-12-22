using CW17.Models.Servise;
using Microsoft.AspNetCore.Mvc;

namespace CW17.Controllers
{
    public class RootUserController : Controller
    {
        UserServise user = new UserServise();
        public IActionResult index(string username, string password)
        {
            if (UserController.OnUser!=null)
            {
                return View();
            }
            return RedirectToAction("index", "Home");
        }
    }
}
