using CW17.Models.Entity;
using CW17.Models.Servise;
using Microsoft.AspNetCore.Mvc;

namespace CW17.Controllers
{
    public class CategoryController:Controller
    {
		CategoryServise categoryServise = new CategoryServise();
        UserServise user = new UserServise();


        public IActionResult index(string username,string password)
        {
            if (UserController.OnUser != null)
            {
                var cat = categoryServise.Get();
                return View(cat);
            }
            return RedirectToAction("index", "Home");

        }
        public IActionResult Add(string name,string description,string username,string password)
        {
            if (UserController.OnUser != null)
            {
                Category category = new Category() { CategoryName = name, Description = description };
                categoryServise.Add(category);
                return RedirectToAction("index");
            }
            return RedirectToAction("index", "Home");
            
        }
    }
}
