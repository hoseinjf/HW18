using CW17.Models.DB;
using CW17.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace CW17.Models.Repository
{
    public class ProductRepository
    {
        private readonly AppDbContext _context;
        private readonly CategoryRepository _categoryRepository;
        public ProductRepository()
        {
            _context = new AppDbContext();
        }
        public List<Product> Get()
        {
            var c = _context.Products.Include(p=> p.Category).ToList();
            return c;
        }
        public List<Category> GetCategory()
        {
            var c = _context.Categories.ToList();
            return c;
        }
        public void Add(Product product)
        {
            var product1 = new Product()
            {
                ProductName = product.ProductName,
                Pric = product.Pric,
                Description = product.Description,
                CategoryId = product.CategoryId,

            };
            _context.Products.Add(product1);
            _context.SaveChanges();
        }

        public Product Show(int id)
        {
            var pro = _context.Products.FirstOrDefault(x => x.Id == id);
            return pro;
        }

        public Product Update(int id, string name, string description, double pric)
        {
            var c = _context.Products.FirstOrDefault(c => c.Id == id);
            c.Id = id;
            c.ProductName = name;
            c.Pric = pric;
            c.Description = description;
            _context.SaveChanges();
            return c;
        }
        public void Delete(int id)
        {
            var c = _context.Products.FirstOrDefault(c => c.Id == id);
            _context.Products.Remove(c);
            _context.SaveChanges();
        }
    }
}
