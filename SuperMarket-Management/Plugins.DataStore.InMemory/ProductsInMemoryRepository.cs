using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductsInMemoryRepository : IProductRepository
    {
        private List<Product> products;
        public ProductsInMemoryRepository()
        {
            products = new List<Product>()
            {
                new Product{ProductId=1,CategoryId=1,Name="Ice Tea",Quantity=10,Price=30},
                new Product{ProductId=2,CategoryId=1,Name="Canada Tea",Quantity=30,Price=90},
                new Product{ProductId=3,CategoryId=2,Name="Burger",Quantity=20,Price=20}



            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;
            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }

            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(x => x.ProductId == productId);
        }
        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate != null) productToUpdate = product;
        }

        public void DeleteProduct(int productId)
        {
            products?.Remove(GetProductById(productId));
        }
        public IEnumerable<Product> GetProductByCategoryId(int categoryId)
        {
            return products.Where(x => x.CategoryId == categoryId);
        }
    }
}
