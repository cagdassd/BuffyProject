using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public Result(bool isSuccess, string message) : this (isSuccess)
        {
            Message= message;
            //IsSuccess= isSuccess; fazla kod yazmamak için this li kısmı yazdık eğer 2 parametre yollarlarsa ikisini de çalıştıracak
        }

        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
