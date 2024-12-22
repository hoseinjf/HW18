using CW17.Models.Entity;
using CW17.Models.Servise;
using Microsoft.AspNetCore.Mvc;

namespace CW17.Controllers
{
    public class ProductController : Controller
    {
        ProductServise productServise = new ProductServise();
        UserServise user = new UserServise();

        public IActionResult index(string username, string password)
        {
            if (UserController.OnUser != null)
            {
                var pro = productServise.Get();
                return View(pro);
            }
            return RedirectToAction("index", "Home");
        }
        public IActionResult Add(string name, double proc, string description,string username,string password)
        {
            if (UserController.OnUser != null)
            {
                Product product = new Product()
                {
                    ProductName = name,
                    Description = description,
                    Pric = proc
                };
                productServise.Add(product);
                return RedirectToAction("index");
            }
            return RedirectToAction("index", "Home");

        }
    }
}
