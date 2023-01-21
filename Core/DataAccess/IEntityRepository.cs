using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
        //where T : class = referans tip olabilir demek yani int falan olamaz demek
        //IEntity = T yerine Yalnızca IEntity olan veya onu implemente eden classlar verilebilir
        //new() = new lenebilir olmalı yani IEntity olamaz yalnızca brand , product, category olabilir.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        //burada getall yaparken içine expression yazabilmeyi sağladık örneğin aşağıda getbyid kullanmıştık bunun yerine artık p=>p.productId == product.productId gibi expressionlar kullanabileceğiz. bunun için getbyid i yoruma alıyorum

        // Product GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
