using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
                    new Product{ ProductId=1,CategoryId = 1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15 },
                    new Product{ ProductId=2,CategoryId = 1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3 },
                    new Product{ ProductId=3,CategoryId = 2,ProductName="Vazo",UnitPrice=15,UnitsInStock=6 }

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

       

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

       

        public List<Product> GetAllByCategoryId(int CategoryId)
        {
            return _products.Where(p => p.CategoryId == CategoryId).ToList();

        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void UpDate(Product entity)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            productToUpdate.ProductName = entity.ProductName;
            productToUpdate.CategoryId = entity.CategoryId;
            productToUpdate.UnitsInStock = entity.UnitsInStock;
            productToUpdate.UnitPrice = entity.UnitPrice;
            _products.Remove(productToUpdate);
        }

       


    }
       
    
}
