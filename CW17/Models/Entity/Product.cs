namespace CW17.Models.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Pric { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
