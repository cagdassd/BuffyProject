using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer Customer);
        IResult Update(Customer Customer);
        IResult Delete(Customer Customer);
        IDataResult<List<Customer>> GetAll();
    }
}
