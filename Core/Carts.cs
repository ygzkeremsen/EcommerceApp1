using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class Cart
    {
        public List<Product> Products = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public double GetTotalPrice()
        {
            double total = Products.Sum(p => p.Price);
            return total * 0.9; // HATA
        }
    }
}