﻿using CW17.Models.Entity;
using CW17.Models.Repository;
using Microsoft.EntityFrameworkCore;

namespace CW17.Models.Servise
{
    public class CategoryServise
    {
        private readonly CategoryRepository _category;
        public CategoryServise()
        {
            _category = new CategoryRepository();
        }
        public List<Category> Get()
        {
            var c = _category.Get();
            return c;
        }
        public void Add(Category category) 
        {
            _category.Add(category);
        }
        public void Update(int id) 
        {
            _category.Update(id);
        }
        public void Delete(int id) 
        {
            _category.Delete(id);
        }
		public Category Show(int id)
		{
			return _category.Show(id);
		}
	}
}