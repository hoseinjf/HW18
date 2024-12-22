﻿namespace CW17.Models.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product>? Products { get; set; } = new List<Product>();

    }
}