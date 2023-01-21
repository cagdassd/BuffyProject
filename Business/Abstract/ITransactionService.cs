using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITransactionService
    {
        IResult Add(Transaction transaction);
        IResult Update(Transaction transaction);
        IResult Delete(Transaction transaction);
        IDataResult<List<Transaction>> GetAll();
    }
}
