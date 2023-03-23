using System.Xml.Linq;

namespace AspNetCoreWeb.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>()
        {
             new () { Id = 1, Name = "Kalem", Price = 100, Stock = 100 },
             new () { Id = 2, Name = "Kalem", Price = 200, Stock = 300 },
             new () { Id = 3, Name = "Kalem", Price = 300, Stock = 200 }

        };

      

        public void Add(Product newProduct) => _products.Add(newProduct);

        public void Remove(int id)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == id);
            if (hasProduct == null)
            {
                throw new Exception($"Bu ıd({id}) ye sahip ürün yoktur");
            }
            _products.Remove(hasProduct);
        }

        public void Update(Product updateproduct)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == updateproduct.Id);

            if (hasProduct == null)
            {
                throw new Exception($"Bu ıd({updateproduct.Id}) ye sahip ürün yoktur");
            }

            hasProduct.Name = updateproduct.Name;
            hasProduct.Price = updateproduct.Price;
            hasProduct.Stock = updateproduct.Stock;

            var index = _products.FindIndex(x => x.Id == updateproduct.Id);

            _products[index] = hasProduct;
        }

        public static implicit operator ProductRepository(AppDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}
