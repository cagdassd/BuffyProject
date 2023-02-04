using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)//params kısmı birden fazla iş kuralını run etmemizi sağlıyor
        {
            foreach (var logic in logics)
            {
                if (!logic.IsSuccess)
                {
                    return logic; //parametreyle gönderdiğimiz kurallardan hata vereni return ettik
                }
            }
            return null;
        }
    }
}
