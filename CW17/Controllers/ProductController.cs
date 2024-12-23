using CW17.Models.Entity;
using CW17.Models.Servise;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
                productServise.GetCategory();
                ViewBag.Categories = new SelectList(productServise.GetCategory(), "Id", "CategoryName");

                return View(pro);
            }
            return RedirectToAction("index", "Home");
        }

        [HttpPost]
        public IActionResult Add(string name, double pric, string description,int categoryId,string username,string password)
        {
            if (UserController.OnUser != null)
            {
                Product product = new Product()
                {
                    ProductName = name,
                    Description = description,
                    Pric = pric,
                    CategoryId = categoryId,
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
