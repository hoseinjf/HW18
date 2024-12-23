﻿using CW17.Models.DB;
using CW17.Models.Entity;

namespace CW17.Models.Repository
{
    public class CategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository()
        {
            _context = new AppDbContext();
        }
        public List<Category> Get()
        {
            var c = _context.Categories.ToList();
            return c;
        }
        public void Add(Category category)
        {
            var category1 = new Category()
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                Description = category.Description,

            };
            _context.Categories.Add(category1);
            _context.SaveChanges();
        }
        public Category Show(int id)
        {
            var car = _context.Categories.FirstOrDefault(x => x.Id == id);

            return car;
        }
        public Category Update(int id, string name, string description)
        {
            var c = _context.Categories.FirstOrDefault(x => x.Id == id);

            c.Id=id;
            c.CategoryName=name;
            c.Description=description;
            _context.SaveChanges();
            return c;
        }
        public void Delete(int id)
        {
            var c = _context.Categories.FirstOrDefault(c => c.Id == id);
            _context.Categories.Remove(c);
            _context.SaveChanges();
        }
    }
}
