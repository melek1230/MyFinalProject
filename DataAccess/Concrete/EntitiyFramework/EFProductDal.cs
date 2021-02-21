using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Concrete.EntitiyFramework
{
    public class EFProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            // I Disposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                    }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletededEntity = context.Entry(entity);
                deletededEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using(NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        //public List<Product> GetAll()
        //{
        //    return new List<Product> { new Product { ProductName="tablo"},
        //                               new Product  {ProductName="vazo" }};
        //}

        public List<Product> GetAll(Expression<Func<Product, bool>>
            filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter ==null ? context.Set<Product>().ToList()
                     : context.Set<Product>().Where(filter).ToList();
            }
        }     
                   

        public void UpDate(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
