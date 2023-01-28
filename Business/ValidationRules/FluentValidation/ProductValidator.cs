﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(1);

            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(2).When(p => p.CategoryId==1);
            //RuleFor(p => p.ProductName).Must(StartsWithA);
            RuleFor(p => p.ProductId).NotEmpty();
        }

        
    }
}
