namespace AspNetCoreWeb.Models
{
    public class ProductRepository
    {
        private static List<product> _products = new List<product>()
        {
           new() { Id = 1, Name = "Kalem 1", Price = 100, Stock = 200 },
           new () { Id = 2, Name = "Kalem 2", Price = 200, Stock = 300 },
           new () { Id = 3, Name = "Kalem 3", Price = 300, Stock = 400 }
        };

        public List<product> GetAll() => _products;

        public void add(product newproduct) => _products.Add(newproduct);

        public void remove(int id)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == id);

            if (hasProduct == null)
            {
                throw new Exception($"Bu id({id})' ye sahip ürün bulunamadı.");
            }
            _products.Remove(hasProduct);
        }

        public void update(product updateproduct)
        {

            var hasproduct = _products.FirstOrDefault(x => x.Id == updateproduct.Id);

            if (hasproduct == null)
            {
                throw new Exception($"Bu id({updateproduct.Id})'ye sahip ürün bulunmamaktadır.");
            }
            hasproduct.Name = updateproduct.Name;
            hasproduct.Price = updateproduct.Price;
            hasproduct.Stock = updateproduct.Stock;

            var index = _products.FindIndex(x => x.Id == updateproduct.Id);

            _products[index] = hasproduct;

        }

    }
}
