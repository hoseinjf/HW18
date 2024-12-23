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

        [HttpGet]
        public IActionResult Update(int id) 
        {
            if (UserController.OnUser != null)
            {
                var category = categoryServise.Show(id);
                return View(category);
            }
            return RedirectToAction("index", "Home");

        }

        [HttpPost]
        public IActionResult UpdateCategory(int id, string name, string description)
        {
            if (UserController.OnUser != null)
            {
                categoryServise.Update(id,name,description);
                return RedirectToAction("index");
            }
            return RedirectToAction("index", "Home");
        }


        [HttpGet]
        public IActionResult Delete(int id) 
        {
            if (UserController.OnUser != null)
            {
                categoryServise.Delete(id);
                return RedirectToAction("index");
            }
            return RedirectToAction("index", "Home");
        }
    }
}
