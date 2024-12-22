using CW17.Models.DB;
using CW17.Models.Entity;

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
            var c = _context.Products.ToList();
            return c;
        }
        public void Add(Product product)
        {
            var product1 = new Product()
            {
                ProductName = product.ProductName,
                Pric=product.Pric,
                Description=product.Description,
                CategoryId=product.CategoryId,

            };
            _context.Products.Add(product1);
            _context.SaveChanges();
        }

        public Product Update(int id)
        {
            var c = _context.Products.FirstOrDefault(c => c.Id == id);
            var product1 = new Product()
            {
                ProductName = c.ProductName,
                Pric = c.Pric,
                Description = c.Description,
                Category = c.Category,
                CategoryId = c.CategoryId,
            };
            _context.SaveChanges();
            return product1;
        }
        public void Delete(int id)
        {
            var c = _context.Products.FirstOrDefault(c => c.Id == id);
            _context.Products.Remove(c);
            _context.SaveChanges();
        }
    }
}
