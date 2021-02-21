using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
   public  class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//C:\Users\Toshiba\AppData\Local\Microsoft\Microsoft SQL
            //Server Local DB\Instances\MSSQLLocalDB
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
Database=Northwind;Trusted_Connection=true"); 
                    }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
