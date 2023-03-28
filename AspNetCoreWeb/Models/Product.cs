namespace AspNetCoreWeb.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal? Price { get; set; }

        public int? Stock { get; set; }

        public string? Color { get; set; }

        public bool furniture { get; set; }

        public int Expire { get; set; }
    }
}
