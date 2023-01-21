using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, BuffyDbContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (BuffyDbContext context = new BuffyDbContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             join b in context.Brands
                             on p.BrandId equals b.BrandId
                             select new ProductDetailDto
                             {
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 BrandName = b.BrandName
                             };
                return result.ToList();
            }
            
        }
    }
}
