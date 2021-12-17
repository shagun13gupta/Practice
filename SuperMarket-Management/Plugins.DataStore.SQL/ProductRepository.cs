using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class ProductRepository : IProductRepository
    {
        private readonly MarketContext context;

        public ProductRepository(MarketContext context)
        {
            this.context = context;
        }

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = context.Products.Find(productId);
            if (product == null) return;
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public IEnumerable<Product> GetProductByCategoryId(int categoryId)
        {
            return context.Products.Where(x => x.CategoryId == categoryId).ToList();
        }

        public Product GetProductById(int productId)
        {
            return context.Products.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            var prod = context.Products.Find(product.ProductId);
           
            prod.CategoryId = product.CategoryId;
            prod.Name = product.Name;
            prod.Price = product.Price;
            prod.Quantity = product.Quantity;
            context.SaveChanges();
        }
    }
}
