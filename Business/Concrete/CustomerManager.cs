using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer Customer)
        {
            _customerDal.Add(Customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer Customer)
        {
            _customerDal.Delete(Customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>();
        }

        public IResult Update(Customer Customer)
        {
            _customerDal.Update(Customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
