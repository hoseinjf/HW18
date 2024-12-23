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



        [HttpGet]
        public IActionResult Update(int id)
        {
            if (UserController.OnUser != null)
            {
                var product = productServise.Show(id);
                return View(product);
            }
            return RedirectToAction("index", "Home");

        }

        [HttpPost]
        public IActionResult UpdateProduct(int id, string name, string description,double pric)
        {
            if (UserController.OnUser != null)
            {
                productServise.Update(id, name, description,pric);
                return RedirectToAction("index");
            }
            return RedirectToAction("index", "Home");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (UserController.OnUser != null)
            {
                productServise.Delete(id);
                return RedirectToAction("index");
            }
            return RedirectToAction("index", "Home");
        }


    }
}
