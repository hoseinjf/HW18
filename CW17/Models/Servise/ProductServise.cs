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
        public List<Category> GetCategory()
        {
            var c = repository.GetCategory();
            return c;
        }
        public void Add(Product product) 
        {
            repository.Add(product);
        }
        public void Update(int id, string name, string description, double pric)
        {
            repository.Update(id,name,description,pric);
        }
        public void Delete(int id) 
        {
            repository.Delete(id);
        }
        public Product Show(int id) 
        {
            return repository.Show(id);
        }

    }
}
