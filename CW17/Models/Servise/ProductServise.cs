using CW17.Models.Entity;
using CW17.Models.Repository;

namespace CW17.Models.Servise
{
    public class ProductServise
    {
        private readonly ProductRepository repository;
        public ProductServise()
        {
            repository = new ProductRepository();
        }
        public List<Product> Get()
        {
            var c = repository.Get();
            return c;
        }
        public void Add(Product product) 
        {
            repository.Add(product);
        }
        public void Update(int id) 
        {
            repository.Update(id);
        }
        public void Delete(int id) 
        {
            repository.Delete(id);
        }

    }
}
