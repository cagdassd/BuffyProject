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



        //gerçek bir database ile çalışmadığım için geçici bir database oluşturacağım burada

        List<Product> _products;



        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product() { ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=20, UnitsInStock=10, Description="Cam Bardak" },
                new Product() { ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=260, UnitsInStock=5, Description="Kaliteli bir kamera" },
                new Product() { ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=250, UnitsInStock=13, Description="IPhone 11" },
                new Product() { ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=202, UnitsInStock=16, Description="Rampage Klavye" },
                new Product() { ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=30, UnitsInStock=80, Description="Logitech G102" }
            };
        }

        //burdan bi referans aldığımızda otomatikmen bir database oluşturması için böyle bir constructor yazdık
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

        public Product GetById(int id)
        {
            return _products.SingleOrDefault(p=>p.ProductId== id);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
