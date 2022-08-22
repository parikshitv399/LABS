using ProductLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductLab.Product_Repo
{
    public class ProductOps
    {
        private readonly static List<Product> _product = new List<Product>();
        public List<Product> GetAll()
        {
            if (_product.Count == 0)
            {
                _product.Add(new Product() { Id = 1, Name = "Samsung Galaxy M31S", Price = 18000, Category = "Mobile Phone" });
                _product.Add(new Product() { Id = 2, Name = "Milton Model 11010", Price = 400, Category = "Kitchenware" });
            }
            return _product;
        }
        public Product GetSingle(int pId)
        {
            return _product.Find(x => x.Id == pId);
        }
        public void Add(Product newProd)
        {
            _product.Add(new Product()
            {
                Id = newProd.Id,
                Name = newProd.Name,
                Category = newProd.Category,
                Price = newProd.Price
            });
        }
        public bool Update(int id, Product pProduct)
        {
            Product FoundProduct = GetSingle(id);
            if (FoundProduct != null)
            {
                FoundProduct.Name = pProduct.Name;
                FoundProduct.Category = pProduct.Category;
                FoundProduct.Price = pProduct.Price;
                return true;
            }
            throw new Exception("Product not found");
        }
        public void Delete(Product pProduct)
        {
            _product.Remove(_product.Find(x => x.Id == pProduct.Id));
        }
        public Product GetProductsByCategory(string pCategory)
        {
            return _product.Find(x => x.Category == pCategory);
        }
    }
}