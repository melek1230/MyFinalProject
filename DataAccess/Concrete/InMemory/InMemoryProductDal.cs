using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
        {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                    new Product{ ProductId=1,CategoryId = 1,ProductName="Bardak",UnitPrice=15,UnitInStock=15 },
                    new Product{ ProductId=2,CategoryId = 1,ProductName="Kamera",UnitPrice=500,UnitInStock=3 },
                    new Product{ ProductId=3,CategoryId = 2,ProductName="Vazo",UnitPrice=15,UnitInStock=6 }

            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<ThreadStaticAttribute, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int CategoryId)
        {
            return _products.Where(p => p.CategoryId == CategoryId).ToList();

        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitInStock = product.UnitInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
            _products.Remove(productToUpdate);
        }

        public void UpDate(Product entity)
        {
            throw new NotImplementedException();
        }
    }
       
    
}
