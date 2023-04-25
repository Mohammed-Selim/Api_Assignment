using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Commands.CreaateCategory
{
    public class CeateCategoryCommandValidator:AbstractValidator<CeateCategoryCommand>
    {
     public   CeateCategoryCommandValidator()
        {
            RuleFor(a => a.name)
                .NotEmpty().WithMessage(a => "name is empty")
                .NotNull().WithMessage(a => "name is required")
                .MaximumLength(10).WithMessage(a => "name is less than 10 letters")
                .MaximumLength(50).WithMessage(a => "name is greate than 50 letters");
        }
    }
}
