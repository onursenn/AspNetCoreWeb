namespace AspNetCoreWeb.Models
{
    public class ProductRepository
    {
        private static List<Product> _products;

        public List<Product> GetAll() => _products;

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
                throw new Exception($"Bu ıd({id}) ye sahip ürün yoktur");
            }

            hasProduct.Name = updateproduct.Name;
            hasProduct.Price = updateproduct.Price;
            hasProduct.Stock = updateproduct.Stock;

            var index = _products.FindIndex(x => x.Id == updateproduct.Id);

            _products[index] = hasProduct;
        }
    }
}
