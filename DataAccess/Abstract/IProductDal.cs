﻿
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
        //List<Product> GetAllByCategoryId(int CategoryId);
        //List<Product> GetAll();
        //void Add(Product product);
        //void Delete(Product product);
        //void Update(Product product);
    }
}
