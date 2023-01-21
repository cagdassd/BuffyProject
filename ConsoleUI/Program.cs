using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();

            ProductManager productManager2 = new ProductManager(new EfProductDal());

            TransactionManager transactionManager = new TransactionManager(new EfTransactionDal());

            var result = productManager2.GetProductDetails();
            if (result.IsSuccess)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            var result2 = transactionManager.GetAll();
            foreach (var item in result2.Data)
            {
                Console.WriteLine(item.DeliveryStatus);
            }
            

            /*
            foreach (var product in productManager2.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName + " " + product.CategoryName + " " + product.BrandName);
            }
            */

            /*foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine( "----------------------");
            productManager.Add(product1);
            
            Console.WriteLine("----------------------");
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("----------------------");
            
            Console.WriteLine(productManager.GetById(2).ProductName);
            

            Console.WriteLine("----------------------");
            */
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Product product1 = new Product();
            product1.ProductId = 15;
            product1.ProductName = "Test";
            product1.UnitPrice = 10;
            product1.UnitsInStock = 10;
            product1.CategoryId = 1;

            foreach (var item in productManager.GetAll().Data)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine(productManager.GetById(3).Data.ProductName);
        }
    }
}
