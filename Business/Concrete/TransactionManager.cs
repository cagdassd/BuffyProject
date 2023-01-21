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
    public class TransactionManager : ITransactionService
    {
        ITransactionsDal _transactionDal;
        public TransactionManager(ITransactionsDal transactionDal)
        {
            _transactionDal = transactionDal;
        }

        public IResult Add(Transaction transaction)
        {
            _transactionDal.Add(transaction);
            return new SuccessResult(Messages.TransactionAdded);
        }

        public IResult Delete(Transaction transaction)
        {
            _transactionDal.Delete(transaction);
            return new SuccessResult(Messages.TransactionDeleted);
        }

        public IDataResult<List<Transaction>> GetAll()
        {
            return new SuccessDataResult<List<Transaction>>(_transactionDal.GetAll());
        }

        public IResult Update(Transaction transaction)
        {
            _transactionDal.Update(transaction);
            return new SuccessResult(Messages.TransactionUpdated);
        }
    }
}
