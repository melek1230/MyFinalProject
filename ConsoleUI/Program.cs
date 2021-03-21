using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntitiyFramework;
//using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
             ProductTest();
           // NewMethod();
            //9gün();

        }

        //private static void 9gün()
        //{
        //    ProductManager productManager = new ProductManager(
        //        new EFProductDal());

        //    foreach (var product in productManager.GetProductDetails())
        //    {
        //        Console.WriteLine(product.ProductName + "   /   "
        //            + product.CategoryName);
        //    }
        //}

        private static void NewMethod()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());
            //ya da 
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            var result = productManager.GetProductDetails();
            if(result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName+"  /"+product.CategoryName);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
